using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            // Validate fields
            if (validate())
            {
                //Encrypt the passwords
                string password = Config.encryption(adPass.Text);
                // Creating a list of Config class (1 row is one class) we might need more than a row.
                List<Config> dbConfig = new List<Config>();
                dbConfig.Add(new Config(
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
                SqlConnection conn = database.connect();

                this.Hide(); // Dispose Install form to show the TRF app.
                Login loginApp = new Login();
                loginApp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Var vänlig och fyll i fälten", "Obligatoriska fält", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validate()
        {
            if(String.IsNullOrEmpty(adUserFullName.Text) || String.IsNullOrEmpty(adUserName.Text) || String.IsNullOrEmpty(adPass.Text))
            {
                return false;
            }
            return true;
        }
    }
}
