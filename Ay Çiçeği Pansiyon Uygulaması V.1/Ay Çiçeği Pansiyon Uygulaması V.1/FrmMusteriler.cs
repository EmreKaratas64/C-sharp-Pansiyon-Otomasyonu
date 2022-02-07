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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmbCinsiyet.Text = "";
            MskTelefon.Clear();
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtkGirisTarihi.Text = "";
            DtkCikisTarihi.Text = "";
            TxtAdi.Focus();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Z580;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtkGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtkCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(TxtOdaNo.Text=="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda101 where Adi=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda102 where Adi=@p2", baglanti);
                komut.Parameters.AddWithValue("@p2", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda103 where Adi=@p3", baglanti);
                komut.Parameters.AddWithValue("@p3", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda104 where Adi=@p4", baglanti);
                komut.Parameters.AddWithValue("@p4", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda105 where Adi=@p5", baglanti);
                komut.Parameters.AddWithValue("@p5", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda106 where Adi=@p6", baglanti);
                komut.Parameters.AddWithValue("@p6", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda107 where Adi=@p7", baglanti);
                komut.Parameters.AddWithValue("@p7", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda108 where Adi=@p8", baglanti);
                komut.Parameters.AddWithValue("@p8", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Oda109 where Adi=@p9", baglanti);
                komut.Parameters.AddWithValue("@p9", TxtAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Müşterinin bulunmuş olduğu oda boşaltılmıştır");
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update MusteriEkle set Adi=@p1,Soyadi=@p2,Cinsiyet=@p3,Telefon=@p4,Mail=@p5,TC=@p6,OdaNO=@p7,Ucret=@p8,GirisTarihi=@p9,CikisTarihi=@p10 where Musteriid=@p11", baglanti);
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
            komut.Parameters.AddWithValue("@p11", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            MessageBox.Show("Müşteri kaydı başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From MusteriEkle where Adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
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
// SqlCommand komut = new SqlCommand("Delete From MusteriEkle where Musteriid=@p1", baglanti);