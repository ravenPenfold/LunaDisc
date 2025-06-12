namespace LunaDisc.UI.Info
{
    partial class About
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
            lAboutMain = new Label();
            lDetails = new Label();
            bOk = new Button();
            lLicense = new LinkLabel();
            pictureBox1 = new PictureBox();
            lMoreInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lAboutMain
            // 
            lAboutMain.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lAboutMain.ForeColor = Color.OrangeRed;
            lAboutMain.Location = new Point(72, 12);
            lAboutMain.Name = "lAboutMain";
            lAboutMain.Size = new Size(288, 47);
            lAboutMain.TabIndex = 0;
            lAboutMain.Text = "LunaDisc";
            // 
            // lDetails
            // 
            lDetails.AutoSize = true;
            lDetails.Location = new Point(77, 59);
            lDetails.Name = "lDetails";
            lDetails.Size = new Size(38, 15);
            lDetails.TabIndex = 1;
            lDetails.Text = "label1";
            lDetails.Click += lDetails_Click;
            // 
            // bOk
            // 
            bOk.Location = new Point(286, 124);
            bOk.Name = "bOk";
            bOk.Size = new Size(75, 23);
            bOk.TabIndex = 3;
            bOk.Text = "button1";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // lLicense
            // 
            lLicense.AutoSize = true;
            lLicense.Location = new Point(12, 128);
            lLicense.Name = "lLicense";
            lLicense.Size = new Size(60, 15);
            lLicense.TabIndex = 4;
            lLicense.TabStop = true;
            lLicense.Text = "linkLabel1";
            lLicense.LinkClicked += lLicense_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lMoreInfo
            // 
            lMoreInfo.AutoSize = true;
            lMoreInfo.Location = new Point(12, 79);
            lMoreInfo.Name = "lMoreInfo";
            lMoreInfo.Size = new Size(38, 45);
            lMoreInfo.TabIndex = 6;
            lMoreInfo.Text = "label1\r\nline 2\r\nline 3";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 153);
            Controls.Add(lMoreInfo);
            Controls.Add(pictureBox1);
            Controls.Add(lLicense);
            Controls.Add(bOk);
            Controls.Add(lDetails);
            Controls.Add(lAboutMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lAboutMain;
        private Label lDetails;
        private Button bOk;
        private LinkLabel lLicense;
        private PictureBox pictureBox1;
        private Label lMoreInfo;
    }
}