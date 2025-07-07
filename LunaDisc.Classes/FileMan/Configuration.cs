using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDisc.Classes.FileMan
{
    public class Configuration
    {
        private string confPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LunaDisc\\config.conf";
        public ConfType config;
        public Configuration() {
            loadConfig();
        }

        public void saveConfig()
        {
            using (StreamWriter s = new StreamWriter(confPath))
            {
                s.NewLine = "\n";
                s.WriteLine("; ===== LunaDisc Configutation =====\n; Auto Generated on " + DateTime.Now.ToString());

                s.WriteLine("\n; Paths");
                s.WriteLine("lastPath = " + config.lastPath);

                s.WriteLine("\n; Image Defaults");
                s.WriteLine("defaultImageName = " + config.defaultImageName);
                s.WriteLine("useJoilet = " + config.useJoilet);

                s.WriteLine("\n; System Configurations - It's probably best that you leave these untouched...");
                s.WriteLine("debug = " + config.debug);

                s.Close();
            }
            Log.Print(LogType.INFO, "Saved configuration successfully");
        }

        public void loadConfig()
        {
            Log.Print(LogType.INFO, "Begin attempt to load configuration");
            config = new ConfType();
            if (!File.Exists(confPath))
            {
                Log.Print(LogType.ERROR, "Configuration doesn't exist. Attempting generation of custom one...");
                using (StreamWriter s = new StreamWriter(File.Open(confPath, FileMode.Create)))
                {
                    s.Write(Data.Properties.Resources.default_conf);
                    s.Close();
                }
                Log.Print(LogType.INFO, "Configuration generation successful");
            }

            int i = 0;
            foreach (string line in File.ReadAllLines(confPath))
            {
                i++;
                string ln = line.Replace(" ", "");
                if(!ln.StartsWith(";") && ln.Length != 0)
                {
                    string[] l = ln.Split("=");
                    if (l.Length == 2)
                    {
                        switch (l[0].ToLower())
                        {
                            case "debug":
                                config.debug = true;
                                break;

                            case "defaultimagename":
                                config.defaultImageName = l[1];
                                break;

                            case "lastpath":
                                config.lastPath = l[1];
                                break;

                            case "usejoilet":
                                config.useJoilet = Convert.ToBoolean(l[1]);
                                break;

                            default:
                                string err = "[WARN] Config Line " + i + " is listing an invalid config option. This has been skipped. Code: \"" + line + "\"";
                                Console.WriteLine(err);
                                Log.Print(LogType.ERROR, err);
                                break;
                        }
                    } else
                    {
                        string err = "[WARN] Config Line " + i + " is missing a parameter. This config has been skipped. Code: \"" + line + "\"";
                        Console.WriteLine(err);
                        Log.Print(LogType.ERROR, err);
                    }
                    
                }
            }
            Log.Print(LogType.INFO, "Configuration loaded successfully");
        }
    }
}
