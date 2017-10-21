using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TRF
{
    class Database
    {
        SqlConnection connection = null;

        public SqlConnection connect()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = Properties.Settings.Default.trfConnectionString;
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Databas kopplingen mislyckades!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
        
        public void close()
        {
            connection.Close();
        }

        public User getUserById(int id)
        {
            string getUserQuery = "SELECT * FROM users WHERE id = " + id;
            SqlCommand command = new SqlCommand(getUserQuery, this.connection);
            SqlDataReader reader = command.ExecuteReader();
            User user = new User();
            while (reader.Read())
            {
                user.id = reader.GetInt32(0);
                user.name = reader.GetString(1);
                user.lastName = reader.GetString(2);
                user.address= reader.GetString(3);
                user.tigername = reader.GetString(4);
            }
            // We get 'reader should be closed first' error if we do not close it.
            reader.Close();
            return user;
        }

        public void deleteUserById(int id)
        {
            try
            {
                string deleteUserQuery = "DELETE FROM users WHERE id = " + id;
                SqlCommand command = new SqlCommand(deleteUserQuery, this.connection);
                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteAllUsers()
        {
            try
            {
                string deleteUserQuery = "TRUNCATE TABLE users";
                SqlCommand command = new SqlCommand(deleteUserQuery, this.connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
