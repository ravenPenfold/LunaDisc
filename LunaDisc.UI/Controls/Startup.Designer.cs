namespace LunaDisc.UI.Controls
{
    partial class Startup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("Test 1");
            ListViewItem listViewItem2 = new ListViewItem("Test 2");
            button1 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(358, 66);
            button1.TabIndex = 0;
            button1.Text = "Create a new Disc Image";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Right;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(367, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(339, 475);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "Startup";
            Size = new Size(706, 475);
            Load += Startup_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView listView1;
    }
}
