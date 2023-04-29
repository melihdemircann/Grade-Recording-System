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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrGiris frm = new FrmOgrGiris();
            frm.Show();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris frm = new FrmOgretmenGiris();
            frm.Show();
        }
    }
}
