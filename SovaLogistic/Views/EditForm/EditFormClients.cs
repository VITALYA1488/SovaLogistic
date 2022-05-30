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
    public partial class EditFormClients : Form
    {
        Client cln = new Client();
        public EditFormClients()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка перехода на главную форму
        {
            MainForm f = new MainForm();
            this.Close();
            return;
        }

        private void AddFormClients_Load(object sender, EventArgs e)
        {
            foreach (ClientsLog clnCard in MainForm.selectedClientCard)
            {
                cln = DatabaseContext.db.Client.First(x => "ID клиента: " + x.ClientID.ToString() == clnCard.ClientIDLB.Text.ToString());
                clientBindingSource.DataSource = cln;
            }
        }

        private void button1_Click(object sender, EventArgs e) ///////////////////кнопка редактирования данных
        {
            if (nameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            cln.Name = nameTextBox.Text;
            cln.Phone = phoneTextBox.Text;
            cln.Birthday = birthdayDateTimePicker.Value;
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

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deleteBT_Click(object sender, EventArgs e) ///////////////////кнопка удаления данных
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить " + cln.Name + "?",
"Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DatabaseContext.db.Client.Remove(cln);
                SaveDB();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
