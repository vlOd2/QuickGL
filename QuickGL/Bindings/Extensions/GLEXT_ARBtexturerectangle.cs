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

// Bindings generated at 2025-09-20 18:58:20.064716
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtexturerectangle
{
    #region Enums
    public const int GL_TEXTURE_RECTANGLE_ARB = 0x84F5;
    public const int GL_TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6;
    public const int GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7;
    public const int GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8;
    #endregion
    
    #region Commands
    #endregion
    
    internal static void Load()
    {
    }
    
    internal static void Unload()
    {
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_texture_rectangle", true, false);
}
