using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string user = txtLogin.Text;
            string password = txtPassword.Text;

            MySqlConnection con = new($"Database='';Datasource=localhost;User={user};Password={password}");
            Menu menu = new(con);

            try
            {
                con.Open();
               
                Hide();

                con.Close();

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
