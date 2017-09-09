using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TRF
{
    class Database
    {
        MySqlConnection connection = null;
        public string connectionstring;
        public MySqlConnection connect()
        {
            try
            {
                string database_info = getDataBaseInfo();
                connection = new MySqlConnection(database_info);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Databas kopplingen mislyckades!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        private String getDataBaseInfo()
        {
            string path = Directory.GetCurrentDirectory(); // /bin/Debug folder where config.json is stored
            using (StreamReader r = new StreamReader(path + "/config.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var dbinfo in array)
                {
                    this.connectionstring = "server="+dbinfo.database_host+";database="+dbinfo.database_name+";UserId="+dbinfo.database_user+";Password="+dbinfo.database_password;
                }
            }
            return this.connectionstring;
        }

        public void close()
        {
            connection.Close();
        }

        public void CreateTables(MySqlConnection conn)
        {
            // Users table.
            string createUsers = "CREATE TABLE IF NOT EXISTS users (id INT(11) NOT NULL AUTO_INCREMENT,firstname NVARCHAR(100), lastname NVARCHAR(100), address NVARCHAR(100), tigername NVARCHAR(100), primary key (id) )";
            MySqlCommand createUserTable = new MySqlCommand(createUsers, conn);
            createUserTable.ExecuteNonQuery();

            /*
            // Tiger table.
            string createTiger = "CREATE TABLE IF NOT EXISTS tiger (id INT(11) NOT NULL AUTO_INCREMENT, name NVARCHAR(100), user_id INT(11), primary key (id) )";
            MySqlCommand createTigerTable = new MySqlCommand(createTiger, conn);
            createTigerTable.ExecuteNonQuery();
            */
        }

        public User getUserById(int id)
        {
            string getUserQuery = "SELECT * FROM users WHERE id = " + id;
            MySqlCommand command = new MySqlCommand(getUserQuery, this.connection);
            MySqlDataReader reader = command.ExecuteReader();
            User user = new User();
            while (reader.Read())
            {
                user.id = reader.GetInt32("id");
                user.name = reader.GetString("firstname");
                user.lastName = reader.GetString("lastname");
                user.address= reader.GetString("address");
                user.tigername = reader.GetString("tigername");
            }
            return user;
        }

        public void deleteUserById(int id)
        {
            try
            {
                string getUserQuery = "DELETE FROM users WHERE id = " + id;
                MySqlCommand command = new MySqlCommand(getUserQuery, this.connection);
                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
