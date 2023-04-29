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
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PV2GBD4;Initial Catalog=""Not Kayıt Sistemi"";Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'not_Kayıt_SistemiDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.not_Kayıt_SistemiDataSet.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)",baglanti);
            komut.Parameters.AddWithValue("@p1",MskNumara.Text);
            komut.Parameters.AddWithValue("@p2",TxtAd.Text);
            komut.Parameters.AddWithValue("@p3",TxtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            //Bağlantıyı açıp tabloya ekleyeceğimiz verileri p1,p2,p3 parametlerinden aldığımız verileri koyuyoruz.
            //Parametredeki verileri ise Öğretmen sayfasından aldığımız verilere eşitliyoruz.
            this.tBLDERSTableAdapter.Fill(this.not_Kayıt_SistemiDataSet.TBLDERS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            //Tablodaki tıklanan hücredeki değerleri belirtilenen yerlere yazdırılır.
        }

        private void BtnnKaydet_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;

            s1 = Convert.ToDouble(TxtS1.Text);
            s2 = Convert.ToDouble(TxtS2.Text);
            s3 = Convert.ToDouble(TxtS3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            LblOrt.Text = ortalama.ToString();

            if(ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }



            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set  OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,OGRORTALAMA=@p4,DURUM=@p5 where  OGRNUMARA=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtS1.Text);
            komut.Parameters.AddWithValue("@p2", TxtS2.Text);
            komut.Parameters.AddWithValue("@p3", TxtS3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(LblOrt.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            this.tBLDERSTableAdapter.Fill(this.not_Kayıt_SistemiDataSet.TBLDERS);

           
        }
    }
}
