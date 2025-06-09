using DiscUtils.Iso9660;
using LunaDisc.Classes.Codes;
using static LunaDisc.Classes.FileMan.DiscImage;

namespace LunaDisc.Classes.ImageTypes
{
    public class Iso_Cdrom
    {
        public static Returner getFilesInPath(string path, string imagePath)
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
                        returner.strings.Add(file.Split("\\").Last());
                    }
                }
                else
                {
                    returner.errorCode = ErrorCodes.fsNotADirectory;
                }
            }
            return returner;
        }
        public static Returner getDirectoriesInPath(string path, string imagePath)
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
