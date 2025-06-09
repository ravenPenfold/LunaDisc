

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
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup1 = new ListViewGroup("Folders", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Files", HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuStrip1 = new MenuStrip();
            tsmFile = new ToolStripMenuItem();
            tsbOpenImage = new ToolStripMenuItem();
            lvBrowser = new ListView();
            BrowserImages = new ImageList(components);
            toolStrip = new ToolStrip();
            tsbBackDirectory = new ToolStripButton();
            tstActiveDirectory = new ToolStripTextBox();
            fileContextMenu = new ContextMenuStrip(components);
            extractFileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip.SuspendLayout();
            fileContextMenu.SuspendLayout();
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
            tsbOpenImage.Size = new Size(174, 26);
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
            lvBrowser.LargeImageList = BrowserImages;
            lvBrowser.Location = new Point(0, 55);
            lvBrowser.Name = "lvBrowser";
            lvBrowser.Size = new Size(884, 588);
            lvBrowser.SmallImageList = BrowserImages;
            lvBrowser.TabIndex = 1;
            lvBrowser.UseCompatibleStateImageBehavior = false;
            lvBrowser.SelectedIndexChanged += lvBrowser_SelectedIndexChanged;
            lvBrowser.DoubleClick += lvBrowser_DoubleClick;
            lvBrowser.MouseUp += lvBrowser_Click;
            lvBrowser.Resize += lvBrowser_Resize;
            // 
            // BrowserImages
            // 
            BrowserImages.ColorDepth = ColorDepth.Depth32Bit;
            BrowserImages.ImageStream = (ImageListStreamer)resources.GetObject("BrowserImages.ImageStream");
            BrowserImages.TransparentColor = Color.Transparent;
            BrowserImages.Images.SetKeyName(0, "shell32.dll_14_4.ico");
            BrowserImages.Images.SetKeyName(1, "shell32.dll_14_1.ico");
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbBackDirectory, tstActiveDirectory });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(884, 27);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // tsbBackDirectory
            // 
            tsbBackDirectory.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBackDirectory.Image = (Image)resources.GetObject("tsbBackDirectory.Image");
            tsbBackDirectory.ImageTransparentColor = Color.Magenta;
            tsbBackDirectory.Name = "tsbBackDirectory";
            tsbBackDirectory.Size = new Size(29, 24);
            tsbBackDirectory.Text = "toolStripButton1";
            tsbBackDirectory.Click += tsbBackDirectory_Click;
            // 
            // tstActiveDirectory
            // 
            tstActiveDirectory.AutoSize = false;
            tstActiveDirectory.Name = "tstActiveDirectory";
            tstActiveDirectory.Size = new Size(100, 27);
            tstActiveDirectory.KeyPress += tstActiveDirectory_KeyPress;
            // 
            // fileContextMenu
            // 
            fileContextMenu.ImageScalingSize = new Size(20, 20);
            fileContextMenu.Items.AddRange(new ToolStripItem[] { extractFileToolStripMenuItem });
            fileContextMenu.Name = "fileContextMenu";
            fileContextMenu.Size = new Size(151, 28);
            // 
            // extractFileToolStripMenuItem
            // 
            extractFileToolStripMenuItem.Name = "extractFileToolStripMenuItem";
            extractFileToolStripMenuItem.Size = new Size(150, 24);
            extractFileToolStripMenuItem.Text = "Extract File";
            extractFileToolStripMenuItem.Click += extractFileToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 643);
            Controls.Add(lvBrowser);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            fileContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsbOpenImage;
        private ListView lvBrowser;
        private ToolStrip toolStrip;
        private ToolStripButton tsbBackDirectory;
        private ToolStripTextBox tstActiveDirectory;
        private ContextMenuStrip fileContextMenu;
        private ToolStripMenuItem extractFileToolStripMenuItem;
        private ImageList BrowserImages;
    }
}
