using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using LunaDisc.UI.Controls;

namespace LunaDisc.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadPage(Control ctl)
        {
            TabPage page = new TabPage();
            ctl.Dock = DockStyle.Fill;
            page.Controls.Add(ctl);
            tabUI.TabPages.Add(page);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadPage(new LunaDisc.UI.Controls.Startup());
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabUI.TabPages.Remove(tabUI.SelectedTab);
        }
    }
}
