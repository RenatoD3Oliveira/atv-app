using sitenovo.view.banco_de_dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitenovo
{
    public partial class conta : Form
    {
        public conta()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //login login = new login();
            //login.Show();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Password = password.Text;

            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Insira o nome de usuario");
                if (string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Insira a senha");
                }
            }
            if (Password == "admin")
            {
                //shop shop = new shop();
                //shop.Show();
                //MinimizeBox = true;
                SHOP SHOP = new SHOP();
                SHOP.Show();

            }
            else
            {
                MessageBox.Show("A senha nao coincide com o login");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpa
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}