using MySql.Data.MySqlClient;
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

            //Checking if config.json file exists for the database & admin information.
            if (!File.Exists("config.json"))
            {
                Install installDB = new Install(); // create Install form.
                installDB.ShowDialog(); // Show the Install form for DB & admin informations.
            }
            else
            {
                // If there is a config.json file, then run the Login applicaion.
                Application.Run(new Login());
            }
        }
    }
}
