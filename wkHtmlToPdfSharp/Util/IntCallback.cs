using System;
using System.Runtime.InteropServices;

namespace wkHtmlToPdfSharp.Util
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void IntCallback(IntPtr converter, int str);
}