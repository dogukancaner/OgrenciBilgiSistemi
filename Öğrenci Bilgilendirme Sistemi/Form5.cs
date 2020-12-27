using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Bilgilendirme_Sistemi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label18.Text=comboBox2.Text;
            label19.Text = comboBox1.Text;
            label22.Text = comboBox3.Text;
            label25.Text = comboBox4.Text;
            label24.Text = comboBox5.Text;
            label23.Text = comboBox6.Text;
            label21.Text = comboBox7.Text;
            label20.Text = comboBox8.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 geri = new Form2();
            geri.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
