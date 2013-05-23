using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SpotifyChrome
{
    public partial class SPFooter : UserControl
    {
        public static int HTBOTTOMRIGHT = 17;
        public static uint WM_NCLBUTTONDOWN = 0x00A1;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern IntPtr SendMessage(
             IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        public SPFooter()
        {
            InitializeComponent();
        }

        private void SPHeader_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 44, 45);
            this.Height = 18;
            this.Dock = DockStyle.Top;
        }
        public void Draw(Graphics g)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        ReleaseCapture();
        SendMessage(this.ParentForm.Handle, WM_NCLBUTTONDOWN, HTBOTTOMRIGHT, 0);

        }
    }
}
