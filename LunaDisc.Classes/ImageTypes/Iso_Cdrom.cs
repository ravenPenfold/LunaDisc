using DiscUtils.Iso9660;
using LunaDisc.Classes.Codes;
using System.Diagnostics;
using static LunaDisc.Classes.FileMan.DiscImage;

namespace LunaDisc.Classes.ImageTypes
{
    public class Iso_Cdrom
    {
        // Create Image
        public static CDBuilder makeBaseImage(CDBuilder cdBuilder, CDReader cdReader)
        {
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
                cdBuilder.AddDirectory(dir);
                foreach (var file in cdReader.GetFiles(dir))
                {
                    cdBuilder.AddFile(file.Split(";").First(), cdReader.OpenFile(file, FileMode.Open));
                }
            }
            return cdBuilder;
        }
        public static void saveImage(string imagePath, string volumeId) // Saves the Disc Image
        {
            if (File.Exists(imagePath))
            {
                File.Move(imagePath, imagePath + ".temp", true);          // File exists, create a temporary copy to work with
            }
            using (FileStream fs = File.Open(imagePath + ".temp", FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                CDBuilder cdBuilder = new CDBuilder();
                cdBuilder.UseJoliet = true;
                cdBuilder.VolumeIdentifier = volumeId;

                cdBuilder.Build(imagePath);     // Finished
            }
        }

        public static void saveImage(string imagePath, string volumeId, string directory)
        {
            if (File.Exists(imagePath))
            {
                File.Move(imagePath, imagePath + ".temp");          // File exists, create a temporary copy to work with
            }
            using (FileStream fs = File.Open(imagePath + ".temp", FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                CDBuilder cdBuilder = new CDBuilder();
                cdBuilder.UseJoliet = true;
                cdBuilder.VolumeIdentifier = volumeId;

                cdBuilder = makeBaseImage(cdBuilder, cdReader);
                cdBuilder.AddDirectory(directory);

                cdBuilder.Build(imagePath);     // Finished
            }
        }

        public static void saveImage(string imagePath, string volumeId, string file, byte[] fileData)
        {
            if (File.Exists(imagePath))
            {
                File.Move(imagePath, imagePath + ".temp");          // File exists, create a temporary copy to work with
            }
            using (FileStream fs = File.Open(imagePath + ".temp", FileMode.Open))
            {
                CDReader cdReader = new CDReader(fs, true);
                CDBuilder cdBuilder = new CDBuilder();
                cdBuilder.UseJoliet = true;
                cdBuilder.VolumeIdentifier = volumeId;

                cdBuilder = makeBaseImage(cdBuilder, cdReader);
                cdBuilder.AddFile(file, fileData);

                cdBuilder.Build(imagePath);     // Finished
            }
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
