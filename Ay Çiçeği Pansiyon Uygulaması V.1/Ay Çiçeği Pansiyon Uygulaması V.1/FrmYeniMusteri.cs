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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Z580;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda101.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda102.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda103.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda104.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda105.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda106.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda107.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda108.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = BtnOda109.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı kutucuklar dolu odaları gösterir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil kutucuklar boş odaları gösterir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DtkCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtkGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtkCikisTarihi.Text);

            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;

            label12.Text = sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label12.Text) * 50;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", TxtKimlikNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@p8", TxtUcret.Text);
            komut.Parameters.AddWithValue("@p9", DtkGirisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@p10", DtkCikisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşter kaydı yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * From Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * From Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * From Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * From Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * From Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Black;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }
    }
}
