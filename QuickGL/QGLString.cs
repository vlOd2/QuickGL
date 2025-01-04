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

namespace QuickGLNS
{
    /// <summary>
    /// Convenience class to allow for easy interop with native strings
    /// </summary>
    public unsafe class QGLString : IDisposable
    {
        private bool noDispose;
        private nint data;
        public int Length { get; private set; }
        public string Data => Marshal.PtrToStringAnsi(data);
        public char* RawData => (char*)data;

        /// <summary>
        /// Imports a native null terminated ASCII string
        /// </summary>
        /// <param name="data">the native string</param>
        public QGLString(char* data)
        {
            this.data = (nint)data;
            int idx = 0;
            while (data[idx++] != 0x00)
                ;
            Length = idx;
            noDispose = true;
        }

        /// <summary>
        /// Allocates a native string from the given managed string
        /// </summary>
        /// <param name="data">the managed string to allocate from</param>
        public QGLString(string data)
        {
            this.data = Marshal.StringToHGlobalAnsi(data);
            Length = data.Length + 1;
        }

        /// <summary>
        /// Allocates a native string with the given size
        /// </summary>
        /// <param name="size">the size of the string</param>
        public QGLString(int size)
        {
            data = Marshal.AllocHGlobal(size);
            Length = size;
        }

        public static implicit operator char*(QGLString str) => str.RawData;

        public static implicit operator string(QGLString str) => str.Data;

        public static implicit operator QGLString(char* data) => new QGLString(data);

        public static implicit operator QGLString(string data) => new QGLString(data);

        /// <summary>
        /// Frees the native string<br/>
        /// NOTE: This does nothing on native strings interpreted as managed strings
        /// </summary>
        public void Dispose()
        {
            if (noDispose) return;
            Marshal.FreeHGlobal(data);
        }
    }
}