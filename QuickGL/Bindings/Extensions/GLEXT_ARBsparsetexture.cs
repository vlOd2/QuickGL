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

// Bindings generated at 2025-09-20 18:58:20.003010
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBsparsetexture
{
    #region Enums
    public const int GL_TEXTURE_SPARSE_ARB = 0x91A6;
    public const int GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;
    public const int GL_NUM_SPARSE_LEVELS_ARB = 0x91AA;
    public const int GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;
    public const int GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;
    public const int GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;
    public const int GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;
    public const int GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;
    public const int GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;
    public const int GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A;
    public const int GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;
    #endregion
    
    #region Commands
    public static void glTexPageCommitmentARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) { QGLFeature.VerifyFunc((nint)_glTexPageCommitmentARB); _glTexPageCommitmentARB(target, level, xoffset, yoffset, zoffset, width, height, depth, commit); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, bool, void> _glTexPageCommitmentARB = null;
     #endregion
    
    internal static void Load()
    {
        _glTexPageCommitmentARB = (delegate* unmanaged<uint, int, int, int, int, int, int, int, bool, void>)QuickGL.GetGLProcAddress("glTexPageCommitmentARB");
    }
    
    internal static void Unload()
    {
        _glTexPageCommitmentARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_sparse_texture", true, false);
}
