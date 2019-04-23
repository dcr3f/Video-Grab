namespace Project5
{
    partial class ShufflePlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShufflePlayer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adamBWilsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.videoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shuffleListBox = new System.Windows.Forms.ListBox();
            this.StatusMsg = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.selectFolderToolStripMenuItem.Text = "Select Path";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adamBWilsonToolStripMenuItem});
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // adamBWilsonToolStripMenuItem
            // 
            this.adamBWilsonToolStripMenuItem.Name = "adamBWilsonToolStripMenuItem";
            this.adamBWilsonToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.adamBWilsonToolStripMenuItem.Text = "Adam B. Wilson";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Shuffle Videos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoListBox
            // 
            this.videoListBox.FormattingEnabled = true;
            this.videoListBox.Location = new System.Drawing.Point(13, 90);
            this.videoListBox.Name = "videoListBox";
            this.videoListBox.ScrollAlwaysVisible = true;
            this.videoListBox.Size = new System.Drawing.Size(982, 446);
            this.videoListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status: ";
            // 
            // folderName
            // 
            this.folderName.Location = new System.Drawing.Point(50, 31);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(736, 20);
            this.folderName.TabIndex = 5;
            this.folderName.TextChanged += new System.EventHandler(this.folderName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Folder";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // shuffleListBox
            // 
            this.shuffleListBox.FormattingEnabled = true;
            this.shuffleListBox.Location = new System.Drawing.Point(985, 27);
            this.shuffleListBox.Name = "shuffleListBox";
            this.shuffleListBox.Size = new System.Drawing.Size(10, 4);
            this.shuffleListBox.TabIndex = 2;
            this.shuffleListBox.Visible = false;
            // 
            // StatusMsg
            // 
            this.StatusMsg.AutoSize = true;
            this.StatusMsg.Location = new System.Drawing.Point(61, 59);
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(124, 13);
            this.StatusMsg.TabIndex = 7;
            this.StatusMsg.Text = "Select folder to view files";
            this.StatusMsg.Click += new System.EventHandler(this.label3_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(911, 59);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(84, 25);
            this.openBtn.TabIndex = 8;
            this.openBtn.Text = "Open File(s)";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(824, 59);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(81, 25);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear List";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(704, 59);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(114, 25);
            this.removeBtn.TabIndex = 10;
            this.removeBtn.Text = "Remove Selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // ShufflePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1007, 581);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.StatusMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoListBox);
            this.Controls.Add(this.shuffleListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShufflePlayer";
            this.Text = "Shuffle Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox videoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox shuffleListBox;
        private System.Windows.Forms.Label StatusMsg;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adamBWilsonToolStripMenuItem;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button removeBtn;
    }
}

