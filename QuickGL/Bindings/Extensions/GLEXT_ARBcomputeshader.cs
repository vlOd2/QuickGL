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

// Bindings generated at 2025-09-20 18:58:19.836563
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBcomputeshader
{
    #region Enums
    public const int GL_COMPUTE_SHADER = 0x91B9;
    public const int GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
    public const int GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
    public const int GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
    public const int GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
    public const int GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
    public const int GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
    public const int GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
    public const int GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
    public const int GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
    public const int GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
    public const int GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
    public const int GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
    public const int GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
    public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
    public const int GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
    public const int GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
    public const int GL_COMPUTE_SHADER_BIT = 0x20;
    #endregion
    
    #region Commands
    public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) { QGLFeature.VerifyFunc((nint)_glDispatchCompute); _glDispatchCompute(num_groups_x, num_groups_y, num_groups_z); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glDispatchCompute = null;
    
    public static void glDispatchComputeIndirect(nint indirect) { QGLFeature.VerifyFunc((nint)_glDispatchComputeIndirect); _glDispatchComputeIndirect(indirect); }
    internal static delegate* unmanaged<nint, void> _glDispatchComputeIndirect = null;
     #endregion
    
    internal static void Load()
    {
        _glDispatchCompute = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glDispatchCompute");
        _glDispatchComputeIndirect = (delegate* unmanaged<nint, void>)QuickGL.GetGLProcAddress("glDispatchComputeIndirect");
    }
    
    internal static void Unload()
    {
        _glDispatchCompute = null;
        _glDispatchComputeIndirect = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_compute_shader", true, false);
}
