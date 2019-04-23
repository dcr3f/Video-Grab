using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Project5
{
    public partial class ShufflePlayer : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private static Random rng = new Random();
        static public string playItem;


        public ShufflePlayer()
        {
            InitializeComponent();
        }

        //I referenced the Fisher–Yates shuffle to implement this function
        private void Shuffle(ListBox.ObjectCollection list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fbd.ShowDialog();
            try
            {
                loadList();
            }
            catch
            {
                StatusMsg.Text = "Something went wrong durring folder selection...";
            }
           
        }

        private void folderName_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadList()
        {
            try
            {
                folderName.Text = fbd.SelectedPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                foreach (string fileName in files)
                    videoListBox.Items.Add(fileName.Replace(fbd.SelectedPath, ""));
                StatusMsg.Text = "Videos loaded: Unshuffled.";
            }
            catch { StatusMsg.Text = "Something went wrong when trying to get files: Check your folder's contents."; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Shuffle(videoListBox.Items);
                StatusMsg.Text = "Shuffling done.";
            }
            catch
            { StatusMsg.Text = "Error on shuffle."; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                playItem = fbd.SelectedPath + videoListBox.SelectedItem.ToString();
                Video vForm = new Video();
                vForm.Owner = this;
                this.Hide();
                vForm.ShowDialog();

            }
            catch 
            {
                StatusMsg.Text = "Invalid file selection.";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            videoListBox.Items.Clear();
            StatusMsg.Text = "List reset.";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
          
            int count = videoListBox.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                videoListBox.Items.Remove(videoListBox.SelectedItems[0]);
               
            }
            StatusMsg.Text = "Items removed.";
        }
    }
}
