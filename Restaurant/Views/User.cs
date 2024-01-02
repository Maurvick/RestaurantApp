using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class NewUser : Form
    {
        MySqlConnection Connection { get; set; }

        public NewUser(MySqlConnection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text != "" && txtPassword.Text != "")
                {
                    string Query = "INSERT INTO restaurant.users (Login, Password, UserId) VALUES ('" + txtLogin.Text + "', '" + txtPassword.Text + "',2);";
                    Connection.Open();

                    MySqlCommand Command = new(Query, Connection);
                    Command.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show("Кліент успішно створений!");
                    return;
                }
            }
            catch
            {
               MessageBox.Show("Неправильно заповнено дані!");
            }
        }
    }
}
