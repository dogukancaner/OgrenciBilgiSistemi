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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelturkcetrh.Text = dateTimePicker1.Text;
            labelmattrh.Text = dateTimePicker2.Text;
            labelfiziktrh.Text = dateTimePicker3.Text;
            labelkimyatrh.Text = dateTimePicker4.Text;
            labeltarihtrh.Text = dateTimePicker5.Text;
            labeledebiyattrh.Text = dateTimePicker6.Text;
            labelbiyolojitrh.Text = dateTimePicker7.Text;
            labelfelsefetrh.Text = dateTimePicker8.Text;

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
