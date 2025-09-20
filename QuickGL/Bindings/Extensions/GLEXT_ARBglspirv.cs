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

// Bindings generated at 2025-09-20 18:58:19.890008
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBglspirv
{
    #region Enums
    public const int GL_SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;
    public const int GL_SPIR_V_BINARY_ARB = 0x9552;
    #endregion
    
    #region Commands
    public static void glSpecializeShaderARB(uint shader, byte* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) { QGLFeature.VerifyFunc((nint)_glSpecializeShaderARB); _glSpecializeShaderARB(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue); }
    internal static delegate* unmanaged<uint, byte*, uint, uint*, uint*, void> _glSpecializeShaderARB = null;
     #endregion
    
    internal static void Load()
    {
        _glSpecializeShaderARB = (delegate* unmanaged<uint, byte*, uint, uint*, uint*, void>)QuickGL.GetGLProcAddress("glSpecializeShaderARB");
    }
    
    internal static void Unload()
    {
        _glSpecializeShaderARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_gl_spirv", true, false);
}
