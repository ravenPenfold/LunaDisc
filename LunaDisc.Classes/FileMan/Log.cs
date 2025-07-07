using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LunaDisc.Classes.FileMan
{
    public class Log
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);
        public static void Print(LogType type, string message)
        {
            string log = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LunaDisc\\active.log";
            string toWrite = "[" + DateTime.Now.ToString() + " | " + type + "] " + message;
            Debug.WriteLine(toWrite);
            Console.WriteLine(toWrite);
            File.AppendAllText(log, toWrite + "\n");
            if(type == LogType.FATAL)
            {
                System.Media.SystemSounds.Hand.Play();
                MessageBox((IntPtr)0, "A fatal error occurred, and LunaDisc needs to close. Please see below for the message:\n\"" + message + "\"\nYou can view the log in the %APPDATA% folder for more details.", "Fatal Error", 0);
                CloseLog();
                Environment.Exit(1);
            }
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
