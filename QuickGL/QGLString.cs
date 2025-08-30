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

using System.Runtime.InteropServices;
using System.Text;

namespace QuickGLNS;

/// <summary>
/// Convenience class to allow for easy interop with native ASCII strings
/// </summary>
public unsafe class QGLString : IDisposable
{
    private static List<QGLString> pool = [];
    private nint data;
    private bool notOwned;
    public int Length { get; private set; }
    /// <summary>
    /// Reads a managed string from the pointer
    /// </summary>
    public string Data => Marshal.PtrToStringAnsi(data);
    /// <summary>
    /// The pointer behind this string
    /// </summary>
    public byte* RawData => (byte*)data;

    /// <summary>
    /// Imports a native null terminated string
    /// </summary>
    /// <param name="data">the native string</param>
    public QGLString(byte* data)
    {
        ArgumentNullException.ThrowIfNull(data, nameof(data));
        this.data = (nint)data;
        int idx = 0;
        while (data[idx++] != 0x00) ;
        Length = idx - 1;
        notOwned = true;
    }

    /// <summary>
    /// Allocates a native string from the given managed string
    /// </summary>
    /// <param name="data">the managed string to allocate from</param>
    public QGLString(string data)
    {
        ArgumentNullException.ThrowIfNull(data, nameof(data));
        this.data = Marshal.StringToHGlobalAnsi(data);
        Length = Encoding.ASCII.GetByteCount(data);
    }

    /// <summary>
    /// Allocates a native string with the given size
    /// </summary>
    /// <param name="size">the size of the string</param>
    public QGLString(int size)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(size, 0, nameof(size));
        data = Marshal.AllocHGlobal(size);
        Length = size;
    }

    ~QGLString()
    {
        Dispose(false);
    }

    /// <summary>
    /// Creates an instance that will not be automatically freed designed for persistent read-only usage<br/>
    /// Make sure to clean up all instances by calling <see cref="ClearPool"/>
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static QGLString CreatePool(string str)
    {
        QGLString instance = new(str) { notOwned = true };
        pool.Add(instance);
        return instance;
    }

    /// <summary>
    /// Cleans up all pooled instances
    /// </summary>
    public static void ClearPool()
    {
        foreach (QGLString instance in pool)
        {
            instance.notOwned = false;
            instance.Dispose();
        }
        pool.Clear();
    }

    public static implicit operator byte*(QGLString str) => str.RawData;

    public static implicit operator string(QGLString str) => str.Data;

    public static implicit operator QGLString(byte* data) => new(data);

    public static implicit operator QGLString(string data) => new(data);

    public override int GetHashCode() => Data.GetHashCode();

    public override string ToString() => Data;

    protected virtual void Dispose(bool disposing)
    {
        if (notOwned || data == nint.Zero)
            return;
        Marshal.FreeHGlobal(data);
        data = nint.Zero;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}