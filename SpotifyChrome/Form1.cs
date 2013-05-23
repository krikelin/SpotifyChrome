using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpotifyChrome
{

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Define the CS_DROPSHADOW constant
private const int CS_DROPSHADOW = 0x00020000;

// Override the CreateParams property
protected override CreateParams CreateParams
{
    get
    {
        CreateParams cp = base.CreateParams;
        cp.ClassStyle |= CS_DROPSHADOW;
        return cp;
    }
}
protected override void OnLoad(EventArgs e)
{
    base.OnLoad(e);
    System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
    this.MaximizedBounds = Screen.GetWorkingArea(this);
}
        public Form1()
        {
            InitializeComponent();
        }
        CefSharp.WinForms.WebView webView;
        private void Form1_Load(object sender, EventArgs e)
        {
            webView = new CefSharp.WinForms.WebView("http://play.spotify.com", new CefSharp.BrowserSettings());
            this.Controls.Add(webView);
            webView.Dock = DockStyle.Fill;
            webView.Address = "http://play.spotify.com";
            SPHeader p = new SPHeader();
            this.Controls.Add(p);
            p.Dock = DockStyle.Top;
         
            p.MouseMove += p_MouseMove;
            p.MouseDoubleClick += p_MouseDoubleClick;

            SPFooter footer = new SPFooter();
            this.Controls.Add(footer);
            footer.Dock = DockStyle.Bottom;
           
        }

        void p_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
            }
        }

        void p_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 6);
            }
        }

       
    }
}
