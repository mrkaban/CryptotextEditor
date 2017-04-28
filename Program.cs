using System;
using System.Windows.Forms;

namespace CryptotextEditor
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Settings.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                Application.Run(new Editor(args[0]));
            }
            else
            {
                Application.Run(new Editor(""));
            }
        }
    }
}