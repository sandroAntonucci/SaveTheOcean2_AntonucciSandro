using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheOcean.DTOs;

namespace SaveTheOcean
{
    public partial class Form2 : Form
    {

        const int One = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {

            if(txtCharName.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtCharName, "Please enter a name for your character.");
            }

            else if(cmbRole.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbRole, "Please select a role for your character.");
            }
            else
            {
                FormGame formGame = new FormGame(new Player(txtCharName.Text, cmbRole.SelectedIndex+One));
                this.Hide();
                formGame.ShowDialog();
            }

        }
    }
}
