using MySql.Data.MySqlClient;
using RestaurantDB.Service;
using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class NewUser : Form
    {
        private readonly MySqlConnection connection = ConnectionHelper.Connection;

        public NewUser()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text != "" && txtPassword.Text != "")
                {
                    string Query = "INSERT INTO restaurant.users (Login, Password, UserId) VALUES ('" + txtLogin.Text + "', '" + txtPassword.Text + "',2);";
                    connection.Open();

                    MySqlCommand Command = new(Query, connection);
                    Command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Client created successfuly!");
                    return;
                }
            }
            catch
            {
               MessageBox.Show("Entered data is invalid.");
            }
        }
    }
}
