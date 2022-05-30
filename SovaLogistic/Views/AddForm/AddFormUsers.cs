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
    public partial class AddFormUsers : Form
    {
        Users user = new Users();
        public AddFormUsers()
        {
            InitializeComponent();
        }

        private void AddFormUsers_Load(object sender, EventArgs e)
        {

                usersBindingSource.DataSource = user;

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
            if (usersIDTextBox.Text == "" || nameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }


            user.Role = roleTextBox.Text;
            user.UsersID = Convert.ToInt32(usersIDTextBox.Text);
            user.Name = nameTextBox.Text;
            user.Phone = phoneTextBox.Text;
            user.Birthday = Convert.ToDateTime(birthdayDateTimePicker.Text);

            DatabaseContext.db.Users.Add(user);
            SaveDB();
            MessageBox.Show("Данные сохранены");
        }
    }
}
