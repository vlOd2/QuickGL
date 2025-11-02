#define SHOW_TASK_TIMINGS
//#define ENABLE_LEGACY_LIB_UI

using QGLBindingsGen.CParsing;
using QGLBindingsGen.GLRegistry;
#if SHOW_TASK_TIMINGS
using System.Diagnostics;
#endif
#if ENABLE_LEGACY_LIB_UI
using System.Text.RegularExpressions;
#endif

namespace QGLBindingsGen;

public static partial class Program
{
    private const string OUT_DIR = "BindingsOutput";
    private const string BINDINGS_NAMESPACE = "QuickGLNS.Bindings";
    private const string GLFW_HEADER_URL = "https://raw.githubusercontent.com/glfw/glfw/refs/heads/master/include/GLFW/glfw3.h";
    private const string GL_REGISTRY_URL = "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/refs/heads/main/xml/gl.xml";
    private const string AL_HEADER_URL = "https://raw.githubusercontent.com/kcat/openal-soft/refs/heads/master/include/AL/al.h";
    private const string ALC_HEADER_URL = "https://raw.githubusercontent.com/kcat/openal-soft/refs/heads/master/include/AL/alc.h";
#if ENABLE_LEGACY_LIB_UI
    private const string LIBUI_HEADER_URL = "https://raw.githubusercontent.com/andlabs/libui/refs/heads/master/ui.h";
#endif
    private static readonly HttpClient httpClient = new();

#if ENABLE_LEGACY_LIB_UI
    [GeneratedRegex(@"_UI_ENUM\((ui[a-zA-Z0-9_]+?)\) {((.|\s)+?)};")]
    private static partial Regex UIEnumPattern();
#endif

    private static async Task<string[]> GetOrCacheFile(string fileName, string url)
    {
        List<string> lines;
        if (!File.Exists(fileName))
        {
            StringReader reader = new(await httpClient.GetStringAsync(url));
            lines = [];
            while (await reader.ReadLineAsync() is string line)
                lines.Add(line);
            await File.WriteAllLinesAsync(fileName, lines);
        }
        else
            lines = [.. await File.ReadAllLinesAsync(fileName)];
        return [.. lines];
    }

    private static async Task<CParserContext> ParseGLFWHeader()
    {
        string[] header = await TaskRunner.Run("Downloading GLFW header", GetOrCacheFile("glfw3.h", GLFW_HEADER_URL));
        CParserContext ctx = new(["GLFWAPI", "APIENTRY", "WINGDIAPI", "CALLBACK"]);
        await CParser.ParseFile(header, ctx);
        return ctx;
    }

    private static async Task<List<GLFeature>> ParseGLRegistry(List<string> allowedFeatures, List<string> allowedExt)
    {
        string[] registry = await TaskRunner.Run("Downloading GL registry", GetOrCacheFile("gl.xml", GL_REGISTRY_URL));
        CParserContext baseCtx = new();
        baseCtx.TypeMap.Add("GLenum", "uint");
        baseCtx.TypeMap.Add("GLboolean", "bool");
        baseCtx.TypeMap.Add("GLbitfield", "uint");
        baseCtx.TypeMap.Add("GLvoid", "void");
        baseCtx.TypeMap.Add("GLbyte", "sbyte");
        baseCtx.TypeMap.Add("GLubyte", "byte");
        baseCtx.TypeMap.Add("GLshort", "short");
        baseCtx.TypeMap.Add("GLushort", "ushort");
        baseCtx.TypeMap.Add("GLint", "int");
        baseCtx.TypeMap.Add("GLuint", "uint");
        baseCtx.TypeMap.Add("GLclampx", "int");
        baseCtx.TypeMap.Add("GLsizei", "int");
        baseCtx.TypeMap.Add("GLfloat", "float");
        baseCtx.TypeMap.Add("GLclampf", "float");
        baseCtx.TypeMap.Add("GLdouble", "double");
        baseCtx.TypeMap.Add("GLclampd", "double");
        baseCtx.TypeMap.Add("GLchar", "byte");
        baseCtx.TypeMap.Add("GLcharARB", "byte");
        baseCtx.TypeMap.Add("GLhalf", "ushort");
        baseCtx.TypeMap.Add("GLhalfARB", "ushort");
        baseCtx.TypeMap.Add("GLfixed", "int");
        baseCtx.TypeMap.Add("GLintptr", "nint");
        baseCtx.TypeMap.Add("GLintptrARB", "nint");
        baseCtx.TypeMap.Add("GLsizeiptr", "nint");
        baseCtx.TypeMap.Add("GLsizeiptrARB", "nint");
        baseCtx.TypeMap.Add("GLint64", "long");
        baseCtx.TypeMap.Add("GLint64EXT", "long");
        baseCtx.TypeMap.Add("GLuint64", "ulong");
        baseCtx.TypeMap.Add("GLuint64EXT", "ulong");
        baseCtx.TypeMap.Add("GLhalfNV", "ushort");
        baseCtx.TypeMap.Add("GLsync", "nint");
        baseCtx.TypeMap.Add("GLvdpauSurfaceNV", "nint");
        return await GLRegistryParser.Parse(baseCtx, registry, allowedFeatures, allowedExt);
    }

    private static async Task<CParserContext> ParseALHeader()
    {
        string[] header = await TaskRunner.Run("Downloading AL header", GetOrCacheFile("al.h", AL_HEADER_URL));
        CParserContext ctx = new(["AL_APIENTRY", "AL_API_NOEXCEPT17", "AL_API_NOEXCEPT", "AL_API", "AL_CPLUSPLUS"]);
        ctx.TypeMap.Add("ALboolean", "bool");
        ctx.TypeMap.Add("ALchar", "byte");
        ctx.TypeMap.Add("ALbyte", "sbyte");
        ctx.TypeMap.Add("ALubyte", "byte");
        ctx.TypeMap.Add("ALshort", "short");
        ctx.TypeMap.Add("ALushort", "ushort");
        ctx.TypeMap.Add("ALint", "int");
        ctx.TypeMap.Add("ALuint", "uint");
        ctx.TypeMap.Add("ALsizei", "int");
        ctx.TypeMap.Add("ALenum", "int");
        ctx.TypeMap.Add("ALfloat", "float");
        ctx.TypeMap.Add("ALdouble", "double");
        ctx.TypeMap.Add("ALvoid", "void");
        await CParser.ParseFile(header, ctx);
        return ctx;
    }

    private static async Task<CParserContext> ParseALCHeader()
    {
        string[] header = await TaskRunner.Run("Downloading ALC header", GetOrCacheFile("alc.h", ALC_HEADER_URL));
        CParserContext ctx = new(["ALC_APIENTRY", "ALC_API_NOEXCEPT17", "ALC_API_NOEXCEPT", "ALC_API", "ALC_CPLUSPLUS"]);
        ctx.TypeMap.Add("ALCboolean", "bool");
        ctx.TypeMap.Add("ALCchar", "byte");
        ctx.TypeMap.Add("ALCbyte", "sbyte");
        ctx.TypeMap.Add("ALCubyte", "byte");
        ctx.TypeMap.Add("ALCshort", "short");
        ctx.TypeMap.Add("ALCushort", "ushort");
        ctx.TypeMap.Add("ALCint", "int");
        ctx.TypeMap.Add("ALCuint", "uint");
        ctx.TypeMap.Add("ALCsizei", "int");
        ctx.TypeMap.Add("ALCenum", "int");
        ctx.TypeMap.Add("ALCfloat", "float");
        ctx.TypeMap.Add("ALCdouble", "double");
        ctx.TypeMap.Add("ALCvoid", "void");
        await CParser.ParseFile(header, ctx);
        return ctx;
    }

#if ENABLE_LEGACY_LIB_UI
    private static async Task<CParserContext> ParseLibUIHeader()
    {
        string[] header = await TaskRunner.Run("Downloading LibUI header", GetOrCacheFile("ui.h", LIBUI_HEADER_URL));
        CParserContext ctx = new(["_UI_EXTERN"]);
        await CParser.ParseFile(header, ctx, lines =>
        {
            Logger.Info("[LibUI] Parsing enums");
            string allLines = string.Join("\n", lines);
            foreach (Match match in UIEnumPattern().Matches(allLines))
            {
                string name = match.Groups[1].Value.Trim();
                string values = match.Groups[2].Value.Trim();
                if (!ctx.CheckSymbol(name))
                    continue;
                ctx.Enums.Add(new(name, values));
            }
        });
        return ctx;
    }
#endif

    private static async Task GenerateHeader(string name, CParserContext ctx, string procAddr)
        => await File.WriteAllTextAsync(Path.Combine(OUT_DIR, $"{name}.cs"), Generator.Generate(ctx, name, BINDINGS_NAMESPACE, procAddr));

    private static async Task MainAsync()
    {
        Directory.CreateDirectory(OUT_DIR);

        Logger.Info("Generating bindings for GLFW");
        await GenerateHeader("GLFW", await ParseGLFWHeader(), "QuickGL.GetGLFWProcAddress");

        Logger.Info("Generating bindings for OpenAL");
        await GenerateHeader("AL", await ParseALHeader(), "QuickGL.GetALProcAddress");
        await GenerateHeader("ALC", await ParseALCHeader(), "QuickGL.GetALProcAddress");

#if ENABLE_LEGACY_LIB_UI
        Logger.Info("Generating bindings for LibUI");
        await GenerateHeader("LibUI", await ParseLibUIHeader(), "QuickGL.GetLibUIProcAddress");
#endif

        Logger.Info("Generating bindings for OpenGL");
        List<GLFeature> features = await ParseGLRegistry(null, ["@/GL_ARB_.*", "@/GL_EXT_.*"]);
        if (features.Any(feature => feature.IsExtension))
            Directory.CreateDirectory(Path.Combine(OUT_DIR, "Extensions"));
        await Parallel.ForEachAsync(features, async (feature, token) =>
        {
            string classData = Generator.GenerateGLFeature(feature, feature.IsExtension ? $"{BINDINGS_NAMESPACE}.Extensions" : BINDINGS_NAMESPACE);
            string outDir = OUT_DIR;
            if (feature.IsExtension)
                outDir = Path.Combine(OUT_DIR, "Extensions");
            await File.WriteAllTextAsync(Path.Combine(outDir, $"{Generator.GetGLFeatureClassName(feature)}.cs"), classData, token);
        });

        Logger.Info("Generating OpenGL bindings manager");
        await File.WriteAllTextAsync(Path.Combine(OUT_DIR, "GLBindingsManager.cs"), Generator.GenerateGLBindingsMgr(features, BINDINGS_NAMESPACE));

        Logger.Info("Done! Bindings generated successfully");
    }

    public static void Main()
    {
        try
        {
            MainAsync().GetAwaiter().GetResult();

#if SHOW_TASK_TIMINGS
            Logger.Info("Task timings:");
            double totalTime = 0;
            foreach (KeyValuePair<string, (long, long)> timing in TaskRunner.TaskTimings)
            {
                TimeSpan time = Stopwatch.GetElapsedTime(timing.Value.Item1, timing.Value.Item2);
                totalTime += time.TotalMilliseconds;
                Logger.Info($"- {timing.Key}: {time.TotalMilliseconds:F2} ms");
            }
            Logger.Info($"Total time: {totalTime:F2} ms");
#endif
        }
        catch (Exception ex)
        {
            Logger.Log(Logger.LogLevel.ERROR, $"An error has occured", ex);
#if DEBUG
            throw;
#endif
        }
    }
}
