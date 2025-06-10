using LunaDisc.Data;
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
    public partial class RenameDialog : Form
    {
        public RenameDialog()
        {
            InitializeComponent();
        }

        public DialogResult result;
        public string name = "";
        public bool rename = false;

        private void Rename_Load(object sender, EventArgs e)
        {
            if (rename == true)
            {
                Text = Locale.dlgRenameHeader + name;
            }
            else
            {
                Text = Locale.dlgCreateDirectoryHeader;
            }
            lDesc.Text = Locale.renameDescription;
            bCancel.Text = Locale.cancelButton;
            bOk.Text = Locale.okButton;
            tName.Text = name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bOk_Click(object sender, EventArgs e)
        {
            name = tName.Text;
            result = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            Close();
        }
    }
}
