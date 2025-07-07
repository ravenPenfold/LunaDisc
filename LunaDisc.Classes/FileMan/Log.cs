using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDisc.Classes.FileMan
{
    public class Log
    {
        public static void Print(LogType type, string message)
        {
            string log = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LunaDisc\\active.log";
            string toWrite = "[" + DateTime.Now.ToString() + " | " + type + "]      " + message;
            Debug.WriteLine(toWrite);
            Console.WriteLine(toWrite);
            File.AppendAllText(log, toWrite + "\n");
        }

        public static void CloseLog()
        {
            Print(LogType.INFO, "Close session request sent, moving log file to backup...");
            if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\\\LunaDisc\\Logs"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\\\LunaDisc\\Logs");
                Print(LogType.INFO, "Log Directory not found, made new one");
            }
            Print(LogType.INFO, "LunaDisc Session End");
            string oldLog = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LunaDisc\\active.log";
            string newLog = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LunaDisc\\Logs\\SessionEnd_" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "_").Replace(":",".") + ".log";
            File.Move(oldLog, newLog);
        }
    }

    public enum LogType
    {
        INFO,
        WARNING,
        ERROR,
        FATAL
    }
}
