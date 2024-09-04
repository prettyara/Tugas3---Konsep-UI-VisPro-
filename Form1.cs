using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3___Konsep_UI__VisPro_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "admin" && textBoxPassword.Text == "12345")
            {
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password Salah");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "12345")
            {
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password Salah");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
