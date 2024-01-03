using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using RestaurantDB.Service;

namespace Restaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string user = txtLogin.Text;
            string password = txtPassword.Text;

            // Configure connection
            MySqlConnection connection = new($"Database='';Datasource=localhost;User={user};Password={password}");

            // Set connection as accessible property
            ConnectionHelper.Connection = connection;

            try
            {
                Options menu = new();

                // Close connection to enable operations with db
                connection.Close();

                Hide();

                menu.ShowDialog();

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Entered data is invalid.");
            }
        }
    }
}
