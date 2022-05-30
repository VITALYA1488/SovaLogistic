using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SovaLogistic.Views.PartialViews;
using SovaLogistic.Models;
using SovaLogistic.Utils;
using SovaLogistic.Views;

namespace SovaLogistic.Views.AddForm
{
    public partial class AddFormOrder : Form
    {
        Order ord = new Order();
        public AddFormOrder()
        {
            InitializeComponent();
        }

        private void AddFormOrder_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = ord;
        }
        private void SaveDB()
        {
            try
            {
                DatabaseContext.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка перехода на главную форму
        {
            MainForm f = new MainForm();
            this.Close();
            return;
        }

        private void addBT_Click(object sender, EventArgs e) ///////////////////кнопка добавления данных
        {
            if (orderIDTextBox.Text == "" || nameTextBox.Text == "" || usersIDTextBox.Text == "" || clientIDTextBox.Text == "" || transportIDTextBox.Text == "" || placeArrivalTextBox.Text == "" || dateArrivalDateTimePicker.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            Order ord = new Order();
            ord.OrderID = Convert.ToInt32(orderIDTextBox.Text);
            ord.Name = nameTextBox.Text;
            ord.UsersID = Convert.ToInt32(usersIDTextBox.Text);
            ord.ClientID = Convert.ToInt32(clientIDTextBox.Text);
            ord.TransportID = Convert.ToInt32(transportIDTextBox.Text);
            ord.PlaceDeparture = placeDepartureTextBox.Text;
            ord.PlaceArrival = placeArrivalTextBox.Text;
            ord.DateRegistration = dateRegistrationDateTimePicker.Value;
            ord.DateArrival = dateArrivalDateTimePicker.Value;
            DatabaseContext.db.Order.Add(ord);
            SaveDB();
            MessageBox.Show("Данные сохранены");
        }
    }
}
