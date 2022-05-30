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

namespace SovaLogistic.Views
{
    public partial class EditFormOrder : Form
    {
        Order ord = new Order();
        public EditFormOrder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка перехода на главную форму
        {
            MainForm f = new MainForm();
            this.Close();
            return;
        }

        private void AddFormOrder_Load(object sender, EventArgs e) 
        {
            foreach (OrdersLog ordCard in MainForm.selectedOrderCard)
            {
                ord = DatabaseContext.db.Order.First(x => "ID заказа: " + x.OrderID.ToString() == ordCard.OrderIDLB.Text.ToString());
                orderBindingSource.DataSource = ord;
            }
        }

        private void button1_Click(object sender, EventArgs e) ///////////////////кнопка редактирования данных
        {
            if (nameTextBox.Text == "" || usersIDTextBox.Text == "" || clientIDTextBox.Text == "" || transportIDTextBox.Text == "" || placeArrivalTextBox.Text == "" || dateArrivalDateTimePicker.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            ord.Name = nameTextBox.Text;
            ord.UsersID = Convert.ToInt32(usersIDTextBox.Text);
            ord.ClientID = Convert.ToInt32(clientIDTextBox.Text);
            ord.TransportID = Convert.ToInt32(transportIDTextBox.Text);
            ord.PlaceDeparture = placeDepartureTextBox.Text;
            ord.PlaceArrival = placeArrivalTextBox.Text;
            ord.DateRegistration = dateRegistrationDateTimePicker.Value;
            ord.DateArrival = dateArrivalDateTimePicker.Value;
            SaveDB();
            MessageBox.Show("Данные сохранены");
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

        private void ClientIDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBT_Click(object sender, EventArgs e) ///////////////////кнопка удаления данных
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить " + ord.Name + "?",
    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DatabaseContext.db.Order.Remove(ord);
                SaveDB();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
