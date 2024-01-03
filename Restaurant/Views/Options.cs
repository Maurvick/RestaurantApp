using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using RestaurantDB.Models;
using RestaurantDB.Service;

namespace Restaurant
{
    public partial class Options : Form
    {
        private readonly MySqlConnection connection = ConnectionHelper.Connection;

        public Options() 
        {
            InitializeComponent();
            ConnectionHelper.EnsureDbCreated();
        }

        private void DishesButton_Click(object sender, EventArgs e)
        {
            string Query = "SELECT Food, Class, Kitchen, Composition, Price FROM restaurant.dishes";
            connection.Open();

            MySqlCommand Command = new(Query, connection);
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

            Display d = new(list);
            d.ShowDialog();
            connection.Close();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            string Query = "SELECT Food, Class, Composition, Price FROM restaurant.dishes";
            connection.Open();

            MySqlCommand Command = new(Query, connection);
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

            Display d = new(list);
            d.ShowDialog();
            connection.Close();
        }

        private void JournalButton_Click(object sender, EventArgs e)
        {
            string Query = "SELECT Login, Password, ut.UserName from restaurant.users u, restaurant.usertypes ut where u.UserId = ut.Id and ut.Id != 0";
            connection.Open();

            MySqlCommand Command = new(Query, connection);
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

            Display d = new(list);
            d.ShowDialog();
            connection.Close();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            string Query = "SELECT OrderId, ut.DishName, `Status` FROM restaurant.orders u, restaurant.dishnames ut where u.Dish = ut.Id";
            connection.Open();

            MySqlCommand Command = new(Query, connection);
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

            Display d = new(list);
            d.ShowDialog();
            connection.Close();
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            NewUser form4 = new();
            form4.ShowDialog();
        }

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            Order form5 = new();
            form5.ShowDialog();
        }

        private void BanquetButton_Click(object sender, EventArgs e)
        {
            string Query = "SELECT ut.OrderName, Dish, `Status` FROM restaurant.orders u, restaurant.ordertypes ut where u.OrderId = ut.Id;";
            connection.Open();

            MySqlCommand Command = new(Query, connection);
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

            Display d = new(list);
            d.ShowDialog();
            connection.Close();
        }
    }
}
