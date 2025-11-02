using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace QGLBindingsGen.CParsing;

internal partial class CTypeConverter
{
    #region Patterns
    [GeneratedRegex(@"\[\d+\]")]
    private static partial Regex ArraySizeRemovalPattern();

    [GeneratedRegex(@"^.*\[(\d+)\]$")]
    private static partial Regex ArraySizePattern();

    [GeneratedRegex(@"\b(const|volatile|restrict|inline)\b")]
    private static partial Regex QualifierPattern();
    #endregion
    private CParserContext ctx;
    private List<(CType, bool)> pending = [];
    private bool scheduleUnknown;

    public CTypeConverter(CParserContext ctx)
    {
        this.ctx = ctx;
    }

    private static readonly List<string> RESERVED_NAMES =
    [
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class",
        "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum",
        "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach",
        "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long",
        "namespace", "new", "null", "object", "operator", "out", "override", "params", "private",
        "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof",
        "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof",
        "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while"
    ];

    // doesn't handle octal numbers, but those are almost never used anyway
    public static (CType type, string value) ProcessConstant(string s)
    {
        ulong value;
        long sValue = 0;
        bool useSigned = false;

        if (s.StartsWith("0x"))
        {
            s = s[2..];
            if (!ulong.TryParse(s, NumberStyles.HexNumber, null, out value))
                return (null, null);
        }
        else if (!ulong.TryParse(s, null, out value))
        {
            if (!long.TryParse(s, null, out sValue))
            {
                if (float.TryParse(s, out _))
                    return (new("float"), s);
                return (null, null);
            }
            useSigned = true;
        }

        if (useSigned)
        {
            if (sValue < 0)
            {
                if (sValue < int.MinValue)
                    return (new("long"), sValue.ToString());
                return (new("int"), sValue.ToString());
            }
            Logger.Warn($"Parsed as signed value when unsigned was possible: {s}");
            return (null, null);
        }

        if (value > 0x7FFFFFFF_FFFFFFFF)
            return (new("ulong"), $"0x{value:X16}");
        else if (value > 0xFFFFFFFF)
            return (new("long"), $"0x{(long)value:X8}");
        else if (value > 0x7FFFFFFF)
            return (new("uint"), $"0x{(uint)value:X8}");
        return (new("int"), $"0x{(int)value:X8}");
    }

    private static string SanitizeName(string name)
    {
        name = name.Trim();
        if (RESERVED_NAMES.Contains(name))
            return $"@{name}";
        return name;
    }

    private (string, int, string) ConvertType(string type, int ptrCount, bool convertCallbacks)
    {
        string convertedType = null;
        string nativeConvertedName = null;
        foreach (CDefinition def in ctx.Definitions)
        {
            if (type == def.Name)
            {
                if (def.Callback != null && convertCallbacks)
                {
                    convertedType = "nint";
                    ptrCount--;
                    if (ptrCount < 0)
                        ptrCount = 0;
                    nativeConvertedName = def.Name;
                }
                else
                    convertedType = type;
                break;
            }
        }

        foreach (CStruct s in ctx.Structs)
        {
            if (type == s.Name)
            {
                convertedType = type;
                break;
            }
        }

        foreach (CEnum e in ctx.Enums)
        {
            if (type == e.Name)
            {
                convertedType = type;
                break;
            }
        }

        convertedType ??= type switch
        {
            "void" => "void",
            "char" => "byte",
            "short" => "short",
            "int" => "int",
            "long" => "nint",
            "long long" => "long",
            "unsigned char" => "byte",
            "unsigned short" => "ushort",
            "unsigned int" => "uint",
            "unsigned long" => "nuint",
            "unsigned long long" => "ulong",
            "float" => "float",
            "double" => "double",
            "size_t" => "nuint",
            "int8_t" => "sbyte",
            "int16_t" => "short",
            "int32_t" => "int",
            "int64_t" => "long",
            "uint8_t" => "byte",
            "uint16_t" => "ushort",
            "uint32_t" => "uint",
            "uint64_t" => "ulong",
            "intptr_t" => "nint",
            "uintptr_t" => "nuint",
            _ => null
        };
        convertedType ??= ctx.TypeMap.GetValueOrDefault(type);

        return (convertedType, ptrCount, nativeConvertedName);
    }

    public (CType, string) Convert(string type, string argName, bool convertCallbacks)
    {
        type = QualifierPattern().Replace(type, "").Trim();
        int ptrCount = type.Where(c => c == '*').Count();
        type = type.Replace("*", "").Trim();

        if (argName != null)
        {
            while (argName.StartsWith('*'))
            {
                argName = argName[1..].Trim();
                ptrCount++;
            }
            if (argName.EndsWith("[]"))
            {
                ptrCount++;
                argName = argName[..^2].Trim();
            }
            else
            {
                Match match = ArraySizePattern().Match(argName);
                if (match.Success)
                {
                    ptrCount++;
                    argName = ArraySizeRemovalPattern().Replace(argName, "").Trim();
                }
            }
            argName = SanitizeName(argName);
        }

        (string convertedType, ptrCount, string nativeConvertedName) = ConvertType(type, ptrCount, convertCallbacks);

        if (convertedType == null)
        {
            if (scheduleUnknown)
            {
                CType cType = new(type, ptrCount);
                pending.Add((cType, convertCallbacks));
                return (cType, argName?.Trim());
            }

            convertedType = "nint";
            ptrCount = 0;
            if (!ctx.UnknownTypes.Contains(type))
            {
                ctx.UnknownTypes.Add(type);
                Logger.Warn($"Unknown type: {type}");
            }
        }

        return (new CType(convertedType, ptrCount, nativeConvertedName), argName?.Trim());
    }

    public void BeginScheduleUnknown()
    {
        pending.Clear();
        scheduleUnknown = true;
    }

    public void EndScheduleUnknown()
    {
        if (!scheduleUnknown)
            return;
        scheduleUnknown = false;

        int initialCount = pending.Count;
        int convertedCount = 0;
        int unknownCount = 0;

        for (int i = 0; i < pending.Count; i++)
        {
            (CType typeObj, bool convertCallbacks) = pending[i];
            string type = typeObj.Name;
            int ptrCount = typeObj.PointerCount;

            (string convertedType, ptrCount, string nativeConvertedName) = ConvertType(type, ptrCount, convertCallbacks);
            if (convertedType == null)
            {
                typeObj.Name = "nint";
                typeObj.PointerCount = 0;
                if (!ctx.UnknownTypes.Contains(type))
                {
                    ctx.UnknownTypes.Add(type);
                    Logger.Warn($"[Pending] Unknown type: {type}");
                }
                unknownCount++;
                continue;
            }

            typeObj.Name = convertedType;
            typeObj.PointerCount = ptrCount;
            typeObj.NativeConvertedName = nativeConvertedName;
            convertedCount++;
        }

        pending.Clear();
        Logger.Info($"Converted {convertedCount}/{initialCount} pending types ({unknownCount} unknown)");
    }
}
