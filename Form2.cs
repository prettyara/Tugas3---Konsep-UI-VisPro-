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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Ganti Form3 dengan form yang ingin Anda buka
            form3.Show();
            this.Hide(); // Menyembunyikan Form2
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Ganti Form1 dengan form login Anda
            form1.Show();
            this.Hide(); // Menyembunyikan Form2
        }
    }
}
