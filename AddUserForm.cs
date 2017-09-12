using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TRF
{
    public partial class AddUserForm : Form
    {
        // User id so we can update.
        int id = 0;

        public AddUserForm(User user)
        {
            // initalizing the ID to update the user
            this.id = user.id;
            // Setting input texts in the form
            InitializeComponent(); // InitializeComponent() before setting new Text. Otherwise throws NullException.
            addName.Text = user.name;
            addLastName.Text = user.lastName;
            addAddress.Text = user.address;
            addTigerName.Text = user.tigername;
        }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnAddEditUser_Click(object sender, EventArgs e)
        {
            string StrQuery;
            Database database = new Database();
            MySqlConnection conn = database.connect();

            try
            {
                // If id is 0, it means we are adding
                if(id == 0)
                {
                    // Creating the insert query for the new user.
                    StrQuery = @"INSERT INTO users (firstname, lastname, address, tigername) VALUES ('"
                        + addName.Text + "', '"
                        + addLastName.Text + "', '"
                        + addAddress.Text + "', '"
                        + addTigerName.Text + "');";
                }
                else
                {
                    // Creating the update query for the user.
                    StrQuery = @"UPDATE users set firstname = '" + addName.Text + "', lastname = '" + addLastName.Text + "', " +
                                "address = '" + addAddress.Text + "', tigername = '" + addTigerName.Text + "' " +
                                "WHERE id = " + this.id;
                }

                MySqlCommand comm = new MySqlCommand(StrQuery, conn);
                comm.ExecuteNonQuery();
                // After insertion, dispose this Form and back to TRF and reload DataGrid.
                this.Dispose();
                // Get the already opened TRF form and call DisplayData to refresh the usersDataGrid.
                TRF trf = (TRF)Application.OpenForms["TRF"];
                trf.DisplayData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tigerWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sv.wikipedia.org/wiki/Tiger");
        }
    }
}
