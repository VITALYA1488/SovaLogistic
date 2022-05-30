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
    public partial class UsersForm : Form
    {
        public static List<UsersLog> selectedUserCard = new List<UsersLog>();
        public static List<Users> userForm1 = new List<Users>();
        private string search = "";
        public UsersForm()
        {
            InitializeComponent();
            userForm1 = DatabaseContext.db.Users.ToList();
            GetCard(userForm1);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            List<string> typeList = DatabaseContext.db.Users.Select(pt => pt.Role).ToList();
            typeList.Insert(0, "Все типы");
            filteringCB.DataSource = typeList;

            sortingCB.SelectedIndex = 0;
            filteringCB.SelectedIndex = 0;

        }
        private void Card_Click(object sender, EventArgs e)
        {
            UsersLog clie = sender as UsersLog;

            if (clie.BackColor == Color.White)
            {
                clie.BackColor = Color.FromArgb(170, 145, 184);
                selectedUserCard.Add(clie);
            }
            else
            {
                clie.BackColor = Color.White;
                selectedUserCard.Remove(clie);
            }
        }
        public void GetCard(List<Users> users)
        {

            foreach (var a in users)
            {
                UsersLog userCard1 = new UsersLog();
                userCard1.GenerationData(a);
                flowLayoutPanel1.Controls.Add(userCard1);

                userCard1.Click += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e) ///////////////////кнопка редактировать пользователя
        {
            selectedUserCard.Clear();
            UsersLog clie = sender as UsersLog;
            selectedUserCard.Add(clie);
            EditFormUsers editForm = new EditFormUsers();
            DialogResult dialogResult = editForm.ShowDialog();
        }
        private void UpdateOrder()
        {
            List<Users> userLst = DatabaseContext.db.Users.ToList();

            if (search != "")
            {
                search = search.ToLower();

                userLst = userLst.Where(u => u.Name.ToLower().Contains(search)).ToList();
            }

            if (filteringCB.SelectedIndex > 0)
            {
                userLst = userLst.Where(u => u.Role == filteringCB.SelectedItem.ToString()).ToList();
            }

            if (sortingCB.Text == "ID пользователя")
            {
                if (orderBy.Checked)
                {
                    userLst = userLst.OrderBy(x => x.UsersID).ToList();
                }
                else
                {
                    userLst = userLst.OrderByDescending(x => x.UsersID).ToList();
                }
            }
            flowLayoutPanel1.Controls.Clear();
            GetCard(userLst);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EditFormUsers frm = new EditFormUsers();
            //frm.Show();
            //this.Hide();
            //return;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search = searchTextBox.Text;
            UpdateOrder();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sortingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateOrder();
        }

        private void orderBy_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateOrder();
        }

        private void filteringCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateOrder();
        }
    }
}
