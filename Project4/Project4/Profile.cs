using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Profile : Form
    {
        public static string name;
        public Profile()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            if (age >= 18)
            {
                // open next dialog
                Video vForm = new Video();
                this.Hide();
                vForm.ShowDialog();
                this.Close();
            }
            else
            {
                // restrict access to video player
                // MessageBox.Show("May contain inappropriate content not suitable for younger audiences.");
                // open next dialog
                Warning wForm = new Warning();
                this.Hide();
                wForm.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
