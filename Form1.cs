﻿using System;
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
    }
}
