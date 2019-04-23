using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class Video : Form
    {

        public Video()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            lblName.Text = Profile.name + "'s Video Player";

        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            try { axWindowsMediaPlayer1.Ctlcontrols.stop(); }
            catch { }
            this.Owner.Show();
            
        }

        public string VideoPath { get; set; }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ShufflePlayer.playItem;
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
                ShufflePlayer.playItem = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = ShufflePlayer.playItem;
                // TODO – Open next Form here
            }
           
        }

        internal void ShowDialogue()
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
