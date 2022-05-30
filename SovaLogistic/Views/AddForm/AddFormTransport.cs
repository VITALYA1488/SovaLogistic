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
    public partial class AddFormTransport : Form
    {
        Transport trs = new Transport();
        public AddFormTransport()
        {
            InitializeComponent();
        }

        private void AddFormTransport_Load(object sender, EventArgs e)
        {
            transportBindingSource.DataSource = trs;
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
            if (transortIDTextBox.Text == "" || nameTextBox.Text == "" || сarryingTextBox.Text == "" || numberTextBox.Text == "" || usersIDTextBox.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            Transport trs = new Transport();
            trs.TransortID = Convert.ToInt32(transortIDTextBox.Text);
            trs.Name = nameTextBox.Text;
            trs.Сarrying = сarryingTextBox.Text;
            trs.Number = numberTextBox.Text;
            trs.UsersID = Convert.ToInt32(usersIDTextBox.Text); ;
            DatabaseContext.db.Transport.Add(trs);
            SaveDB();
            MessageBox.Show("Данные сохранены");
        }
    }
}
