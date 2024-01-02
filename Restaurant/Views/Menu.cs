using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using RestaurantDB.Models;

namespace Restaurant
{
    public partial class Menu : Form
    {
        MySqlConnection Connection { get; set; }

        public Menu(MySqlConnection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            string Query = "SELECT Food, Class, Kitchen, Composition, Price FROM restaurant.dishes";
            Connection.Open();

            MySqlCommand Command = new(Query, Connection);
            List<Dishes> list = [];
            MySqlDataReader Reader = Command.ExecuteReader();


            while (Reader.Read())
            {
                list.Add(new Dishes()
                {
                    Food = Reader.GetValue(0).ToString(),
                    Class = Reader.GetValue(1).ToString(),
                    Kitchen = Reader.GetValue(2).ToString(),
                    Composition = Reader.GetValue(3).ToString(),
                    Price = Reader.GetValue(4).ToString()
                });
            }

            btnDishes form3 = new(list);
            form3.ShowDialog();
            Connection.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string Query = "SELECT Food, Class, Composition, Price FROM restaurant.dishes";
            Connection.Open();

            MySqlCommand Command = new(Query, Connection);
            List<RestaurantDB.Models.Menu> list = [];
            MySqlDataReader Reader = Command.ExecuteReader();
            

            while (Reader.Read())
            {
                list.Add(new RestaurantDB.Models.Menu()
                {
                    Food = Reader.GetValue(0).ToString(),
                    Class = Reader.GetValue(1).ToString(),
                    Composition = Reader.GetValue(2).ToString(),
                    Price = Reader.GetValue(3).ToString()
                });
            }

            btnDishes form3 = new(list);
            form3.ShowDialog();
            Connection.Close();
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            string Query = "SELECT Login, Password, ut.UserName from restaurant.users u, restaurant.usertypes ut where u.UserId = ut.Id and ut.Id != 0";
            Connection.Open();

            MySqlCommand Command = new(Query, Connection);
            List<Users> list = [];
            MySqlDataReader Reader = Command.ExecuteReader();
            

            while (Reader.Read())
            {
                list.Add(new Users()
                {
                    Login = Reader.GetValue(0).ToString(),
                    Password = Reader.GetValue(1).ToString(),
                    UserId = Reader.GetValue(2).ToString()
                });
            }

            btnDishes form3 = new(list);
            form3.ShowDialog();
            Connection.Close();
        }

        // Orders
        private void btnOrders_Click(object sender, EventArgs e)
        {
            string Query = "SELECT OrderId, ut.DishName, `Status` FROM restaurant.orders u, restaurant.dishnames ut where u.Dish = ut.Id";
            Connection.Open();

            MySqlCommand Command = new(Query, Connection);
            List<Orders> list = [];
            MySqlDataReader Reader = Command.ExecuteReader();


            while (Reader.Read())
            {
                list.Add(new Orders()
                {
                    OrderId = Reader.GetValue(0).ToString(),
                    Food = Reader.GetValue(1).ToString(),
                    Status = Reader.GetValue(2).ToString()
                });
            }

            btnDishes form3 = new(list);
            form3.ShowDialog();
            Connection.Close();
        }

        // Add Users
        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            NewUser form4 = new(Connection);
            form4.ShowDialog();
        }

        // Add Orders
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            Order form5 = new(Connection);
            form5.ShowDialog();
        }

        // Party
        private void btnBanquet_Click(object sender, EventArgs e)
        {
            string Query = "SELECT ut.OrderName, Dish, `Status` FROM restaurant.orders u, restaurant.ordertypes ut where u.OrderId = ut.Id;";
            Connection.Open();

            MySqlCommand Command = new(Query, Connection);
            List<Orders> list = [];
            MySqlDataReader Reader = Command.ExecuteReader();


            while (Reader.Read())
            {
                list.Add(new Orders()
                {
                    OrderId = Reader.GetValue(0).ToString(),
                    Food = Reader.GetValue(1).ToString(),
                    Status = Reader.GetValue(2).ToString()
                });
            }

            btnDishes form3 = new(list);
            form3.ShowDialog();
            Connection.Close();
        }
    }
}
