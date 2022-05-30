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
    public partial class EditFormUsers : Form
    {

        Users user = new Users();
        public EditFormUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка перехода на главную форму
        {
            MainForm f = new MainForm();
            this.Close();
            return;
        }

        private void AddFormUsers_Load(object sender, EventArgs e)
        {
            foreach (UsersLog userCard in MainForm.selectedUserCard)
            {
                user = DatabaseContext.db.Users.First(x => "ID пользователя: " + x.UsersID.ToString() == userCard.UsersIDLB.Text.ToString());
                usersBindingSource.DataSource = user;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) ///////////////////кнопка редактирования данных
        {
            if ( nameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            user.Role = roleTextBox.Text;
            user.Name = nameTextBox.Text;
            user.Phone = phoneTextBox.Text;
            user.Birthday = Convert.ToDateTime(birthdayDateTimePicker.Text);
            SaveDB();
            MessageBox.Show("Данные сохранены");
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) ///////////////////кнопка удаления данных
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить " + user.Name + "?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                DatabaseContext.db.Users.Remove(user);
                SaveDB();
                DialogResult = DialogResult.OK;
            }
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
    }
}
