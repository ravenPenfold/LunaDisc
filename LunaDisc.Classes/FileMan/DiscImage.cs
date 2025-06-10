using LunaDisc.Classes.Codes;
using LunaDisc.Classes.ImageTypes;
using System.Reflection;

namespace LunaDisc.Classes.FileMan
{
    public class DiscImage
    {
        // Initialize Global Variables
        public Types fType;
        public string path;

        public string tempFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LunaDisc.tmp";
        public string actualPath;

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
            File.Copy(actualPath, tempFile, true);
            path = "\\";
            fType = type;
        }

        public DiscImage(Types type, string volumeName)
        {
            path = "\\";
            fType = type;

            actualPath = "New Image";
            buildImage(volumeName);
        }

        // Get volume information
        public string volumeName()
        {
            string s = "No Label";
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    s = Iso_Cdrom.getVolumeName(tempFile);
                    break;
            }
            return s;
        }

        // Builders
        public void buildImage(string volumeName)
        {
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    Iso_Cdrom.saveImage(tempFile, volumeName);
                    break;
            }
        }

        public void addFile(string file, string path)
        {
            if (File.Exists(file))
            {
                switch (fType)
                {
                    case Types.TYPE_CD_DISC:
                        Iso_Cdrom.saveImage(tempFile, volumeName(), path + file.Split("\\").Last(), File.ReadAllBytes(file));
                        break;
                }
            }
        }

        public void addDirectory(string directory)
        {
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    Iso_Cdrom.saveImage(tempFile, volumeName(), directory);
                    break;
            }
        }

        public void saveImage(string outPath)
        {
            File.Copy(tempFile, outPath, true);
        }

        // Get files and directories
        public Returner getDirectoriesInPath()
        {
            Returner returner = new Returner();
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    returner = Iso_Cdrom.getDirectoriesInPath(path, tempFile);
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
                    returner = Iso_Cdrom.getFilesInPath(path, tempFile);
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
                    ec = Iso_Cdrom.extractFile(path, output, tempFile);
                    break;
            }
            return ec;
        }
    }
}
