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
    public partial class EditFormTransport : Form
    {
        Transport trs = new Transport();
        public EditFormTransport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка перехода на главную форму
        {
            MainForm f = new MainForm();
            this.Close();
            return;
        }

        private void AddFormTransport_Load(object sender, EventArgs e)
        {
            foreach (TransportsLog trsCard in MainForm.selectedTransportCard)
            {
                trs = DatabaseContext.db.Transport.First(x => "ID транспорта: " + x.TransortID.ToString() == trsCard.TransportIDLB.Text.ToString());
                transportBindingSource.DataSource = trs;
            }
        }

        private void button1_Click(object sender, EventArgs e) ///////////////////кнопка редактирования данных
        {
            if ( nameTextBox.Text == "" || сarryingTextBox.Text == "" || numberTextBox.Text == "" || usersIDTextBox.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            Transport usr = new Transport();
            usr.Name = nameTextBox.Text;
            usr.Сarrying = сarryingTextBox.Text;
            usr.Number = numberTextBox.Text;
            usr.UsersID = Convert.ToInt32(usersIDTextBox.Text); ;
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
        private void deleteBT_Click(object sender, EventArgs e) ///////////////////кнопка удаления данных
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить " + trs.Name + "?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DatabaseContext.db.Transport.Remove(trs);
                SaveDB();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
