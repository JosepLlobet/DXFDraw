using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace testDXF
{
    public partial class Form1 : Form
    {
        IntPtr _m_hDrawing;
        private bool _flag = false;

        public Form1()
        {
            InitializeComponent();

            _m_hDrawing = CadLib.InitSystem_1();

            bool aux = CadLib.drwLoadDataFromFile_1(_m_hDrawing, 0, 0,
                            GetBytesFromStringWithZero(Encoding.Default, @"C:\Users\Josep\Desktop\sample.dxf"), IntPtr.Zero);            

            aux = CadLib.drwInitView_1(_m_hDrawing, 0, 0, (Int64)m_panel.Width, (Int64)m_panel.Height);
            aux = CadLib.drwZoomExtents_1(_m_hDrawing);
            _flag = true;
            m_panel.Refresh();
        }

        private byte[] GetBytesFromStringWithZero(Encoding encoding, string str)
        {
            int len = encoding.GetByteCount(str);

            byte[] bytes = new byte[len + encoding.GetByteCount("\0")];
            encoding.GetBytes(str, 0, str.Length, bytes, 0);
            return bytes;
        }

        private void m_panel_Paint(object sender, PaintEventArgs e)
        {
            if (_flag)
            {
                IntPtr hdc = e.Graphics.GetHdc();
                bool aux = CadLib.drwPaint_1(_m_hDrawing, hdc);
                e.Graphics.ReleaseHdc(hdc);
            }            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //bool aux = CadLib.drwZoomExtents_1(_m_hDrawing);
            m_panel.Refresh();
        }
    }
}
