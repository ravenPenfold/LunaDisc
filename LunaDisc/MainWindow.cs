namespace LunaDisc
{
    public partial class MainWindow : Form
    {
        LunaDisc.Classes.File.Image image;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tsbOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                image = new Classes.File.Image(ofd.FileName, Classes.Codes.Types.TYPE_CD_DISC);
            }

            List<string> directories = image.getDirectoriesInPath("\\").strings;
            List<string> files = image.getFilesInPath("\\").strings;

            foreach (string dir in directories)
            {
                lvBrowser.Items.Add(dir).Group = lvBrowser.Groups[0];
            }

            foreach (string file in files)
            {
                lvBrowser.Items.Add(file).Group = lvBrowser.Groups[1];
            }
        }
    }
}
