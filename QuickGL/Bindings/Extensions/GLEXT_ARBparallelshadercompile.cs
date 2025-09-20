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

using QuickGLNS.Internal;

// Bindings generated at 2025-09-20 18:58:19.921489
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBparallelshadercompile
{
    #region Enums
    public const int GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;
    public const int GL_COMPLETION_STATUS_ARB = 0x91B1;
    #endregion
    
    #region Commands
    public static void glMaxShaderCompilerThreadsARB(uint count) { QGLFeature.VerifyFunc((nint)_glMaxShaderCompilerThreadsARB); _glMaxShaderCompilerThreadsARB(count); }
    internal static delegate* unmanaged<uint, void> _glMaxShaderCompilerThreadsARB = null;
     #endregion
    
    internal static void Load()
    {
        _glMaxShaderCompilerThreadsARB = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glMaxShaderCompilerThreadsARB");
    }
    
    internal static void Unload()
    {
        _glMaxShaderCompilerThreadsARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_parallel_shader_compile", true, false);
}
