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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Z580;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From AdminGiris where Kullanici=@p1 AND Sifre=@p2";
                SqlParameter pm1 = new SqlParameter("p1", TxtKullaniciAdi.Text.Trim());
                SqlParameter pm2 = new SqlParameter("p2", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(pm1);
                komut.Parameters.Add(pm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
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
