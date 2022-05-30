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
    public partial class TransportsForm : Form
    {
        public static List<TransportsLog> selectedTrsCard = new List<TransportsLog>();
        public static List<Transport> transportForm1 = new List<Transport>();
        private string search = "";
        public TransportsForm()
        {
            InitializeComponent();
            transportForm1 = DatabaseContext.db.Transport.ToList();
            GetCard(transportForm1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void GetCard(List<Transport> transport)
        {

            foreach (var a in transport)
            {
                TransportsLog transportCard = new TransportsLog();
                transportCard.GenerationData1(a);
                flowLayoutPanel1.Controls.Add(transportCard);

                transportCard.Click += new System.EventHandler(this.Card_DoubleClick);
            }
        }
        private void Card_DoubleClick(object sender, EventArgs e) ///////////////////кнопка редактировать клиента 
        {
            selectedTrsCard.Clear();
            TransportsLog cle = sender as TransportsLog;
            selectedTrsCard.Add(cle);
            EditFormTransport editForm = new EditFormTransport();
            DialogResult dialogResult = editForm.ShowDialog();
        }
        private void UpdateOrder()
        {
            List<Transport> trsLst = DatabaseContext.db.Transport.ToList();

            if (search != "")
            {
                search = search.ToLower();

                trsLst = trsLst.Where(u => u.Name.ToLower().Contains(search)).ToList();
            }

            if (sortingCB.Text == "ID транспорта")
            {
                if (orderBy.Checked)
                {
                    trsLst = trsLst.OrderBy(x => x.UsersID).ToList();
                }
                else
                {
                    trsLst = trsLst.OrderByDescending(x => x.UsersID).ToList();
                }
            }
            flowLayoutPanel1.Controls.Clear();
            GetCard(trsLst);
        }
        private void TransportsForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var a in transportForm1)
            {
                TransportsLog userCard2 = new TransportsLog();
                userCard2.GenerationData1(a);
                flowLayoutPanel1.Controls.Add(userCard2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditFormTransport frm = new EditFormTransport();
            frm.Show();
            this.Hide();
            return;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search = searchTextBox.Text;
            UpdateOrder();
        }

        private void orderBy_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateOrder();
        }

        private void sortingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateOrder();
        }
    }
}
