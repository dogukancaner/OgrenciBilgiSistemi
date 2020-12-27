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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            double turkce, matematik, tarih, fizik, kimya, biyoloji, felsefe, edebiyat;
            double turkce2, matematik2, tarih2, fizik2, kimya2, biyoloji2, edebiyat2, felsefe2;
            double ort;

            int a = rastgele.Next(20, 100);
            int b = rastgele.Next(20, 100);
            int c = rastgele.Next(20, 100);
            int d = rastgele.Next(20, 100);
            int f = rastgele.Next(20, 100);
            int g = rastgele.Next(20, 100);
            int x = rastgele.Next(20, 100);
            int y = rastgele.Next(20, 100);

            labelturkce1.Text = a.ToString();
            labelmat1.Text = b.ToString();
            labeltarih1.Text = c.ToString();
            labelfizik1.Text = d.ToString();
            labelbiyoloji1.Text = f.ToString();
            labelfelsefe1.Text = g.ToString();
            labeledebiyat1.Text = x.ToString();
            labelkimya1.Text = y.ToString();

            int h = rastgele.Next(20, 100);
            int j = rastgele.Next(20, 100);
            int k = rastgele.Next(20, 100);
            int l = rastgele.Next(20, 100);
            int m = rastgele.Next(20, 100);
            int n = rastgele.Next(20, 100);
            int o = rastgele.Next(20, 100);
            int p = rastgele.Next(20, 100);

            labelturkce2.Text = h.ToString();
            labelmat2.Text = j.ToString();
            labeltarih2.Text = k.ToString();
            labelfizik2.Text = l.ToString();
            labelbiyoloji2.Text = m.ToString();
            labelkimya2.Text = n.ToString();
            labeledebiyat2.Text = o.ToString();
            labelfelsefe2.Text = p.ToString();

            turkce = Convert.ToDouble(labelturkce1.Text);
            turkce2 = Convert.ToDouble(labelturkce2.Text);
            ort = (turkce + turkce2) / 2;
            labelturkceort.Text = ort.ToString();
            if (ort > 45)
            {
                labelturkcedrm.Text = "Geçti";
            }
            else
            {
                labelturkcedrm.Text = "Kaldı";
            }

            matematik = Convert.ToDouble(labelmat1.Text);
            matematik2 = Convert.ToDouble(labelmat2.Text);
            ort = (matematik + matematik2) / 2;
            labelmatort.Text = ort.ToString();

            if (ort > 45)
            {
                labelmatdrm.Text = "Geçti";
            }
            else
            {
                labelmatdrm.Text = "Kaldı";
            }

            tarih = Convert.ToDouble(labeltarih1.Text);
            tarih2 = Convert.ToDouble(labeltarih2.Text);
            ort = (tarih + tarih2) / 2;
            labeltarihort.Text = ort.ToString();

            if (ort > 45)
            {
                labeltarihdrm.Text = "Geçti";
            }
            else
            {
                labeltarihdrm.Text = "Kaldı";
            }

            fizik = Convert.ToDouble(labelfizik1.Text);
            fizik2 = Convert.ToDouble(labelfizik2.Text);
            ort = (fizik + fizik2) / 2;
            labelfizikort.Text = ort.ToString();

            if (ort > 45)
            {
                labelfizikdrm.Text = "Geçti";
            }
            else
            {
                labelfizikdrm.Text = "Kaldı";
            }

            kimya = Convert.ToDouble(labelkimya1.Text);
            kimya2 = Convert.ToDouble(labelkimya2.Text);
            ort = (kimya + kimya2) / 2;
            labelkimyaort.Text = ort.ToString();

            if (ort > 45)
            {
                labelkimyadrm.Text = "Geçti";
            }
            else
            {
                labelkimyadrm.Text = "Kaldı";
            }

            biyoloji = Convert.ToDouble(labelbiyoloji1.Text);
            biyoloji2 = Convert.ToDouble(labelbiyoloji2.Text);
            ort = (biyoloji + biyoloji2) / 2;
            labelbiyolojiort.Text = ort.ToString();
            if (ort > 45)
            {
                labelbiyolojidrm.Text = "Geçti";
            }
            else
            {
                labelbiyolojidrm.Text = "Kaldı";
            }

            edebiyat = Convert.ToDouble(labeledebiyat1.Text);
            edebiyat2 = Convert.ToDouble(labeledebiyat2.Text);
            ort = (edebiyat + edebiyat2) / 2;
            labeledbort.Text = ort.ToString();
            if (ort > 45)
            {
                labeledbdrm.Text = "Geçti";
            }
            else
            {
                labeledbdrm.Text = "Kaldı";
            }

            felsefe = Convert.ToDouble(labelfelsefe1.Text);
            felsefe2 = Convert.ToDouble(labelfelsefe2.Text);
            ort = (felsefe + felsefe2) / 2;
            labelfelsefeort.Text = ort.ToString();
            if (ort > 45)
            {
                labelfelsefedrm.Text = "Geçti";
            }
            else
            {
                labelfelsefedrm.Text = "Kaldı";
            }

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
