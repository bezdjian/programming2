﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TRF
{
    public partial class TRF : Form
    {
        MySqlDataAdapter sAdapter;

        Database database;
        MySqlConnection connection;

        public TRF()
        {
            InitializeComponent();
        }

        private void TRF_Load(object sender, EventArgs e)
        {
            // On load TRF Form, connection to DB and DisplayData on the GridView.
            database = new Database();
            connection = database.connect();
            lblAdmin.Text = getAdminFullname();
            DisplayData();
        }

        //Display Data in DataGridView  
        public void DisplayData(string search = "")
        {
            try
            {
                // If search variable is assigned, then we add the where clause.
                string whereClause = "";
                if(search != "")
                {
                    whereClause = "WHERE concat(firstname, ' ', lastname) like concat('%', replace('" + search + "', ' ', '%'), '%')";
                }
                // Select query.
                string sql = "SELECT id as ID, CONCAT(u.firstname ,' ', u.lastname) as Medlem, u.address as Adress, u.tigername as Tiger FROM users u " + whereClause + " ORDER BY ID DESC";
                // Adapter for commandbuilder
                sAdapter = new MySqlDataAdapter(sql, connection);
                // Create a command builder
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(sAdapter);
                DataTable dt = new DataTable();
                // Fill into DataTable
                sAdapter.Fill(dt);
                // Fill usersDataGrid with datatable
                usersDataGrid.DataSource = dt;
                // Make usersDataGrid columns with 100%
                usersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Simply exit the form.
            connection.Close();
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Simply exit the form after closing the DB.
            connection.Close();
            Environment.Exit(0);
        }

        private void aboutTRFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TRF – Tigerälskarnas Riksförbund.", "TRF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new AddUserForm and display to add new user.
            AddUserForm newUserForm = new AddUserForm();
            newUserForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If the whole row is selected
            if (usersDataGrid.SelectedRows.Count != 0) 
            {
                DataGridViewRow row = usersDataGrid.SelectedRows[0];
                // Setting the user ID from selected row.
                int userid = (int) row.Cells["ID"].Value;
                // Get user's data and Assign to User object.
                User user = database.getUserById(userid);
                // Create a new AddUserForm with the User object to update.
                AddUserForm updateUserForm = new AddUserForm(user);
                updateUserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vänligen välj en rad", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void laggTillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Use the same function as the lägg till buttton
            btnAdd_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Connecting to DB. maybe it should be open the whole time (?)
            Database database = new Database();
            database.connect();

            // If the whole row is selected
            if (usersDataGrid.SelectedRows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Är du säker att du vill radera denna medlem?", "Radera", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DataGridViewRow row = usersDataGrid.SelectedRows[0];
                    // Setting the user ID from selected row.
                    int userid = (int)row.Cells["ID"].Value;
                    database.deleteUserById(userid);
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en rad", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Call the DisplayData method with the txtSearch value to search.
            DisplayData(txtSearch.Text);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the search field text and DisplayData with empty string.
            txtSearch.Text = "";
            DisplayData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Call DisplayData with the search field value as we type, like autocomplete.
            DisplayData(txtSearch.Text);
        }

        private string getAdminFullname()
        {
            // Maybe we should put this in another place, or make a better method. (?)
            string path = Directory.GetCurrentDirectory(); // folder where config.ini is stored
            using (StreamReader r = new StreamReader(path + "/config.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var admininfo in array)
                {
                   return (string) admininfo.admin_fullname;
                }
            }
            return "";
        }
    }
}
