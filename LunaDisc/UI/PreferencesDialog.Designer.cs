namespace LunaDisc.UI
{
    partial class PreferencesDialog
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnOk = new Button();
            tabs = new TabControl();
            debugTab = new TabPage();
            debugEnable = new CheckBox();
            label1 = new Label();
            tabCDROMEdit = new TabPage();
            grpDefaultProperties = new GroupBox();
            chkCdRomUseJoilet = new CheckBox();
            txtCdRomImageName = new TextBox();
            lbImageName = new Label();
            panel1.SuspendLayout();
            tabs.SuspendLayout();
            debugTab.SuspendLayout();
            tabCDROMEdit.SuspendLayout();
            grpDefaultProperties.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOk);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 30);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(12, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(347, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(106, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Apply and Close";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tabs
            // 
            tabs.Controls.Add(debugTab);
            tabs.Controls.Add(tabCDROMEdit);
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point(0, 0);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(465, 420);
            tabs.TabIndex = 1;
            tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
            // 
            // debugTab
            // 
            debugTab.Controls.Add(debugEnable);
            debugTab.Controls.Add(label1);
            debugTab.Location = new Point(4, 24);
            debugTab.Name = "debugTab";
            debugTab.Size = new Size(457, 392);
            debugTab.TabIndex = 1;
            debugTab.Text = "DEBUG";
            debugTab.UseVisualStyleBackColor = true;
            // 
            // debugEnable
            // 
            debugEnable.AutoSize = true;
            debugEnable.Location = new Point(8, 370);
            debugEnable.Name = "debugEnable";
            debugEnable.Size = new Size(354, 19);
            debugEnable.TabIndex = 1;
            debugEnable.Text = "Debug Enabled? (Requires LunaDisc to restart before applying)";
            debugEnable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(435, 30);
            label1.TabIndex = 0;
            label1.Text = "WARNING: These settings are experimental and should not be used in day-to-day\r\nuse.";
            // 
            // tabCDROMEdit
            // 
            tabCDROMEdit.Controls.Add(grpDefaultProperties);
            tabCDROMEdit.Location = new Point(4, 24);
            tabCDROMEdit.Name = "tabCDROMEdit";
            tabCDROMEdit.Padding = new Padding(3);
            tabCDROMEdit.Size = new Size(457, 392);
            tabCDROMEdit.TabIndex = 0;
            tabCDROMEdit.Text = "CD-ROM Image Editing";
            tabCDROMEdit.UseVisualStyleBackColor = true;
            // 
            // grpDefaultProperties
            // 
            grpDefaultProperties.Controls.Add(chkCdRomUseJoilet);
            grpDefaultProperties.Controls.Add(txtCdRomImageName);
            grpDefaultProperties.Controls.Add(lbImageName);
            grpDefaultProperties.Location = new Point(6, 6);
            grpDefaultProperties.Name = "grpDefaultProperties";
            grpDefaultProperties.Size = new Size(443, 75);
            grpDefaultProperties.TabIndex = 0;
            grpDefaultProperties.TabStop = false;
            grpDefaultProperties.Text = "Default Image Properties";
            // 
            // chkCdRomUseJoilet
            // 
            chkCdRomUseJoilet.AutoSize = true;
            chkCdRomUseJoilet.Checked = true;
            chkCdRomUseJoilet.CheckState = CheckState.Checked;
            chkCdRomUseJoilet.Location = new Point(6, 45);
            chkCdRomUseJoilet.Name = "chkCdRomUseJoilet";
            chkCdRomUseJoilet.RightToLeft = RightToLeft.Yes;
            chkCdRomUseJoilet.Size = new Size(132, 19);
            chkCdRomUseJoilet.TabIndex = 2;
            chkCdRomUseJoilet.Text = "Use Joilet by Default";
            chkCdRomUseJoilet.UseVisualStyleBackColor = true;
            // 
            // txtCdRomImageName
            // 
            txtCdRomImageName.Location = new Point(131, 16);
            txtCdRomImageName.Name = "txtCdRomImageName";
            txtCdRomImageName.Size = new Size(306, 23);
            txtCdRomImageName.TabIndex = 1;
            // 
            // lbImageName
            // 
            lbImageName.AutoSize = true;
            lbImageName.Location = new Point(6, 19);
            lbImageName.Name = "lbImageName";
            lbImageName.Size = new Size(119, 15);
            lbImageName.TabIndex = 0;
            lbImageName.Text = "Default Image Name:";
            // 
            // PreferencesDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(tabs);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PreferencesDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PreferencesDialog";
            Load += PreferencesDialog_Load;
            panel1.ResumeLayout(false);
            tabs.ResumeLayout(false);
            debugTab.ResumeLayout(false);
            debugTab.PerformLayout();
            tabCDROMEdit.ResumeLayout(false);
            grpDefaultProperties.ResumeLayout(false);
            grpDefaultProperties.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnOk;
        private TabControl tabs;
        private TabPage tabCDROMEdit;
        private GroupBox grpDefaultProperties;
        private TextBox txtCdRomImageName;
        private Label lbImageName;
        private CheckBox chkCdRomUseJoilet;
        private TabPage debugTab;
        private CheckBox debugEnable;
        private Label label1;
    }
}