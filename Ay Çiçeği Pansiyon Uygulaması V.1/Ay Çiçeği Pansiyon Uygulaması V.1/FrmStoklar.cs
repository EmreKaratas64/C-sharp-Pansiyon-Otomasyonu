using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Z580;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void veriler2()
        {
            listView3.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["internet"].ToString());
                listView3.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,icecek,cerezler) Values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtGidalar.Text);
            komut.Parameters.AddWithValue("@p2", Txticecekler.Text);
            komut.Parameters.AddWithValue("@p3", TxtAtistirmaliklar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
            MessageBox.Show("Veriler başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Black;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar (Elektrik,Su,internet) Values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
            komut.Parameters.AddWithValue("@p2", TxtSu.Text);
            komut.Parameters.AddWithValue("@p3", Txtinternet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
            MessageBox.Show("Veriler başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
