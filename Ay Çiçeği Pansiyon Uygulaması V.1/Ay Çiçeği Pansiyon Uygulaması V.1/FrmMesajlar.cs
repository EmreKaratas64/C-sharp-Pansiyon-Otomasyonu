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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Z580;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("inset into Mesajlar (Adsoyad,Mesaj) values(@p1,@p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", richTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Mesaj sisteme başarıyla kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
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
