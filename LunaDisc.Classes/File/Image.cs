using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscUtils;
using DiscUtils.Iso9660;
using LunaDisc.Classes.Codes;

namespace LunaDisc.Classes.File
{
    public class Image
    {
        // Initialize Global Variables
        public Types fType;

        // Initialize CD Variables
        CDReader cdReader;
        CDBuilder cdBuilder;

        // Initaliser
        public Image(string fileName, Types type)
        {
            switch (type)
            {
                case Types.TYPE_CD_DISC:
                    cdReader = new CDReader(new FileStream(fileName, FileMode.Open), true);
                    break;

            }
            fType = type;
        }

        public ErrorCodes loadDirectory(string path)
        {
            return ErrorCodes.NoError;
        }
    }
}
