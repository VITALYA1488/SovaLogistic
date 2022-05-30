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
    public partial class TransportsLog : UserControl
    {
        public TransportsLog()
        {
            InitializeComponent();
        }
        public void GenerationData1(Transport trans1)
        {

            TransportIDLB.Text = "ID транспорта: " + trans1.TransortID;
            TransNameLB.Text = "Название транспорта: " + trans1.Name;
            TransNumberLB.Text = "Номер транспорта: " + trans1.Number;
            CarryingLB.Text = "Грузоподъемность: " + trans1.Сarrying;
            UsersIDLB.Text = "ID перевозчика: " + trans1.UsersID;
        }

        private void TransportsLog_Load(object sender, EventArgs e)
        {

        }
    }
}
