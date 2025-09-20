// MIT License
// 
// Copyright (c) 2025 vlOd
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using QuickGLNS.Bindings;
using QuickGLNS.Internal;

namespace QuickGLNS;

/// <summary>
/// Class to load and manage GLFW, OpenGL with additional utilities
/// </summary>
public static unsafe partial class QuickGL
{
    private static GLFWLoader glfwLoader;
    private static OpenALLoader openALLoader;
    internal static bool initialized;
    internal static bool doNotUseGLFW;
    internal static delegate* unmanaged<byte*, nint> nativeAPILoader;
    #region Context properties
    /// <summary>
    /// Indicates if QuickGL has been initialized
    /// </summary>
    public static bool IsInitialized => initialized;
    /// <summary>
    /// Indicates if the current context is for OpenGL ES
    /// </summary>
    public static bool IsGLESContext { get; private set; }
    /// <summary>
    /// The major version of the current OpenGL context
    /// </summary>
    public static int GLVersionMajor { get; private set; }
    /// <summary>
    /// The minor version of the current OpenGL context
    /// </summary>
    public static int GLVersionMinor { get; private set; }
    /// <summary>
    /// List of all available OpenGL extensions
    /// </summary>
    public static string[] SupportedExtensions { get; private set; }
    #endregion

    [GeneratedRegex(@"(\d)\.(\d)(?:\.\d)?(?= )")]
    private static partial Regex GLVersionRegex();

    /// <summary>
    /// Initializes QuickGL and loads GLFW functions
    /// </summary>
    /// <param name="winLibName">the GLFW library name to use on Windows platforms, null for default</param>
    /// <param name="unixLibName">the GLFW library name to use on Unix platforms, null for default</param>
    /// <exception cref="GLException">if GLFW could not be loaded successfully</exception>
    public static void Init(string winLibName = null, string unixLibName = null)
    {
        if (initialized)
            throw new GLException("Already initialized");
        glfwLoader = new(winLibName, unixLibName);
        GLFW.Load();
        initialized = true;
        nativeAPILoader = GLFW._glfwGetProcAddress;
    }

    /// <summary>
    /// Initializes QuickGL without GLFW<br/>
    /// NOTE: This mode is not recommended and will not receive support
    /// </summary>
    /// <param name="gles">is the current context for gles</param>
    /// <param name="loader">the function called to load OpenGL functions from</param>
    public static void InitNoGLFW(bool gles, delegate* unmanaged<byte*, nint> loader)
    {
        if (initialized)
            throw new GLException("Already initialized");
        initialized = true;
        doNotUseGLFW = true;
        IsGLESContext = gles;
        nativeAPILoader = loader;
    }

    private static void PerformContextChecks()
    {
        if (!initialized)
            throw new GLException("Not initialized");
        if (!doNotUseGLFW && GLFW.glfwGetCurrentContext() == 0)
            throw new GLException("No OpenGL context found");
    }

    /// <summary>
    /// Loads OpenAL's AL/ALC functions
    /// </summary>
    /// <param name="winLibName">the OpenAL library name to use on Windows platforms, null for default</param>
    /// <param name="unixLibName">the OpenAL library name to use on Unix platforms, null for default</param>
    /// <exception cref="GLException"></exception>
    public static void LoadAL(string winLibName = null, string unixLibName = null)
    {
        if (!initialized)
            throw new GLException("Not initialized");
        openALLoader = new(winLibName, unixLibName);
        AL.Load();
        ALC.Load();
    }

    private static void ParseGLVersion()
    {
        delegate* unmanaged<uint, byte*> glGetString = (delegate* unmanaged<uint, byte*>)GetGLProcAddress("glGetString");
        if (glGetString == null)
            throw new GLException("Could not initialize OpenGL");

        byte* versionRaw = glGetString(GL10.GL_VERSION);
        if (versionRaw == null)
            throw new GLException("Could not figure out OpenGL version");

        using QGLString version = new(versionRaw);
        Match match = GLVersionRegex().Match(version);
        if (!match.Success)
            throw new GLException("Could not parse OpenGL version");
        GLVersionMajor = int.Parse(match.Groups[1].Value);
        GLVersionMinor = int.Parse(match.Groups[2].Value);

        if (GLVersionMajor >= 3)
        {
            delegate* unmanaged<uint, uint, byte*> glGetStringi = (delegate* unmanaged<uint, uint, byte*>)GetGLProcAddress("glGetStringi");
            delegate* unmanaged<uint, int*, byte*> glGetIntegerv = (delegate* unmanaged<uint, int*, byte*>)GetGLProcAddress("glGetIntegerv");
            if (glGetStringi == null || glGetIntegerv == null)
                throw new GLException("Could not figure out OpenGL extensions");

            int count;
            glGetIntegerv(GL30.GL_NUM_EXTENSIONS, &count);

            List<string> ext = [];
            for (int i = 0; i < count; i++)
            {
                using QGLString str = new(glGetStringi(GL10.GL_EXTENSIONS, (uint)i));
                ext.Add(str.Data);
            }
            SupportedExtensions = [.. ext];
        }
        else
        {
            byte* extensionsRaw = glGetString(GL10.GL_EXTENSIONS);
            if (extensionsRaw == null)
                throw new GLException("Could not figure out OpenGL extensions");
            using QGLString extensions = new(extensionsRaw);
            SupportedExtensions = ((string)extensions).Trim().Split(" ");
        }
    }

    /// <summary>
    /// Loads OpenGL/GLES functions<br/>
    /// NOTE: You must have an active OpenGL/GLES context, see <see cref="GLFW.glfwMakeContextCurrent"/>
    /// </summary>
    /// <exception cref="GLException"></exception>
    public static void LoadGL()
    {
        PerformContextChecks();
        ParseGLVersion();

        if (!doNotUseGLFW)
        {
            nint window = GLFW.glfwGetCurrentContext();
            int api = GLFW.glfwGetWindowAttrib(window, GLFW.GLFW_CLIENT_API);
            IsGLESContext = api == GLFW.GLFW_OPENGL_ES_API;
        }

        GLBindingsManager.Load();
    }

    internal static bool IsFeatureSupported(QGLFeature feature)
    {
        if (feature.IsGLES != IsGLESContext)
            return false;
        if (feature.IsExtension)
            return SupportedExtensions.Contains(feature.Name.Trim());
        string[] featureVer = feature.Name.Split('_')[^2..];
        if (featureVer.Length != 2)
            throw new ArgumentException("Invalid feature version");
        if (!int.TryParse(featureVer[0], out int majorVer) || !int.TryParse(featureVer[1], out int minorVer))
            throw new ArgumentException("Could not parse feature version");
        return IsGLVersionAvailable(majorVer, minorVer);
    }

    /// <summary>
    /// Checks if the given OpenGL version can be used
    /// </summary>
    /// <param name="major">the major part of the version</param>
    /// <param name="minor">the minor part of the version</param>
    /// <returns>true if the version can be used, false if otherwise</returns>
    /// <exception cref="GLException">if not initialized or no context is found</exception>
    public static bool IsGLVersionAvailable(int major, int minor)
    {
        PerformContextChecks();
        return GLVersionMajor > major || (GLVersionMajor == major && GLVersionMinor >= minor);
    }

    /// <summary>
    /// Gets the native pointer to an OpenGL function<br />
    /// Attempting to resolve invalid/unavailable functions will return an undefined value
    /// </summary>
    /// <param name="name">the name of the function</param>
    /// <returns>the pointer to the native function</returns>
    public static nint GetGLProcAddress(string name)
    {
        PerformContextChecks();
        nint handle;
        using (QGLString str = new(name))
            handle = nativeAPILoader(str);
        return handle;
    }

    internal static nint GetGLFWProcAddress(string name)
    {
        nint handle = glfwLoader.GetProcAddress(name);
        if (handle == nint.Zero)
        {
            Console.Error.WriteLine($"[QuickGL] Could not find GLFW method: {name}");
            return nint.Zero;
        }
        return handle;
    }

    internal static nint GetALProcAddress(string name)
    {
        nint handle = openALLoader.GetProcAddress(name);
        if (handle == nint.Zero)
        {
            Console.Error.WriteLine($"[QuickGL] Could not find OpenAL method: {name}");
            return nint.Zero;
        }
        return handle;
    }

    /// <summary>
    /// Cleans up QuickGL and releases any OpenGL and GLFW functions
    /// </summary>
    public static void Destroy()
    {
        GLBindingsManager.Unload();
        GLFW.Unload();
        AL.Unload();
        ALC.Unload();

        glfwLoader?.Dispose();
        glfwLoader = null;
        GLVersionMajor = GLVersionMinor = 0;
        initialized = false;
        doNotUseGLFW = false;
        nativeAPILoader = null;
    }

    /// <summary>
    /// Helper function to get a pointer to stack allocated span's data
    /// </summary>
    /// <param name="span">the span to convert</param>
    /// <typeparam name="T">the type of the span</typeparam>
    /// <returns>the pointer to the span's data</returns>
    public static T* ToPtr<T>(Span<T> span) where T : unmanaged => (T*)Unsafe.AsPointer(ref span.GetPinnableReference());

    /// <summary>
    /// Helper function to get a pointer to stack allocated read only span's data<br/>
    /// NOTE: Make sure the function accesing the returned pointer does not try to modify it
    /// </summary>
    /// <param name="span">the span to convert</param>
    /// <typeparam name="T">the type of the span</typeparam>
    /// <returns>the pointer to the span's data</returns>
    public static T* ToPtr<T>(ReadOnlySpan<T> span) where T : unmanaged => (T*)Unsafe.AsPointer(ref Unsafe.AsRef(in span.GetPinnableReference()));
}