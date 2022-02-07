using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Black;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr = new FrmSifreGuncelle();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Murat Yücedağ kanalından esinlenerek yapılmıştır 2021");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }
    }
}
