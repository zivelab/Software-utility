using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSign
{
    public partial class frmMain : Form
    {
        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hWnd1, IntPtr hWnd2, string lpsz1, string lpsz2);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        IntPtr handle;

        private const uint WM_SETTEXT = 0x000C;
        private const uint WM_GETTEXT = 0x000D;
        private const uint BM_CLICK = 0x00F5;
        private const uint WM_GETTEXTLENGTH = 0x000E;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //handle = FindWindow("#32770", "토큰 로그온");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            handle = FindWindow(null, "토큰 로그온");

            if (handle == IntPtr.Zero)
            {
                //MessageBox.Show("Could not find the window.");
                return;
            }

            IntPtr hTextBox = FindWindowEx(handle, IntPtr.Zero, "Edit", null);
            if (hTextBox == IntPtr.Zero)
            {
                //MessageBox.Show("Could not find the text box.");
                return;
            }

            hTextBox = FindWindowEx(handle, hTextBox, "Edit", null);
            if (hTextBox == IntPtr.Zero)
            {
                //MessageBox.Show("Could not find the text box.");
                return;
            }

            SendMessage(hTextBox, WM_SETTEXT, IntPtr.Zero, "Xeno4538*");

            int textLength = SendMessage(hTextBox, WM_GETTEXTLENGTH, 0, 0);

            if (textLength > 0)
            {
                //StringBuilder sb = new StringBuilder(textLength + 1);
                //SendMessage(hTextBox, WM_GETTEXT, sb.Capacity, sb);
                //string text = sb.ToString();

                IntPtr hButton = FindWindowEx(handle, IntPtr.Zero, "Button", "OK");
                if (hButton == IntPtr.Zero)
                {
                    //MessageBox.Show("Could not find the button.");
                    return;
                }

                SendMessage(hButton, BM_CLICK, IntPtr.Zero, IntPtr.Zero);
            }            
        }
    }
}
