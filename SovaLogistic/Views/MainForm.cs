using SovaLogistic.Models;
using SovaLogistic.Utils;
using SovaLogistic.Views.PartialViews;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SovaLogistic.Views.AddForm;

namespace SovaLogistic.Views
{
    public partial class MainForm : Form
    {
        public Users user { get; set; }
        public static List<Users> usr = new List<Users>();
        public static List<UsersLog> selectedUserCard = new List<UsersLog>();
        public static List<Order> ord = new List<Order>();
        public static List<OrdersLog> selectedOrderCard = new List<OrdersLog>();
        public static List<Transport> trs = new List<Transport>();
        public static List<TransportsLog> selectedTransportCard = new List<TransportsLog>();
        public static List<Client> cln = new List<Client>();
        public static List<ClientsLog> selectedClientCard = new List<ClientsLog>();
        public MainForm()
        {
            InitializeComponent();
            usr = DatabaseContext.db.Users.ToList();
            GetCard(usr);
            trs = DatabaseContext.db.Transport.ToList();
            GetCard(trs);
            ord = DatabaseContext.db.Order.ToList();
            GetCard(ord);
            cln = DatabaseContext.db.Client.ToList();
            GetCard(cln);
        }

        private void label1_Click(object sender, EventArgs e)
        {

            userLB.BackColor = Color.LightBlue;
            transLB.BackColor = Color.White;
            clientLB.BackColor = Color.White;
            orderLB.BackColor = Color.White;
            flowLayoutPanel1.Controls.Clear();
            GetCard(usr);
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
        private void Card_DoubleClick(object sender, EventArgs e) ///////////////////нажатие для перехода на форму редактирования пользователя
        {
            selectedUserCard.Clear();
            UsersLog clie = sender as UsersLog;
            selectedUserCard.Add(clie);
            EditFormUsers editForm = new EditFormUsers();
            DialogResult dialogResult = editForm.ShowDialog();
        }
        public void GetCard(List<Transport> transports)
        {

            foreach (var b in transports)
            {
                TransportsLog userCard2 = new TransportsLog();
                userCard2.GenerationData1(b);
                flowLayoutPanel1.Controls.Add(userCard2);

                userCard2.Click += new System.EventHandler(this.Card_DoubleClickTransport);
            }
        }
        private void Card_DoubleClickTransport(object sender, EventArgs e) ///////////////////нажатие для перехода на форму редактирования транспорта
        {
            selectedTransportCard.Clear();
            TransportsLog clie = sender as TransportsLog;
            selectedTransportCard.Add(clie);
            EditFormTransport editForm = new EditFormTransport();
            DialogResult dialogResult = editForm.ShowDialog();
        }
        public void GetCard(List<Order> order)
        {

            foreach (var c in order)
            {
                OrdersLog userCard3 = new OrdersLog();
                userCard3.GenerationData2(c);
                flowLayoutPanel1.Controls.Add(userCard3);

                userCard3.Click += new System.EventHandler(this.Card_DoubleClickOrder);
            }
        }
        private void Card_DoubleClickOrder(object sender, EventArgs e) ///////////////////нажатие для перехода на форму редактирования заказа
        {
            selectedOrderCard.Clear();
            OrdersLog clie = sender as OrdersLog;
            selectedOrderCard.Add(clie);
            EditFormOrder editForm = new EditFormOrder();
            DialogResult dialogResult = editForm.ShowDialog();
        }
        public void GetCard(List<Client> client)
        {

            foreach (var d in client)
            {
                ClientsLog userCard4 = new ClientsLog();
                userCard4.GenerationData3(d);
                flowLayoutPanel1.Controls.Add(userCard4);

                userCard4.Click += new System.EventHandler(this.Card_DoubleClickClient);
            }
        }
        private void Card_DoubleClickClient(object sender, EventArgs e) ///////////////////нажатие для перехода на форму редактирования клиента
        {
            selectedClientCard.Clear();
            ClientsLog clie = sender as ClientsLog;
            selectedClientCard.Add(clie);
            EditFormClients editForm = new EditFormClients();
            DialogResult dialogResult = editForm.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if(user.Role == "Администратор")
            {
                addBT.Visible = true;
            }
            if (user.Role == "Менеджер")
            {
                userLB.Visible = false;
                pictureBoxUser.Visible = false;
                addBT.Visible = true;
            }
            if (user.Role == "Перевозчик")
            {
                userLB.Visible = false;
                pictureBoxUser.Visible = false;
                addBT.Visible = false;
                clientLB.Visible = false;
                pictureBoxClient.Visible = false;
                transLB.Visible = false;
                pictureBoxTransport.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка выхода из системы
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            userLB.BackColor = Color.White;
            transLB.BackColor = Color.LightBlue;
            clientLB.BackColor = Color.White;
            orderLB.BackColor = Color.White;
            flowLayoutPanel1.Controls.Clear();
            GetCard(trs);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userLB.BackColor = Color.White;
            transLB.BackColor = Color.White;
            clientLB.BackColor = Color.LightBlue;
            orderLB.BackColor = Color.White;
            flowLayoutPanel1.Controls.Clear();
            GetCard(cln);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            userLB.BackColor = Color.White;
            transLB.BackColor = Color.White;
            clientLB.BackColor = Color.White;
            orderLB.BackColor = Color.LightBlue;
            flowLayoutPanel1.Controls.Clear();
            GetCard(ord);
        }

        private void button1_Click(object sender, EventArgs e) ///////////////////кнопка добавления
        {
            if (userLB.BackColor == Color.LightBlue)
            {
                AddFormUsers frm = new AddFormUsers();
                frm.Show();
                frm.Text = "Добавление пользователя";
                return;
            }
            else if (transLB.BackColor == Color.LightBlue)
            {
                AddFormTransport frm = new AddFormTransport();
                frm.Show();
                frm.Text = "Добавление транспорта";
                return;
            }
            else if (clientLB.BackColor == Color.LightBlue)
            {
                AddFormClients frm = new AddFormClients();
                frm.Show();
                frm.Text = "Добавление клиента";
                return;
            }
            else if (orderLB.BackColor == Color.LightBlue)
            {
                AddFormOrder frm = new AddFormOrder();
                frm.Show();
                frm.Text = "Добавление заказа";
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if(userLB.BackColor == Color.LightBlue)
            {
                UpdateOrder(usr);
            }
            if (transLB.BackColor == Color.LightBlue)
            {
                UpdateOrder(trs);
            }
            if (orderLB.BackColor == Color.LightBlue)
            {
                UpdateOrder(usr);
            }
            if (clientLB.BackColor == Color.LightBlue)
            {
                UpdateOrder(usr);
            }
        }

        private void sortingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateOrder(usr);
        }

        private void orderBy_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateOrder(usr);
        }
        private void UpdateOrder(List<Users> users)
        {
            if (searchTextBox.Text != "")
            {
                users = users.Where(user => user.Name.ToLower().Contains(searchTextBox.Text.ToLower()) ||
                    user.Phone.ToString().Contains(searchTextBox.Text) || user.Role.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            }

            if (sortingCB.Text == "ID пользователя")
            {
                users = users.OrderBy(user => user.UsersID).ToList();
                if (orderBy.Checked)
                {
                    users = users.OrderByDescending(user => user.UsersID).ToList();
                }
            }
            else if(sortingCB.Text == "ФИО")
            {
                users = users.OrderBy(user => user.Name).ToList();
                if (orderBy.Checked)
                {
                    users = users.OrderByDescending(user => user.Name).ToList();
                }
            }
            else if (sortingCB.Text == "Дата рождения")
            {
                users = users.OrderBy(user => user.Birthday).ToList();
                if (orderBy.Checked)
                {
                    users = users.OrderByDescending(user => user.Birthday).ToList();
                }
            }
            flowLayoutPanel1.Controls.Clear();
            GetCard(users);
        }
        private void UpdateOrder(List<Transport> trans)
        {
            if (searchTextBox.Text != "")
            {
                trans = trans.Where(trn => trn.Name.ToLower().Contains(searchTextBox.Text.ToLower()) ||
                    trn.Number.ToString().Contains(searchTextBox.Text) || trn.Сarrying.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            }

            //if (sortingCB.Text == "ID пользователя")
            //{
            //    trans = trans.OrderBy(user => user.UsersID).ToList();
            //    if (orderBy.Checked)
            //    {
            //        trans = trans.OrderByDescending(trn => trn.UsersID).ToList();
            //    }
            //}
            //else if (sortingCB.Text == "ФИО")
            //{
            //    trans = trans.OrderBy(trn => trn.Name).ToList();
            //    if (orderBy.Checked)
            //    {
            //        trans = trans.OrderByDescending(trn => trn.Name).ToList();
            //    }
            //}
            //else if (sortingCB.Text == "Дата рождения")
            //{
            //    trans = trans.OrderBy(trn => trn.Birthday).ToList();
            //    if (orderBy.Checked)
            //    {
            //        trans = trans.OrderByDescending(trn => trn.Birthday).ToList();
            //    }
            //}
            //flowLayoutPanel1.Controls.Clear();
            //GetCard(users);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //private void UpdateOrder(List<Order> orders)
        //{
        //    if (searchTextBox.Text != "")
        //    {
        //        users = users.Where(user => user.Name.ToLower().Contains(searchTextBox.Text.ToLower()) ||
        //            user.Phone.ToString().Contains(searchTextBox.Text) || user.Role.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
        //    }

        //    if (sortingCB.Text == "ID пользователя")
        //    {
        //        users = users.OrderBy(user => user.UsersID).ToList();
        //        if (orderBy.Checked)
        //        {
        //            users = users.OrderByDescending(user => user.UsersID).ToList();
        //        }
        //    }
        //    else if (sortingCB.Text == "ФИО")
        //    {
        //        users = users.OrderBy(user => user.Name).ToList();
        //        if (orderBy.Checked)
        //        {
        //            users = users.OrderByDescending(user => user.Name).ToList();
        //        }
        //    }
        //    else if (sortingCB.Text == "Дата рождения")
        //    {
        //        users = users.OrderBy(user => user.Birthday).ToList();
        //        if (orderBy.Checked)
        //        {
        //            users = users.OrderByDescending(user => user.Birthday).ToList();
        //        }
        //    }
        //    flowLayoutPanel1.Controls.Clear();
        //    GetCard(users);
        //}
        //private void UpdateOrder(List<Client> clients)
        //{
        //    if (searchTextBox.Text != "")
        //    {
        //        users = users.Where(user => user.Name.ToLower().Contains(searchTextBox.Text.ToLower()) ||
        //            user.Phone.ToString().Contains(searchTextBox.Text) || user.Role.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
        //    }

        //    if (sortingCB.Text == "ID пользователя")
        //    {
        //        users = users.OrderBy(user => user.UsersID).ToList();
        //        if (orderBy.Checked)
        //        {
        //            users = users.OrderByDescending(user => user.UsersID).ToList();
        //        }
        //    }
        //    else if (sortingCB.Text == "ФИО")
        //    {
        //        users = users.OrderBy(user => user.Name).ToList();
        //        if (orderBy.Checked)
        //        {
        //            users = users.OrderByDescending(user => user.Name).ToList();
        //        }
        //    }
        //    else if (sortingCB.Text == "Дата рождения")
        //    {
        //        users = users.OrderBy(user => user.Birthday).ToList();
        //        if (orderBy.Checked)
        //        {
        //            users = users.OrderByDescending(user => user.Birthday).ToList();
        //        }
        //    }
        //    flowLayoutPanel1.Controls.Clear();
        //    GetCard(users);
        //}
    }
}
