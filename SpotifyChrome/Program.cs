using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpotifyChrome
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CefSharp.Settings settings = new CefSharp.Settings();
            CefSharp.Example.ExamplePresenter.Init();
            CefSharp.CEF.Initialize(settings);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
