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
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void Video_Load(object sender, EventArgs e)
        {
            lblName.Text = Profile.name + "'s Video Player";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
