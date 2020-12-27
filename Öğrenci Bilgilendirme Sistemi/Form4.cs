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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            button5.Enabled = false;
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
