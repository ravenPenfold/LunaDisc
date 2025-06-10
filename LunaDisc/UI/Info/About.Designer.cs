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
            lGithubRepo = new LinkLabel();
            bOk = new Button();
            lLicense = new LinkLabel();
            SuspendLayout();
            // 
            // lAboutMain
            // 
            lAboutMain.AutoSize = true;
            lAboutMain.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lAboutMain.Location = new Point(12, 9);
            lAboutMain.Name = "lAboutMain";
            lAboutMain.Size = new Size(67, 25);
            lAboutMain.TabIndex = 0;
            lAboutMain.Text = "label1";
            // 
            // lDetails
            // 
            lDetails.AutoSize = true;
            lDetails.Location = new Point(12, 34);
            lDetails.Name = "lDetails";
            lDetails.Size = new Size(38, 15);
            lDetails.TabIndex = 1;
            lDetails.Text = "label1";
            // 
            // lGithubRepo
            // 
            lGithubRepo.AutoSize = true;
            lGithubRepo.Location = new Point(12, 332);
            lGithubRepo.Name = "lGithubRepo";
            lGithubRepo.Size = new Size(60, 15);
            lGithubRepo.TabIndex = 2;
            lGithubRepo.TabStop = true;
            lGithubRepo.Text = "linkLabel1";
            lGithubRepo.LinkClicked += lGithubRepo_LinkClicked;
            // 
            // bOk
            // 
            bOk.Location = new Point(286, 328);
            bOk.Name = "bOk";
            bOk.Size = new Size(75, 23);
            bOk.TabIndex = 3;
            bOk.Text = "button1";
            bOk.UseVisualStyleBackColor = true;
            // 
            // lLicense
            // 
            lLicense.AutoSize = true;
            lLicense.Location = new Point(12, 317);
            lLicense.Name = "lLicense";
            lLicense.Size = new Size(60, 15);
            lLicense.TabIndex = 4;
            lLicense.TabStop = true;
            lLicense.Text = "linkLabel1";
            lLicense.LinkClicked += lLicense_LinkClicked;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 356);
            Controls.Add(lLicense);
            Controls.Add(bOk);
            Controls.Add(lGithubRepo);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lAboutMain;
        private Label lDetails;
        private LinkLabel lGithubRepo;
        private Button bOk;
        private LinkLabel lLicense;
    }
}