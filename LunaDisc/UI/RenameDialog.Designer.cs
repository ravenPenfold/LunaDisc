namespace LunaDisc.UI
{
    partial class RenameDialog
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
            bOk = new Button();
            tName = new TextBox();
            lDesc = new Label();
            bCancel = new Button();
            SuspendLayout();
            // 
            // bOk
            // 
            bOk.DialogResult = DialogResult.OK;
            bOk.Location = new Point(343, 56);
            bOk.Name = "bOk";
            bOk.Size = new Size(75, 23);
            bOk.TabIndex = 0;
            bOk.Text = "button1";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // tName
            // 
            tName.Location = new Point(12, 27);
            tName.Name = "tName";
            tName.Size = new Size(406, 23);
            tName.TabIndex = 1;
            tName.TextChanged += textBox1_TextChanged;
            // 
            // lDesc
            // 
            lDesc.AutoSize = true;
            lDesc.Location = new Point(12, 9);
            lDesc.Name = "lDesc";
            lDesc.Size = new Size(38, 15);
            lDesc.TabIndex = 2;
            lDesc.Text = "label1";
            // 
            // bCancel
            // 
            bCancel.DialogResult = DialogResult.Cancel;
            bCancel.Location = new Point(262, 56);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 3;
            bCancel.Text = "button2";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // RenameDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 85);
            Controls.Add(bCancel);
            Controls.Add(lDesc);
            Controls.Add(tName);
            Controls.Add(bOk);
            Name = "RenameDialog";
            Text = "Rename";
            Load += Rename_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bOk;
        private TextBox tName;
        private Label lDesc;
        private Button bCancel;
    }
}