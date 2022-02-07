using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Z580;Initial Catalog=AycicegiPansiyon;Integrated Security=True");


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update AdminGiris set Kullanici=@p1,Sifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Şifreniz başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
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
    }
}
