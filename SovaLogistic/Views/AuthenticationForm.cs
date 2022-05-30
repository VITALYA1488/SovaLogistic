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
using SovaLogistic.Views;
using SovaLogistic.Utils;

namespace SovaLogistic
{
    public partial class AuthenticationForm : Form
    {
        public static AuthenticationForm FORMA { get; set; }
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordtb.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e) ///////////////////кнопка входа в систему
        {
            if(logintb.Text == "" || passwordtb.Text == "")
            {
                return;
            }
            Login log = DatabaseContext.db.Login.FirstOrDefault(x => x.Login1.ToUpper() == logintb.Text.ToUpper());
            if ((log != null) && (log.Password == passwordtb.Text))
            {
                MainForm f = new MainForm();
                f.user = log.Users;
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e) ///////////////////кнопка выхода из системы
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (passwordtb.UseSystemPasswordChar == false)
                passwordtb.UseSystemPasswordChar = true;
            else
            {
                passwordtb.UseSystemPasswordChar = false;
            }
        }
    }
}
