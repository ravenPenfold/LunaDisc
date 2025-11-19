using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LunaDisc.UI.Controls
{
    public partial class Startup : UserControl
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.ParentForm.Text = this.Parent.Name + " was removed";
            this.Parent.Controls.Clear();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            this.Parent.Text = "Start Page";
            listView1.View = View.List;
        }
    }
}
