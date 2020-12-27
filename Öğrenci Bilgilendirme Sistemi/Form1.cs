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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text=="1234567891011" && maskedTextBox2.Text=="12345678")
            {
                MessageBox.Show("Giriş Başarılı.");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Tekrar Deneyiniz.");
            }
            Form2 anamenu = new Form2();
            anamenu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
