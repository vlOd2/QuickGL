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

// Bindings generated at 2025-09-20 18:58:19.837925
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBcomputevariablegroupsize
{
    #region Enums
    public const int GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
    public const int GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;
    public const int GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;
    public const int GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;
    #endregion
    
    #region Commands
    public static void glDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z) { QGLFeature.VerifyFunc((nint)_glDispatchComputeGroupSizeARB); _glDispatchComputeGroupSizeARB(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z); }
    internal static delegate* unmanaged<uint, uint, uint, uint, uint, uint, void> _glDispatchComputeGroupSizeARB = null;
     #endregion
    
    internal static void Load()
    {
        _glDispatchComputeGroupSizeARB = (delegate* unmanaged<uint, uint, uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glDispatchComputeGroupSizeARB");
    }
    
    internal static void Unload()
    {
        _glDispatchComputeGroupSizeARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_compute_variable_group_size", true, false);
}
