using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DiscUtils;
using DiscUtils.Iso9660;
using LunaDisc.Classes.Codes;
using LunaDisc.Classes.ImageTypes;
using static LunaDisc.Classes.FileMan.DiscImage;

namespace LunaDisc.Classes.FileMan
{
    public class DiscImage
    {
        // Initialize Global Variables
        public Types fType;
        public string path;

        private string actualPath;

        // for Returning
        public struct Returner
        {
            public List<string> strings;
            public ErrorCodes errorCode;

            public Returner()
            {
                strings = new List<string>();
                errorCode = new ErrorCodes();
            }
        }

        // Initaliser
        public DiscImage(string fileName, Types type)
        {
            actualPath = fileName;            
            path = "\\";
            fType = type;
        }

        // Get files and directories
        public Returner getDirectoriesInPath()
        {
            Returner returner = new Returner();
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    returner = Iso_Cdrom.getDirectoriesInPath(path, actualPath);
                    break;
            }
            return returner;
        }
        public Returner getFilesInPath()
        {
            Returner returner = new Returner();
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    returner = Iso_Cdrom.getFilesInPath(path, actualPath);
                    break;
            }
            return returner;
        }

        // Extractors
        public ErrorCodes extractFile(string path, string output)
        {
            ErrorCodes ec = ErrorCodes.NoError;
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    ec = Iso_Cdrom.extractFile(path, output, actualPath);
                    break;
            }
            return ec;
        }
    }
}
