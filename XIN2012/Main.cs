using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            fmAboutBox box = new fmAboutBox();
            box.ShowDialog();
        }
    }
}
