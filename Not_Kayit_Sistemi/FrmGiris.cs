﻿using System;
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
    public partial class FrmOgrGiris : Form
    {
        public FrmOgrGiris()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            FrmOgrenciDetay frm= new FrmOgrenciDetay();
            frm.numara=maskedTextBox1.Text;
            frm.Show();
            this.Hide();
            //FrmOgrenciDetay adında nesne oluşturup formlar arası geçiş sağladım.
        }


    }
}
