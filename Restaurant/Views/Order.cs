using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using RestaurantDB.Service;

namespace Restaurant
{
    public partial class Order : Form
    {
        private readonly MySqlConnection connection = ConnectionHelper.Connection;

        public Order()
        { 
            InitializeComponent();
            SetComboBox1();
            SetComboBox2();
        }
 
        private void SetComboBox1()
        {
            
            string Query = "SELECT Food from restaurant.dishes";
            connection.Open();

            MySqlCommand Command = new(Query, connection);
            MySqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                cmbDishes.Items.Add(Reader.GetValue(0).ToString());
            }

            connection.Close();

        }

        private void SetComboBox2()
        {
            string Query = "SELECT OrderName From restaurant.ordertypes";
            connection.Open();

            MySqlCommand Command = new(Query, connection);
            MySqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                cmbType.Items.Add(Reader.GetValue(0).ToString());
            }

            connection.Close();

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDishes.SelectedIndex != -1 && cmbType.SelectedIndex != -1)
                {   
                                                                                                  
                    string Query = "INSERT INTO restaurant.orders (OrderId, Dish, Status) VALUES (" + (cmbDishes.SelectedIndex + 1) + ", '" + (cmbType.SelectedIndex + 1) + "', 'Виконується');";
                    connection.Open();

                    MySqlCommand Command = new(Query, connection);
                    Command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Order created successfuly!");
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
