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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public string VideoPath { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = VideoPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            openFileDialog1.Title = "Open Video File";
            openFileDialog1.DefaultExt = "mp4";
            openFileDialog1.Filter = "video files (*.mp4)|*.mp4|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                VideoPath = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = VideoPath;
                // TODO – Open next Form here
            }
           
        }
    }
}
