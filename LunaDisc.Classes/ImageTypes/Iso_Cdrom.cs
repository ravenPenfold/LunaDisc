using DiscUtils.Iso9660;
using LunaDisc.Classes.Codes;
using LunaDisc.Classes.FileMan;
using System.Diagnostics;
using static LunaDisc.Classes.FileMan.DiscImage;

namespace LunaDisc.Classes.ImageTypes
{
    public class Iso_Cdrom
    {
        // Image Builder
        public static void generateNewImage(string imagePath, string volumeId)
        {
            Log.Print(LogType.INFO, "Begin generation of image");
            CDBuilder cdBuilder = new CDBuilder();
            cdBuilder.VolumeIdentifier = volumeId;
            cdBuilder.UseJoliet = true;
            cdBuilder.Build(imagePath);
            Log.Print(LogType.INFO, "Image generation successful");
        }

        public static void buildImage(string imagePath, string volumeId, List<DiscImage.FileWriting> data, List<string> ignores)
        {
            List<string> names = new List<string>();

            if (File.Exists(imagePath))
            {
                File.Move(imagePath, imagePath + ".tmp");
                Log.Print(LogType.INFO, "Get existing info from image...");
                using (FileStream fs = new FileStream(imagePath + ".tmp", FileMode.Open))
                {
                    CDReader cdReader = new CDReader(fs, true);
                    List<string> directories = new List<string>();
                    directories.Add("\\");
                    int i = 0;
                    while (true)
                    {
                        if (directories.Count != i)
                        {
                            Debug.Write(directories[i]);
                            foreach (var dir in cdReader.GetDirectories(directories[i])) // Loop through & add each directory to a list
                            {
                                directories.Add(dir);
                            }
                        }
                        else
                        {
                            break;
                        }
                        i++;
                    }
                    foreach (string dir in directories)     // Add directories and files
                    {
                        data.Add(new FileWriting(dir, true, [0]));
                        foreach (var file in cdReader.GetFiles(dir))
                        {
                            Debug.WriteLine(file);
                            data.Add(new FileWriting(file, false, new byte[cdReader.GetFileLength(file)]));
                            var read = cdReader.OpenFile(file, FileMode.Open);

                            for (int j = 0; i < cdReader.GetFileInfo(file).Length; i++)
                            {
                                data.Last().data[i] = (byte)read.ReadByte();
                            }
                            read.Close();
                        }
                    }
                    Log.Print(LogType.INFO, "No. Directories to copy from original image (incl. Root) - " + directories.Count());
                    Log.Print(LogType.INFO, "No. Files & Directories to copy from original image (incl. Root) - " + data.Count());
                }
                Log.Print(LogType.INFO, "Remove old image...");
                File.Delete(imagePath + ".tmp");
            }

            CDBuilder cdBuilder = new CDBuilder();
            cdBuilder.UseJoliet = true;
            cdBuilder.VolumeIdentifier = volumeId;

            List<int> removeIds = new List<int>();
            foreach (var i in ignores)
            {
                foreach (var d in data)
                {
                    if (d.fileLocation == i)
                    {
                        Debug.WriteLine("ID to delete: " + data.IndexOf(d));
                    }
                }
            }

            foreach (DiscImage.FileWriting w in data)
            {
                if (w.isDirectory == true)
                {
                    cdBuilder.AddDirectory(w.fileLocation);
                    Log.Print(LogType.INFO, "Added directory \"" + w.fileLocation + "\"");
                }
                else
                {
                    cdBuilder.AddFile(w.fileLocation, w.data);
                    Log.Print(LogType.INFO, "Added file \"" + w.fileLocation + "\" of size " + w.data.Length + " bytes");
                }
            }
            Log.Print(LogType.INFO, "Constructing image...");
            cdBuilder.Build(imagePath);
            Log.Print(LogType.INFO, "Finished Exporting");
        }

        // Volume Information
        public static string getVolumeName(string imagePath)
        {
            string s;
            using (FileStream fs = File.Open(imagePath, FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                s = cdReader.VolumeLabel;
            }
            return s;
        }

        // File System
        public static List<string> tempGetAllFiles(string imagePath)
        {
            List<string> s;
            using (FileStream fs = File.Open(imagePath, FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                s = cdReader.GetFileSystemEntries("\\").ToList();
            }
            return s;
        }
        public static ErrorCodes extractFile(string path, string output, string imagePath)  // Extract file from Disc Image
        {
            using (FileStream fs = File.Open(imagePath, FileMode.Open))
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

        public static byte[] getAllBytes(string path, string imagePath)  // Extract file from Disc Image
        {
            byte[] bytes = new byte[0];
            using (FileStream fs = File.Open(imagePath, FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                if (cdReader.FileExists(path))
                {
                    bytes = new byte[cdReader.GetFileInfo(path).Length];
                    var read = cdReader.OpenFile(path, FileMode.Open);
                    for (int i = 0; i < cdReader.GetFileInfo(path).Length; i++)
                    {
                        bytes[i] = (byte)read.ReadByte();
                    }
                    read.Close();
                }
            }
            return bytes;
        }

        public static Returner getFilesInPath(string path, string imagePath)                // Get Files in Path
        {
            Returner returner = new Returner();
            using (FileStream fs = File.Open(imagePath, FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                if (cdReader.DirectoryExists(path))
                {
                    returner.errorCode = ErrorCodes.NoError;
                    foreach (var file in cdReader.GetFiles(path))
                    {
                        returner.strings.Add(file.Split("\\").Last().Split(";").First());
                    }
                }
                else
                {
                    returner.errorCode = ErrorCodes.fsNotADirectory;
                }
            }
            return returner;
        }
        public static Returner getDirectoriesInPath(string path, string imagePath)          // Get Directories in Path
        {
            Returner returner = new Returner();
            using (FileStream fs = File.Open(imagePath, FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                if (cdReader.DirectoryExists(path))
                {
                    returner.errorCode = ErrorCodes.NoError;
                    foreach (var dir in cdReader.GetDirectories(path))
                    {
                        returner.strings.Add(dir.Split("\\").Last());   // Returns only the LAST part of a fullDirectory string
                    }
                }
                else
                {
                    returner.errorCode = ErrorCodes.fsNotADirectory;
                }
            }
            return returner;
        }
    }
}
