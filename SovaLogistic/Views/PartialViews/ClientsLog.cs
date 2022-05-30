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

namespace SovaLogistic.Views.PartialViews
{
    public partial class ClientsLog : UserControl
    {
        public ClientsLog()
        {
            InitializeComponent();
        }

        private void ClientsLog_Load(object sender, EventArgs e)
        {

        }
        public void GenerationData3(Client client1)
        {
            DateTime dateF;
            dateF = (DateTime)client1.Birthday;
            ClientIDLB.Text = "ID клиента: " + client1.ClientID;
            ClientFioLB.Text = "ФИО: " + client1.Name;
            ClientBirthdayLB.Text = "Дата рождения: " + dateF.Year + "." + dateF.Month + "." + dateF.Day;
            ClientPhoneLB.Text = "Телефон: " + client1.Phone;

        }
    }
}
