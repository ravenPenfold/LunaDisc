using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDisc.Classes.FileMan
{
    public struct ConfType
    {
        // Fixed Configurations (requires manual text editing)
        public bool debug;

        // Image Defaults
        public string defaultImageName;

        // Paths
        public string lastPath;

        public ConfType()
        {
            debug = false;
            defaultImageName = "IMAGE_NAME";
            lastPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
