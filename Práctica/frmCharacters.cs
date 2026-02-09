using System;
using System.Windows.Forms;

namespace Characters
{
    public partial class frmCharacters : Form
    {
        public frmCharacters()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            switch (cmbCharacter.Text)
            {
                case "Car":
                    {
                        picImage.Image = Properties.Resources.auto;
                        break;
                    }
                case "Phone":
                    {
                        picImage.Image = Properties.Resources.telefono;
                        break;
                    }
                case "Computer":
                    {
                        picImage.Image = Properties.Resources.computadora;
                        break;
                    }
                case "Plant":
                    {
                        picImage.Image = Properties.Resources.planta;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Please select a character from the list.");
                        break;
                    }
            }
        }
    }
}
