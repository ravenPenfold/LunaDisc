using LunaDisc.Classes.FileMan;
using System.Runtime.ExceptionServices;

namespace LunaDisc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += handleException;
            AppDomain.CurrentDomain.FirstChanceException += handleException;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MainWindow());
        }

        static void handleException(object? sender, FirstChanceExceptionEventArgs e)
        {
            Exception ex = (Exception)e.Exception;
            Log.Print(ex);
        }

        static void handleException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            Log.Print(ex);
        }
    }
}