

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
            ListViewGroup listViewGroup3 = new ListViewGroup("New Folders", HorizontalAlignment.Left);
            ListViewGroup listViewGroup4 = new ListViewGroup("New Files", HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            fileMenu = new MenuStrip();
            tsmFile = new ToolStripMenuItem();
            createADiskImageToolStripMenuItem = new ToolStripMenuItem();
            cDROMImageisoToolStripMenuItem = new ToolStripMenuItem();
            tsbOpenImage = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            saveImageAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lvBrowser = new ListView();
            BrowserImages = new ImageList(components);
            toolStrip = new ToolStrip();
            tsbBackDirectory = new ToolStripButton();
            tstActiveDirectory = new ToolStripTextBox();
            fileContextMenu = new ContextMenuStrip(components);
            extractFileToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            fcSep = new ToolStripSeparator();
            addToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            directoryToolStripMenuItem = new ToolStripMenuItem();
            renameToolStripMenuItem = new ToolStripMenuItem();
            panVolInfo = new Panel();
            panProgress = new Panel();
            pbProgress = new ProgressBar();
            lProgress = new Label();
            panVolId = new Panel();
            txtVolumeId = new TextBox();
            lVolumeId = new Label();
            lVolumeInfo = new Label();
            fileMenu.SuspendLayout();
            toolStrip.SuspendLayout();
            fileContextMenu.SuspendLayout();
            panVolInfo.SuspendLayout();
            panProgress.SuspendLayout();
            panVolId.SuspendLayout();
            SuspendLayout();
            // 
            // fileMenu
            // 
            fileMenu.ImageScalingSize = new Size(20, 20);
            fileMenu.Items.AddRange(new ToolStripItem[] { tsmFile, helpToolStripMenuItem });
            fileMenu.Location = new Point(0, 0);
            fileMenu.Name = "fileMenu";
            fileMenu.Padding = new Padding(5, 2, 0, 2);
            fileMenu.Size = new Size(906, 24);
            fileMenu.TabIndex = 0;
            fileMenu.Text = "menuStrip1";
            fileMenu.ItemClicked += fileMenu_ItemClicked;
            // 
            // tsmFile
            // 
            tsmFile.DropDownItems.AddRange(new ToolStripItem[] { createADiskImageToolStripMenuItem, tsbOpenImage, saveImageToolStripMenuItem, saveImageAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            tsmFile.Name = "tsmFile";
            tsmFile.Size = new Size(37, 20);
            tsmFile.Text = "File";
            // 
            // createADiskImageToolStripMenuItem
            // 
            createADiskImageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cDROMImageisoToolStripMenuItem });
            createADiskImageToolStripMenuItem.Image = Properties.Resources.New;
            createADiskImageToolStripMenuItem.Name = "createADiskImageToolStripMenuItem";
            createADiskImageToolStripMenuItem.Size = new Size(178, 22);
            createADiskImageToolStripMenuItem.Text = "Create a Disk Image";
            createADiskImageToolStripMenuItem.Click += createADiskImageToolStripMenuItem_Click;
            // 
            // cDROMImageisoToolStripMenuItem
            // 
            cDROMImageisoToolStripMenuItem.Name = "cDROMImageisoToolStripMenuItem";
            cDROMImageisoToolStripMenuItem.Size = new Size(187, 22);
            cDROMImageisoToolStripMenuItem.Text = "CD-ROM Image (.iso)";
            cDROMImageisoToolStripMenuItem.Click += cDROMImageisoToolStripMenuItem_Click;
            // 
            // tsbOpenImage
            // 
            tsbOpenImage.Image = Properties.Resources.Folder;
            tsbOpenImage.Name = "tsbOpenImage";
            tsbOpenImage.Size = new Size(178, 22);
            tsbOpenImage.Text = "Open Image";
            tsbOpenImage.Click += tsbOpenImage_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Image = Properties.Resources.Save;
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(178, 22);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // saveImageAsToolStripMenuItem
            // 
            saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            saveImageAsToolStripMenuItem.Size = new Size(178, 22);
            saveImageAsToolStripMenuItem.Text = "Save Image As...";
            saveImageAsToolStripMenuItem.Click += saveImageAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(178, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lvBrowser
            // 
            lvBrowser.Dock = DockStyle.Fill;
            listViewGroup1.Header = "Folders";
            listViewGroup1.Name = "gpFolder";
            listViewGroup2.Header = "Files";
            listViewGroup2.Name = "gpFiles";
            listViewGroup3.Header = "New Folders";
            listViewGroup3.Name = "gpNewFolder";
            listViewGroup4.Header = "New Files";
            listViewGroup4.Name = "gpNewFiles";
            lvBrowser.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3, listViewGroup4 });
            lvBrowser.LargeImageList = BrowserImages;
            lvBrowser.Location = new Point(267, 51);
            lvBrowser.Margin = new Padding(3, 2, 3, 2);
            lvBrowser.Name = "lvBrowser";
            lvBrowser.Size = new Size(639, 431);
            lvBrowser.SmallImageList = BrowserImages;
            lvBrowser.Sorting = SortOrder.Ascending;
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
            BrowserImages.Images.SetKeyName(0, "Folder.png");
            BrowserImages.Images.SetKeyName(1, "File.png");
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbBackDirectory, tstActiveDirectory });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(906, 27);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // tsbBackDirectory
            // 
            tsbBackDirectory.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBackDirectory.Image = Properties.Resources.Back;
            tsbBackDirectory.ImageTransparentColor = Color.Magenta;
            tsbBackDirectory.Name = "tsbBackDirectory";
            tsbBackDirectory.Size = new Size(24, 24);
            tsbBackDirectory.Text = "toolStripButton1";
            tsbBackDirectory.Click += tsbBackDirectory_Click;
            // 
            // tstActiveDirectory
            // 
            tstActiveDirectory.AutoSize = false;
            tstActiveDirectory.Name = "tstActiveDirectory";
            tstActiveDirectory.Size = new Size(88, 23);
            tstActiveDirectory.KeyPress += tstActiveDirectory_KeyPress;
            // 
            // fileContextMenu
            // 
            fileContextMenu.ImageScalingSize = new Size(20, 20);
            fileContextMenu.Items.AddRange(new ToolStripItem[] { extractFileToolStripMenuItem, deleteToolStripMenuItem, fcSep, addToolStripMenuItem, renameToolStripMenuItem });
            fileContextMenu.Name = "fileContextMenu";
            fileContextMenu.Size = new Size(131, 98);
            // 
            // extractFileToolStripMenuItem
            // 
            extractFileToolStripMenuItem.Name = "extractFileToolStripMenuItem";
            extractFileToolStripMenuItem.Size = new Size(130, 22);
            extractFileToolStripMenuItem.Text = "Extract File";
            extractFileToolStripMenuItem.Click += extractFileToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(130, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // fcSep
            // 
            fcSep.Name = "fcSep";
            fcSep.Size = new Size(127, 6);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem, directoryToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(130, 22);
            addToolStripMenuItem.Text = "Add... ";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(122, 22);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // directoryToolStripMenuItem
            // 
            directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            directoryToolStripMenuItem.Size = new Size(122, 22);
            directoryToolStripMenuItem.Text = "Directory";
            directoryToolStripMenuItem.Click += directoryToolStripMenuItem_Click;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(130, 22);
            renameToolStripMenuItem.Text = "Rename";
            // 
            // panVolInfo
            // 
            panVolInfo.Controls.Add(panProgress);
            panVolInfo.Controls.Add(panVolId);
            panVolInfo.Controls.Add(lVolumeInfo);
            panVolInfo.Dock = DockStyle.Left;
            panVolInfo.Location = new Point(0, 51);
            panVolInfo.Margin = new Padding(3, 2, 3, 2);
            panVolInfo.Name = "panVolInfo";
            panVolInfo.Size = new Size(267, 431);
            panVolInfo.TabIndex = 3;
            // 
            // panProgress
            // 
            panProgress.Controls.Add(pbProgress);
            panProgress.Controls.Add(lProgress);
            panProgress.Dock = DockStyle.Bottom;
            panProgress.Location = new Point(0, 375);
            panProgress.Margin = new Padding(3, 2, 3, 2);
            panProgress.Name = "panProgress";
            panProgress.Size = new Size(267, 56);
            panProgress.TabIndex = 6;
            panProgress.Visible = false;
            // 
            // pbProgress
            // 
            pbProgress.Location = new Point(10, 24);
            pbProgress.Margin = new Padding(3, 2, 3, 2);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(251, 22);
            pbProgress.TabIndex = 1;
            // 
            // lProgress
            // 
            lProgress.AutoSize = true;
            lProgress.Location = new Point(10, 7);
            lProgress.Name = "lProgress";
            lProgress.Size = new Size(38, 15);
            lProgress.TabIndex = 0;
            lProgress.Text = "label1";
            // 
            // panVolId
            // 
            panVolId.Controls.Add(txtVolumeId);
            panVolId.Controls.Add(lVolumeId);
            panVolId.Dock = DockStyle.Top;
            panVolId.Location = new Point(0, 25);
            panVolId.Margin = new Padding(3, 2, 3, 2);
            panVolId.Name = "panVolId";
            panVolId.Size = new Size(267, 31);
            panVolId.TabIndex = 5;
            panVolId.Visible = false;
            // 
            // txtVolumeId
            // 
            txtVolumeId.Location = new Point(85, 4);
            txtVolumeId.Margin = new Padding(3, 2, 3, 2);
            txtVolumeId.Name = "txtVolumeId";
            txtVolumeId.Size = new Size(177, 23);
            txtVolumeId.TabIndex = 1;
            // 
            // lVolumeId
            // 
            lVolumeId.AutoSize = true;
            lVolumeId.Location = new Point(10, 7);
            lVolumeId.Name = "lVolumeId";
            lVolumeId.Size = new Size(60, 15);
            lVolumeId.TabIndex = 0;
            lVolumeId.Text = "lVolumeId";
            // 
            // lVolumeInfo
            // 
            lVolumeInfo.AutoSize = true;
            lVolumeInfo.Dock = DockStyle.Top;
            lVolumeInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lVolumeInfo.Location = new Point(0, 0);
            lVolumeInfo.Name = "lVolumeInfo";
            lVolumeInfo.Size = new Size(83, 25);
            lVolumeInfo.TabIndex = 4;
            lVolumeInfo.Text = "lVolInfo";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 482);
            Controls.Add(lvBrowser);
            Controls.Add(panVolInfo);
            Controls.Add(toolStrip);
            Controls.Add(fileMenu);
            MainMenuStrip = fileMenu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            Text = "Form1";
            FormClosed += MainWindow_FormClosed;
            Load += MainWindow_Load;
            fileMenu.ResumeLayout(false);
            fileMenu.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            fileContextMenu.ResumeLayout(false);
            panVolInfo.ResumeLayout(false);
            panVolInfo.PerformLayout();
            panProgress.ResumeLayout(false);
            panProgress.PerformLayout();
            panVolId.ResumeLayout(false);
            panVolId.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip fileMenu;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsbOpenImage;
        private ListView lvBrowser;
        private ToolStrip toolStrip;
        private ToolStripButton tsbBackDirectory;
        private ToolStripTextBox tstActiveDirectory;
        private ContextMenuStrip fileContextMenu;
        private ImageList BrowserImages;
        private Panel panVolInfo;
        private Panel panVolId;
        private TextBox txtVolumeId;
        private Label lVolumeId;
        private Label lVolumeInfo;
        private Panel panProgress;
        private ProgressBar pbProgress;
        private Label lProgress;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem createADiskImageToolStripMenuItem;
        private ToolStripMenuItem cDROMImageisoToolStripMenuItem;
        private ToolStripMenuItem saveImageAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem extractFileToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator fcSep;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem directoryToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
    }
}
