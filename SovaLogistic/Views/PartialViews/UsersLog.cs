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
    public partial class UsersLog : UserControl
    {
        //ModelLogistic db = new ModelLogistic();
        public UsersLog()
        {
            InitializeComponent();
        }
        public void GenerationData(Users user1)
        {
            DateTime dateF;
            dateF = (DateTime)user1.Birthday;
            UsersIDLB.Text = "ID пользователя: " + user1.UsersID;
            RoleLB.Text = "Роль: " + user1.Role;
            FioLB.Text = "ФИО: " + user1.Name;
            BirthdayLB.Text = "Дата рождения: " + dateF.Year+"." + dateF.Month+"." + dateF.Day;
            phoneLB.Text =  "Номер телефона" + user1.Phone;
            
        }

        private void UsersLog_Load(object sender, EventArgs e)
        {

        }

        private void PhoneLB_Click(object sender, EventArgs e)
        {

        }
    }

}
