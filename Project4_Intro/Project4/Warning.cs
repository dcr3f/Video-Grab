﻿using System;
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
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // open next dialog
            Video vForm = new Video();
            this.Hide();
            vForm.ShowDialog();
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
