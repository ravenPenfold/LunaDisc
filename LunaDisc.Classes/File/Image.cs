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

        public Returner getDirectoriesInPath(string path)
        {
            Returner returner = new Returner();
            switch(fType)
            {
                case Types.TYPE_CD_DISC:
                    if (cdReader.DirectoryExists(path))
                    {
                        returner.errorCode = ErrorCodes.NoError;
                        foreach (var dir in cdReader.GetDirectories(path))
                        {
                            returner.strings.Add(dir.Split("\\").Last());
                        }
                    } else
                    {
                        returner.errorCode = ErrorCodes.fsNotADirectory;
                    }
                    break;
            }
            return returner;
        }
        public Returner getFilesInPath(string path)
        {
            Returner returner = new Returner();
            switch (fType)
            {
                case Types.TYPE_CD_DISC:
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
                    break;
            }
            return returner;
        }
    }
}
