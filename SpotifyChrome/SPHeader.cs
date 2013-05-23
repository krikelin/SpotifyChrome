using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpotifyChrome
{
    public partial class SPHeader : UserControl
    {
        public SPHeader()
        {
            InitializeComponent();
        }

        private void SPHeader_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 44, 45);
            this.Height = 48;
            this.Dock = DockStyle.Top;
        }
        public void Draw(Graphics g)
        {

        }
    }
}
