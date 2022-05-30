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
    public partial class OrdersLog : UserControl
    {
        public OrdersLog()
        {
            InitializeComponent();
        }

        private void OrdersLog_Load(object sender, EventArgs e)
        {

        }
        public void GenerationData2(Order order1)
        {
            DateTime dateF;
            dateF = (DateTime)order1.DateRegistration;
            dateF = (DateTime)order1.DateArrival;
            OrderIDLB.Text = "ID заказа: " + order1.OrderID;
            OrderNameLB.Text = "Наименование: " + order1.Name;
            OrderDateRegistrLB.Text = "Дата регистрации заказа: " + dateF.Year + "." + dateF.Month + "." + dateF.Day;
            OrderPlaceDepartureLB.Text = "Место отбытия: " + order1.PlaceDeparture;
            OrderPlaceArrivalLB.Text = "Место прибытия: " + order1.PlaceArrival;
            OrderDateArrivalLB.Text = "Дата прибытия: " + dateF.Year + "." + dateF.Month + "." + dateF.Day;
            OrderUsersIDLB.Text = "ID перевозчика: " + order1.UsersID;
            OrderClientIDLB.Text = "ID клиента: " + order1.ClientID;
            OrderTransportIDLB.Text = "ID транспорта: " + order1.TransportID;

        }
    }
}
