using LunaDisc.Classes.FileMan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaDisc.UI
{
    public partial class PreferencesDialog : Form
    {
        public Classes.FileMan.Configuration config;
        public DialogResult result;
        public PreferencesDialog(Configuration conf)
        {
            InitializeComponent();
            config = conf;
        }

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {
            txtCdRomImageName.Text = config.config.defaultImageName;
            chkCdRomUseJoilet.Checked = config.config.useJoilet;

            debugEnable.Checked = config.config.debug;

            if(config.config.debug == false)
            {
                debugTab.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            updateConf();
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            updateConf();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateConf()
        {
            config.config.defaultImageName = txtCdRomImageName.Text;
            config.config.useJoilet = chkCdRomUseJoilet.Checked;
            config.config.debug = debugEnable.Checked;
            config.saveConfig();
        }
    }
}
