using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenGiris : Form
    {
        public FrmOgretmenGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgretmenDetay frm = new FrmOgretmenDetay();
            frm.Show();
            this.Hide();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.Show();
                this.Hide();
                //Metin -değiştiği- '1111' olduğu an da Öğretmen detay sayfasını açıyor.
            }
        }
    }
}
