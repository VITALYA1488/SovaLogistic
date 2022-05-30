using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SovaLogistic.Models;
using SovaLogistic.Utils;
using SovaLogistic.Views;
using SovaLogistic.Views.PartialViews;

namespace SovaLogistic.Views
{
    public partial class ClientsForm : Form
    {
        public static List<Client> clientForm1 = new List<Client>();
        public ClientsForm()
        {
            InitializeComponent();
            clientForm1 = DatabaseContext.db.Client.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var a in clientForm1)
            {
                ClientsLog userCard4 = new ClientsLog();
                userCard4.GenerationData3(a);
                flowLayoutPanel1.Controls.Add(userCard4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditFormClients frm = new EditFormClients();
            frm.Show();
            this.Hide();
            return;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //search = searchTextBox.Text;
            //UpdateOrder();
        }
    }
}
