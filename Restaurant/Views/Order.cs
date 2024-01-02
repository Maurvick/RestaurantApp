using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Order : Form
    {
        MySqlConnection Connection { get; set; }

        public Order(MySqlConnection Connection)
        { 
            InitializeComponent();
            this.Connection = Connection;
            SetComboBox1();
            SetComboBox2();
        }
 
        private void SetComboBox1()
        {
            
            string Query = "SELECT Food from restaurant.dishes";
            Connection.Open();

            MySqlCommand Command = new(Query, Connection);
            MySqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                cmbDishes.Items.Add(Reader.GetValue(0).ToString());
            }

            Connection.Close();

        }

        private void SetComboBox2()
        {
            string Query = "SELECT OrderName From restaurant.ordertypes";
            Connection.Open();

            MySqlCommand Command = new(Query, Connection);
            MySqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                cmbType.Items.Add(Reader.GetValue(0).ToString());
            }

            Connection.Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDishes.SelectedIndex != -1 && cmbType.SelectedIndex != -1)
                {   
                                                                                                  
                    string Query = "INSERT INTO restaurant.orders (OrderId, Dish, Status) VALUES (" + (cmbDishes.SelectedIndex + 1) + ", '" + (cmbType.SelectedIndex + 1) + "', 'Виконується');";
                    Connection.Open();

                    MySqlCommand Command = new(Query, Connection);
                    Command.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show("Замовлення створено!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Заповніть дані правильно!");
            }
        }
    }
}
