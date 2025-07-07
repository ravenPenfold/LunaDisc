using DiscUtils.Streams;
using LunaDisc.Classes.Codes;
using LunaDisc.Classes.ImageTypes;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

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
            Log.Print(LogType.INFO, fileName + " added to IgnoreList");
            ignoreList.Add(fileName);
        }

        public void renameOrMoveFile(string oldName, string newName)
        {
            dataToWrite.Add(new FileWriting(newName, false, getAllBytes(oldName)));
            Log.Print(LogType.INFO, oldName + " added to IgnoreList");
            Log.Print(LogType.INFO, newName + " added to DataToWrite List");
            ignoreList.Add(path + oldName);
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
            Log.Print(LogType.INFO, "Begun load of " + type + " image \"" + fileName + "\"");
            dataToWrite = new List<FileWriting>();
            ignoreList = new List<string>();
            actualPath = fileName;
            path = "\\";
            fType = type;
            Log.Print(LogType.INFO, "Image loaded successfully");
        }

        public DiscImage(Types type, string volumeName)
        {
            Log.Print(LogType.INFO, "Creating new " + type + " image with the volume name \"" + volumeName + "\"");
            path = "\\";
            fType = type;
            dataToWrite = new List<FileWriting>();
            ignoreList = new List<string>();
            actualPath = tempPath;
            newImage(volumeName);
            Log.Print(LogType.INFO, "Image created successfully");
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
                Log.Print(LogType.INFO, "Temporary image removed");
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
            Log.Print(LogType.INFO, "Begin building of image \"" + volumeName + "\"");
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    Iso_Cdrom.buildImage(actualPath, volumeName, dataToWrite, ignoreList);
                    break;
            }
            dataToWrite = new List<FileWriting>();
            cleanUp();
            Log.Print(LogType.INFO, "Image built successfully");
        }

        public void addFile(string file, string path)
        {
            if (File.Exists(file))
            {
                switch (fType)
                {
                    case Types.TYPE_CD_DISC:
                        // Iso_Cdrom.saveImage(tempFile, volumeName(), path + file.Split("\\").Last(), File.ReadAllBytes(file));
                        Log.Print(LogType.INFO, "\"" + file + "\" added to DataToWrite list");
                        dataToWrite.Add(new FileWriting(path, false, File.ReadAllBytes(file)));
                        break;
                }
            }
        }

        public void addDirectory(string directory)
        {
            Log.Print(LogType.INFO, "\"" + directory + "\" added to DataToWrite list");
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

        // Get all Bytes
        public byte[] getAllBytes(string path)
        {
            byte[] bytes = new byte[0];
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    bytes = Iso_Cdrom.getAllBytes(path, actualPath);
                    break;
            }
            return bytes;
        }

        // Extractors
        public ErrorCodes extractFile(string path, string output)
        {
            Log.Print(LogType.INFO, "Begin extraction of file \"" + path);
            ErrorCodes ec = ErrorCodes.NoError;
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
                    ec = Iso_Cdrom.extractFile(path, output, actualPath);
                    break;
            }
            return ec;
            Log.Print(LogType.INFO, "Extraction of \"" + path + "\" successful");
        }
    }
}
