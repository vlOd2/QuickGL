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

namespace QuickGL;

/// <summary>
/// Provides utility methods for working with pointers to data in stack-allocated spans
/// </summary>
public unsafe class PtrHelper
{
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
