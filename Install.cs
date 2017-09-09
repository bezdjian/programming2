using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TRF
{
    public partial class Install : Form
    {
        public Install()
        {
            InitializeComponent();
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            //Encrypt the password
            //string password = Config.Encrypt(adPass.Text);
            string password = Config.encryption(adPass.Text);
            // Creating a list of Config class (1 row is one class) we might need more than a row.
            List<Config> dbConfig = new List<Config>();
            dbConfig.Add(new Config(
                dbName.Text,         //db name from the input 
                dbUser.Text,         //db user from the input
                dbPass.Text,         //db password from the input
                dbHost.Text,         //db host from the input
                adUserName.Text,     //admin username from the input 
                adUserFullName.Text, //admin fullname from the input
                password             //admin password from the input
            ));

            // JsonConvert package has to be installed, I have mentioned in the project report.
            string jsonConfig = JsonConvert.SerializeObject(dbConfig.ToArray());

            //write json (DB info) to file
            string path = Directory.GetCurrentDirectory(); // /bin/Debug folder..
            File.WriteAllText(path + @"\config.json", jsonConfig);

            //Initializing the DB.
            Database database = new Database();
            MySqlConnection conn = database.connect();

            //Create the tables
            database.CreateTables(conn);

            this.Dispose(); // Dispose Install form to show the TRF app.
            Login loginApp = new Login();
            loginApp.ShowDialog();
        }
    }
}
