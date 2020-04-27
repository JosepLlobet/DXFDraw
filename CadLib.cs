using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace testDXF
{
    static class NativeMethods
    {
        //[DllImport("kernel32.dll")]
        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool FreeLibrary(IntPtr hModule);
    }

    class CadLib
    {
        public static IntPtr hinstCadIO;
        public static IntPtr pProc;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr InitSystem();
        internal static IntPtr InitSystem_1()
        {
            hinstCadIO = NativeMethods.LoadLibrary(@"C:\Users\Josep\source\repos\testDXF\bin\Debug\CadIO.dll");

            if (hinstCadIO == IntPtr.Zero)
                System.Windows.Forms.MessageBox.Show(Marshal.GetLastWin32Error().ToString());

            GETPROCADDRESS("drwCreate");

            InitSystem initSystem = (InitSystem)Marshal.GetDelegateForFunctionPointer(pProc, typeof(InitSystem));

            return initSystem();
        }

        private static string GETPROCADDRESS(string procName)
        {
            if (hinstCadIO == null)
            {
                return "Error 1";
            }

            pProc = NativeMethods.GetProcAddress(hinstCadIO, procName);

            if (pProc == null)
            {
                return "Error 2";
            }

            return "";
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool drwLoadDataFromFile(IntPtr m_hDrawing, UInt32 objHandle, UInt32 dWord, byte[] i_filename, IntPtr hWnd);
        internal static bool drwLoadDataFromFile_1(IntPtr m_hDrawing, UInt32 objHandle, UInt32 dWord, byte[] i_filename, IntPtr hWnd)
        {
            GETPROCADDRESS("drwLoadDataFromFile");

            drwLoadDataFromFile initSystem = (drwLoadDataFromFile)Marshal.GetDelegateForFunctionPointer(pProc, typeof(drwLoadDataFromFile));

            return initSystem(m_hDrawing, objHandle, dWord, i_filename, hWnd);
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool drwInitView(IntPtr m_hDrawing, long x, long y, Int64 width, Int64 height);
        internal static bool drwInitView_1(IntPtr m_hDrawing, long x, long y, Int64 width, Int64 height)
        {
            GETPROCADDRESS("drwInitView");

            drwInitView initSystem = (drwInitView)Marshal.GetDelegateForFunctionPointer(pProc, typeof(drwInitView));

            return initSystem(m_hDrawing, x, y, width, height);
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool drwPaint(IntPtr m_hDrawing, IntPtr hdc);
        internal static bool drwPaint_1(IntPtr m_hDrawing, IntPtr hdc)
        {
            GETPROCADDRESS("drwPaint");

            drwPaint initSystem = (drwPaint)Marshal.GetDelegateForFunctionPointer(pProc, typeof(drwPaint));

            return initSystem(m_hDrawing, hdc);
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool drwZoomExtents(IntPtr m_hDrawing);
        internal static bool drwZoomExtents_1(IntPtr m_hDrawing)
        {
            GETPROCADDRESS("drwZoomExtents");

            drwZoomExtents initSystem = (drwZoomExtents)Marshal.GetDelegateForFunctionPointer(pProc, typeof(drwZoomExtents));

            return initSystem(m_hDrawing);
        }
    }
}
