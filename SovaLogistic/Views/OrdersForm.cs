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
    public partial class OrdersForm : Form
    {
        public static List<Order> orderForm1 = new List<Order>();
        public OrdersForm()
        {
            InitializeComponent();
            orderForm1 = DatabaseContext.db.Order.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var a in orderForm1)
            {
                OrdersLog userCard3 = new OrdersLog();
                userCard3.GenerationData2(a);
                flowLayoutPanel1.Controls.Add(userCard3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditFormOrder frm = new EditFormOrder();
            frm.Show();
            this.Hide();
            return;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //search = searchTextBox.Text;
            //UpdateOrder();
        }

        private void filteringCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
