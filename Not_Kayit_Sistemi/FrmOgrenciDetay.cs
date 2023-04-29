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

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PV2GBD4;Initial Catalog=""Not Kayıt Sistemi"";Integrated Security=True");
        
        private void Form2_Load(object sender, EventArgs e)
        {
          /*  double ortalama, s1, s2, s3;

            s1 = Convert.ToDouble(Lblsinav1.Text);
            s2 = Convert.ToDouble(Lblsinav2.Text);
            s3 = Convert.ToDouble(Lblsinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            Lblortalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                Lbldurum.Text = "Geçti";
            }
            else
            {
                Lbldurum.Text = "Kaldı";
            }
          */

            Lblnumara.Text= numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            //OGRNUMARA'yı p1 den alıp, p1 değerini de numaradan almasını sağladık.
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lbladsoyad.Text =dr[2].ToString() + " " + dr[3].ToString();
                Lblsinav1.Text = dr[4].ToString();
                Lblsinav2.Text = dr[5].ToString();
                Lblsinav3.Text = dr[6].ToString();
                Lblortalama.Text = dr[7].ToString();
                Lbldurum.Text = dr[8].ToString();
            }
            //dr komutu datadaki verileri okuduğu süreçte belirlenen verileri geldiği zaman yazdır.
            baglanti.Close();
        }

       

       

        

        

       

       
    }
}
