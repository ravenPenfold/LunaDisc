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
            return returner;0
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
            using (FileStream fs = File.Open(actualPath, FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                if (cdReader.FileExists(path))
                {
                    var read = cdReader.OpenFile(path, FileMode.Open);
                    var write = new BinaryWriter(new FileStream(output, FileMode.Create));
                    for (int i = 0; i < cdReader.GetFileInfo(path).Length; i++)
                    {
                        write.Write((byte)read.ReadByte());
                    }
                    read.Close();
                    write.Close();
                }
                else
                {
                    return ErrorCodes.fsNotAFile;
                }
            }
            return ErrorCodes.NoError;
        }
    }
}
