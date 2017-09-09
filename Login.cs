using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace TRF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = adLoginUser.Text;
            string password = adLoginPass.Text;

            if(getEncryptedPassword(username, password))
            {
                this.Hide(); // Dispose of the Login.
                TRF trf = new TRF();
                trf.ShowDialog(); // Show the TRF form.
            }
            else
            {
                MessageBox.Show("Användarnamn eller lösenord är felaktigt!", "Inloggningsfel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool getEncryptedPassword(string username, string password)
        {
            string path = Directory.GetCurrentDirectory(); // /bin/Debug folder where config.ini is stored
            using (StreamReader r = new StreamReader(path + "/config.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var admininfo in array)
                {
                    // If the username matches the admin in the config file.
                    if(admininfo.admin_username == username)
                    {
                        // Encrypt the password from Login so we can compare with the one in the config file.
                        string encryptPassword = Config.encryption(password);
                        // assing to a variable and make sure its a string.
                        string adminPassword = (string) admininfo.admin_password;
                        if (encryptPassword == adminPassword)
                        {
                            return true; // Password correct, return true to change the form to TRF.                       
                        }
                    }
                }
            }
            return false;
        }
    }
}
