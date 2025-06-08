
namespace LunaDisc
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewGroup listViewGroup1 = new ListViewGroup("Folders", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Files", HorizontalAlignment.Left);
            menuStrip1 = new MenuStrip();
            tsmFile = new ToolStripMenuItem();
            tsbOpenImage = new ToolStripMenuItem();
            lvBrowser = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            tsmFile.DropDownItems.AddRange(new ToolStripItem[] { tsbOpenImage });
            tsmFile.Name = "tsmFile";
            tsmFile.Size = new Size(46, 24);
            tsmFile.Text = "File";
            // 
            // tsbOpenImage
            // 
            tsbOpenImage.Name = "tsbOpenImage";
            tsbOpenImage.Size = new Size(224, 26);
            tsbOpenImage.Text = "Open Image";
            tsbOpenImage.Click += tsbOpenImage_Click;
            // 
            // lvBrowser
            // 
            lvBrowser.Dock = DockStyle.Fill;
            listViewGroup1.Header = "Folders";
            listViewGroup1.Name = "gpFolder";
            listViewGroup2.Header = "Files";
            listViewGroup2.Name = "gpFiles";
            lvBrowser.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            lvBrowser.Location = new Point(0, 28);
            lvBrowser.Name = "lvBrowser";
            lvBrowser.Size = new Size(884, 615);
            lvBrowser.TabIndex = 1;
            lvBrowser.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 643);
            Controls.Add(lvBrowser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsbOpenImage;
        private ListView lvBrowser;
    }
}
