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

// Bindings generated at 2025-08-30 15:45:08.801004
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_vertex_type_2_10_10_10_rev", true, false)]
public static unsafe class GLEXT_ARBvertextype2101010rev
{
    #region Enums
    public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
    public const int GL_INT_2_10_10_10_REV = 0x8D9F;
    #endregion
    
    #region Commands
    public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value) { QGLNativeAPI.Verify((nint)_glVertexAttribP1ui); _glVertexAttribP1ui(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP1ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP1ui = null;
    
    public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value) { QGLNativeAPI.Verify((nint)_glVertexAttribP1uiv); _glVertexAttribP1uiv(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP1uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP1uiv = null;
    
    public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value) { QGLNativeAPI.Verify((nint)_glVertexAttribP2ui); _glVertexAttribP2ui(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP2ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP2ui = null;
    
    public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value) { QGLNativeAPI.Verify((nint)_glVertexAttribP2uiv); _glVertexAttribP2uiv(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP2uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP2uiv = null;
    
    public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value) { QGLNativeAPI.Verify((nint)_glVertexAttribP3ui); _glVertexAttribP3ui(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP3ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP3ui = null;
    
    public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value) { QGLNativeAPI.Verify((nint)_glVertexAttribP3uiv); _glVertexAttribP3uiv(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP3uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP3uiv = null;
    
    public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value) { QGLNativeAPI.Verify((nint)_glVertexAttribP4ui); _glVertexAttribP4ui(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP4ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP4ui = null;
    
    public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value) { QGLNativeAPI.Verify((nint)_glVertexAttribP4uiv); _glVertexAttribP4uiv(index, type, normalized, value); }
    [QGLNativeAPI("glVertexAttribP4uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP4uiv = null;
    
    public static void glVertexP2ui(uint type, uint value) { QGLNativeAPI.Verify((nint)_glVertexP2ui); _glVertexP2ui(type, value); }
    [QGLNativeAPI("glVertexP2ui")] internal static delegate* unmanaged<uint, uint, void> _glVertexP2ui = null;
    
    public static void glVertexP2uiv(uint type, uint* value) { QGLNativeAPI.Verify((nint)_glVertexP2uiv); _glVertexP2uiv(type, value); }
    [QGLNativeAPI("glVertexP2uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexP2uiv = null;
    
    public static void glVertexP3ui(uint type, uint value) { QGLNativeAPI.Verify((nint)_glVertexP3ui); _glVertexP3ui(type, value); }
    [QGLNativeAPI("glVertexP3ui")] internal static delegate* unmanaged<uint, uint, void> _glVertexP3ui = null;
    
    public static void glVertexP3uiv(uint type, uint* value) { QGLNativeAPI.Verify((nint)_glVertexP3uiv); _glVertexP3uiv(type, value); }
    [QGLNativeAPI("glVertexP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexP3uiv = null;
    
    public static void glVertexP4ui(uint type, uint value) { QGLNativeAPI.Verify((nint)_glVertexP4ui); _glVertexP4ui(type, value); }
    [QGLNativeAPI("glVertexP4ui")] internal static delegate* unmanaged<uint, uint, void> _glVertexP4ui = null;
    
    public static void glVertexP4uiv(uint type, uint* value) { QGLNativeAPI.Verify((nint)_glVertexP4uiv); _glVertexP4uiv(type, value); }
    [QGLNativeAPI("glVertexP4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexP4uiv = null;
    
    public static void glTexCoordP1ui(uint type, uint coords) { QGLNativeAPI.Verify((nint)_glTexCoordP1ui); _glTexCoordP1ui(type, coords); }
    [QGLNativeAPI("glTexCoordP1ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP1ui = null;
    
    public static void glTexCoordP1uiv(uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glTexCoordP1uiv); _glTexCoordP1uiv(type, coords); }
    [QGLNativeAPI("glTexCoordP1uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP1uiv = null;
    
    public static void glTexCoordP2ui(uint type, uint coords) { QGLNativeAPI.Verify((nint)_glTexCoordP2ui); _glTexCoordP2ui(type, coords); }
    [QGLNativeAPI("glTexCoordP2ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP2ui = null;
    
    public static void glTexCoordP2uiv(uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glTexCoordP2uiv); _glTexCoordP2uiv(type, coords); }
    [QGLNativeAPI("glTexCoordP2uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP2uiv = null;
    
    public static void glTexCoordP3ui(uint type, uint coords) { QGLNativeAPI.Verify((nint)_glTexCoordP3ui); _glTexCoordP3ui(type, coords); }
    [QGLNativeAPI("glTexCoordP3ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP3ui = null;
    
    public static void glTexCoordP3uiv(uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glTexCoordP3uiv); _glTexCoordP3uiv(type, coords); }
    [QGLNativeAPI("glTexCoordP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP3uiv = null;
    
    public static void glTexCoordP4ui(uint type, uint coords) { QGLNativeAPI.Verify((nint)_glTexCoordP4ui); _glTexCoordP4ui(type, coords); }
    [QGLNativeAPI("glTexCoordP4ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP4ui = null;
    
    public static void glTexCoordP4uiv(uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glTexCoordP4uiv); _glTexCoordP4uiv(type, coords); }
    [QGLNativeAPI("glTexCoordP4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP4uiv = null;
    
    public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP1ui); _glMultiTexCoordP1ui(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP1ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP1ui = null;
    
    public static void glMultiTexCoordP1uiv(uint texture, uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP1uiv); _glMultiTexCoordP1uiv(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP1uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP1uiv = null;
    
    public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP2ui); _glMultiTexCoordP2ui(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP2ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP2ui = null;
    
    public static void glMultiTexCoordP2uiv(uint texture, uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP2uiv); _glMultiTexCoordP2uiv(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP2uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP2uiv = null;
    
    public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP3ui); _glMultiTexCoordP3ui(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP3ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP3ui = null;
    
    public static void glMultiTexCoordP3uiv(uint texture, uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP3uiv); _glMultiTexCoordP3uiv(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP3uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP3uiv = null;
    
    public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP4ui); _glMultiTexCoordP4ui(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP4ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP4ui = null;
    
    public static void glMultiTexCoordP4uiv(uint texture, uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glMultiTexCoordP4uiv); _glMultiTexCoordP4uiv(texture, type, coords); }
    [QGLNativeAPI("glMultiTexCoordP4uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP4uiv = null;
    
    public static void glNormalP3ui(uint type, uint coords) { QGLNativeAPI.Verify((nint)_glNormalP3ui); _glNormalP3ui(type, coords); }
    [QGLNativeAPI("glNormalP3ui")] internal static delegate* unmanaged<uint, uint, void> _glNormalP3ui = null;
    
    public static void glNormalP3uiv(uint type, uint* coords) { QGLNativeAPI.Verify((nint)_glNormalP3uiv); _glNormalP3uiv(type, coords); }
    [QGLNativeAPI("glNormalP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glNormalP3uiv = null;
    
    public static void glColorP3ui(uint type, uint color) { QGLNativeAPI.Verify((nint)_glColorP3ui); _glColorP3ui(type, color); }
    [QGLNativeAPI("glColorP3ui")] internal static delegate* unmanaged<uint, uint, void> _glColorP3ui = null;
    
    public static void glColorP3uiv(uint type, uint* color) { QGLNativeAPI.Verify((nint)_glColorP3uiv); _glColorP3uiv(type, color); }
    [QGLNativeAPI("glColorP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glColorP3uiv = null;
    
    public static void glColorP4ui(uint type, uint color) { QGLNativeAPI.Verify((nint)_glColorP4ui); _glColorP4ui(type, color); }
    [QGLNativeAPI("glColorP4ui")] internal static delegate* unmanaged<uint, uint, void> _glColorP4ui = null;
    
    public static void glColorP4uiv(uint type, uint* color) { QGLNativeAPI.Verify((nint)_glColorP4uiv); _glColorP4uiv(type, color); }
    [QGLNativeAPI("glColorP4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glColorP4uiv = null;
    
    public static void glSecondaryColorP3ui(uint type, uint color) { QGLNativeAPI.Verify((nint)_glSecondaryColorP3ui); _glSecondaryColorP3ui(type, color); }
    [QGLNativeAPI("glSecondaryColorP3ui")] internal static delegate* unmanaged<uint, uint, void> _glSecondaryColorP3ui = null;
    
    public static void glSecondaryColorP3uiv(uint type, uint* color) { QGLNativeAPI.Verify((nint)_glSecondaryColorP3uiv); _glSecondaryColorP3uiv(type, color); }
    [QGLNativeAPI("glSecondaryColorP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glSecondaryColorP3uiv = null;
     #endregion
}
