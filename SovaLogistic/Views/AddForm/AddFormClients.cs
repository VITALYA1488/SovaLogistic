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
    public partial class AddFormClients : Form
    {
        Client cln = new Client();
        public AddFormClients()
        {
            InitializeComponent();
        }

        private void AddFormClients_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = cln;
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

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка перехода на главную форму
        {
            MainForm f = new MainForm();
            this.Close();
            return;
        }

        private void addBT_Click(object sender, EventArgs e) ///////////////////кнопка добавления данных
        {
            if (clientIDTextBox.Text == "" || nameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            Client cln = new Client();
            cln.ClientID = Convert.ToInt32(clientIDTextBox.Text);
            cln.Name = nameTextBox.Text;
            cln.Phone = phoneTextBox.Text;
            cln.Birthday = birthdayDateTimePicker.Value;
            DatabaseContext.db.Client.Add(cln);
            SaveDB();
            MessageBox.Show("Данные сохранены");
        }
    }
}
