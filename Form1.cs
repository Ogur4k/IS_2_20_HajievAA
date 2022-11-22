using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppBarber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        Form NowForm;
        void ChangeWin(Form changer)
        {
            NowForm = changer;
            if (NowForm == null)
            {
                NowForm.Close();
            }
            changer.TopLevel = false;
            changer.FormBorderStyle = FormBorderStyle.None;
            changer.Dock = DockStyle.Fill;
            panel4.Controls.Add(changer);
            panel4.Tag = changer;
            changer.BringToFront();
            changer.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Size = new System.Drawing.Size(20, 20);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Auth1 authto = new Auth1();
            //Вызов формы в режиме диалога
            authto.ShowDialog();
            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if (Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
                //Вытаскиваем из класса поля в label'ы
                label2.Text = "Зравствуйте,"+Auth.auth_fio;
                label4.Text = "Должность: "+Auth.auth_post;
            }
            //иначе
            else
            {
                //Закрываем форму
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Size = new System.Drawing.Size(20,20);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeTimePicker()
        {
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Enabled = true;
            label3.Text += DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeWin(new Making_an_order());
            }
            catch (ObjectDisposedException mes)
            {
                MessageBox.Show($"{mes.Message} ");
            }
            
        }
    }
}
