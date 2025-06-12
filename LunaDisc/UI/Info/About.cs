using LunaDisc.Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaDisc.UI.Info
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lGithubRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe ", Application.StartupPath + "\\LICENSE.txt");
        }

        private void About_Load(object sender, EventArgs e)
        {
            Text = Locale.aboutTitle + Locale.appTitle;
            lAboutMain.Text = Locale.appTitle;
            lDetails.Text = Locale.appVersionPrefix + Locale.appVersion;
            lLicense.Text = Locale.appTitle + Locale.appLicenseInfo;
            bOk.Text = Locale.okButton;
            lMoreInfo.Text = Locale.appVersionAdvanced +
                "\n  - Operating System: " + Environment.OSVersion.VersionString +
                "\n  - Runtime Version: .NET Core " + Environment.Version;
        }

        private void lDetails_Click(object sender, EventArgs e)
        {

        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
