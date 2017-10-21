using System;
using System.IO;
using System.Windows.Forms;

namespace TRF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Checking if config.json file exists for input Admin information.
            if (!File.Exists("config.json"))
            {
                Install installDB = new Install(); // create Install form.
                installDB.ShowDialog(); // Show the Install form Admin informations.
            }
            else
            {
                // There is a config.json file, then run the Login form.
                Application.Run(new Login());
            }
        }
    }
}
