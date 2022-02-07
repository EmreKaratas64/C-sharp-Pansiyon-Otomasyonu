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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Z580;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void BtnHesapla_Click(object sender, EventArgs e)
        {           
            int personel;
            personel = Convert.ToInt16(TxtPersonelSayisi.Text);
            LblPersonelMaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlinanUrunler1.Text) + Convert.ToInt32(LblAlinanUrunler2.Text) + Convert.ToInt32(LblAlinanUrunler3.Text) + Convert.ToInt32(LblFaturalar1.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();

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

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            // Kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Sum(Ucret) as toplam From MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            // Gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Sum(Gida) as toplam1 From Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            // İçecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Sum(icecek) as toplam2 From Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            // Çerezler
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Sum(Cerezler) as toplam3 From Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            // Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(Elektrik) as toplam4 From Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar1.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            // Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Sum(Su) as toplam5 From Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            // internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select Sum(internet) as toplam6 From Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();
        }
    }
}
