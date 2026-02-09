using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Characters
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            frmCredits v = new frmCredits();
            v.Show();
            v.Text = "Credits"; // change window title

        }

        private void btnCharacters_Click(object sender, EventArgs e)
        {
            frmCharacters p = new frmCharacters();
            p.Show();

        }
    }
}
