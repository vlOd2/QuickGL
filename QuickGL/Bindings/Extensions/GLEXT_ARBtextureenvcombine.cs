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

// Bindings generated at 2025-09-20 18:58:20.037896
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtextureenvcombine
{
    #region Enums
    public const int GL_COMBINE_ARB = 0x8570;
    public const int GL_COMBINE_RGB_ARB = 0x8571;
    public const int GL_COMBINE_ALPHA_ARB = 0x8572;
    public const int GL_SOURCE0_RGB_ARB = 0x8580;
    public const int GL_SOURCE1_RGB_ARB = 0x8581;
    public const int GL_SOURCE2_RGB_ARB = 0x8582;
    public const int GL_SOURCE0_ALPHA_ARB = 0x8588;
    public const int GL_SOURCE1_ALPHA_ARB = 0x8589;
    public const int GL_SOURCE2_ALPHA_ARB = 0x858A;
    public const int GL_OPERAND0_RGB_ARB = 0x8590;
    public const int GL_OPERAND1_RGB_ARB = 0x8591;
    public const int GL_OPERAND2_RGB_ARB = 0x8592;
    public const int GL_OPERAND0_ALPHA_ARB = 0x8598;
    public const int GL_OPERAND1_ALPHA_ARB = 0x8599;
    public const int GL_OPERAND2_ALPHA_ARB = 0x859A;
    public const int GL_RGB_SCALE_ARB = 0x8573;
    public const int GL_ADD_SIGNED_ARB = 0x8574;
    public const int GL_INTERPOLATE_ARB = 0x8575;
    public const int GL_SUBTRACT_ARB = 0x84E7;
    public const int GL_CONSTANT_ARB = 0x8576;
    public const int GL_PRIMARY_COLOR_ARB = 0x8577;
    public const int GL_PREVIOUS_ARB = 0x8578;
    #endregion
    
    #region Commands
    #endregion
    
    internal static void Load()
    {
    }
    
    internal static void Unload()
    {
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_texture_env_combine", true, false);
}
