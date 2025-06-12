using DiscUtils.Streams;
using LunaDisc.Classes.Codes;
using LunaDisc.Classes.ImageTypes;
using System.Diagnostics;
using System.Reflection;

namespace LunaDisc.Classes.FileMan
{
    public class DiscImage
    {
        // Initialize Global Variables
        public Types fType;
        public string path;

        public List<FileWriting> dataToWrite;
        public List<string> ignoreList;
        public string actualPath;
        public static string tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LunaDisc\\New Image.bin";

        // for use when saving
        public struct FileWriting
        {
            public string fileLocation;
            public bool isDirectory;
            public byte[] data;

            public FileWriting(string fLocation, bool iDirectory, byte[] Data)
            {
                data = Data;
                fileLocation = fLocation;
                isDirectory = iDirectory;
            }
        }
        
        public void removeFile(string fileName)
        {
            ignoreList.Add(fileName);
        }

        public void renameOrMoveFile(string oldName, string newName)
        {
            ignoreList.Add(oldName);

        }

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
            dataToWrite = new List<FileWriting>();
            ignoreList = new List<string>();
            actualPath = fileName;
            path = "\\";
            fType = type;
        }

        public DiscImage(Types type, string volumeName)
        {
            path = "\\";
            fType = type;
            dataToWrite = new List<FileWriting>();
            ignoreList = new List<string>();
            actualPath = tempPath;
            newImage(volumeName);
        }

        // Get volume information
        public string volumeName()
        {
            string s = "No Label";
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    s = Iso_Cdrom.getVolumeName(actualPath);
                    break;
            }
            return s;
        }

        // Cleanup Temp ISO
        public static void cleanUp()
        {
            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
        }

        // Builders

        public void newImage(string volumeName)
        {
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    Iso_Cdrom.generateNewImage(actualPath, volumeName);
                    break;
            }
        }

        public void buildImage(string volumeName)
        {
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    Iso_Cdrom.buildImage(actualPath, volumeName, dataToWrite);
                    break;
            }
            dataToWrite = new List<FileWriting>();
            cleanUp();
        }

        public void addFile(string file, string path)
        {
            if (File.Exists(file))
            {
                switch (fType)
                {
                    case Types.TYPE_CD_DISC:
                        // Iso_Cdrom.saveImage(tempFile, volumeName(), path + file.Split("\\").Last(), File.ReadAllBytes(file));
                        dataToWrite.Add(new FileWriting(path, false, File.ReadAllBytes(file)));
                        break;
                }
            }
        }

        public void addDirectory(string directory)
        {
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    dataToWrite.Add(new FileWriting(path + directory, true, [0]));
                    break;
            }
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
