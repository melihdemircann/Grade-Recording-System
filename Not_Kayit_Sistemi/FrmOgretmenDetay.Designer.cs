namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskNumara = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtS1 = new System.Windows.Forms.TextBox();
            this.TxtS3 = new System.Windows.Forms.TextBox();
            this.TxtS2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblOrt = new System.Windows.Forms.Label();
            this.LblGS = new System.Windows.Forms.Label();
            this.LblKS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.not_Kayıt_SistemiDataSet = new Not_Kayit_Sistemi.Not_Kayıt_SistemiDataSet();
            this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDERSTableAdapter = new Not_Kayit_Sistemi.Not_Kayıt_SistemiDataSetTableAdapters.TBLDERSTableAdapter();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRORTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnnOgrKaydet = new System.Windows.Forms.Button();
            this.BtnnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_Kayıt_SistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnnOgrKaydet);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.MskNumara);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(292, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(115, 161);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(150, 30);
            this.TxtSoyad.TabIndex = 3;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(115, 113);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(150, 30);
            this.TxtAd.TabIndex = 2;
            // 
            // MskNumara
            // 
            this.MskNumara.Location = new System.Drawing.Point(115, 60);
            this.MskNumara.Mask = "0000";
            this.MskNumara.Name = "MskNumara";
            this.MskNumara.Size = new System.Drawing.Size(150, 30);
            this.MskNumara.TabIndex = 1;
            this.MskNumara.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numara:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnnKaydet);
            this.groupBox2.Controls.Add(this.TxtS1);
            this.groupBox2.Controls.Add(this.TxtS3);
            this.groupBox2.Controls.Add(this.TxtS2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(380, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(292, 275);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // TxtS1
            // 
            this.TxtS1.Location = new System.Drawing.Point(110, 60);
            this.TxtS1.Name = "TxtS1";
            this.TxtS1.Size = new System.Drawing.Size(124, 30);
            this.TxtS1.TabIndex = 3;
            // 
            // TxtS3
            // 
            this.TxtS3.Location = new System.Drawing.Point(110, 170);
            this.TxtS3.Name = "TxtS3";
            this.TxtS3.Size = new System.Drawing.Size(124, 30);
            this.TxtS3.TabIndex = 3;
            // 
            // TxtS2
            // 
            this.TxtS2.Location = new System.Drawing.Point(110, 113);
            this.TxtS2.Name = "TxtS2";
            this.TxtS2.Size = new System.Drawing.Size(124, 30);
            this.TxtS2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "3. Sınav:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "2. Sınav:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "1. Sınav:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblOrt);
            this.groupBox3.Controls.Add(this.LblGS);
            this.groupBox3.Controls.Add(this.LblKS);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(724, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(292, 275);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Ekle";
            // 
            // LblOrt
            // 
            this.LblOrt.AutoSize = true;
            this.LblOrt.Location = new System.Drawing.Point(153, 66);
            this.LblOrt.Name = "LblOrt";
            this.LblOrt.Size = new System.Drawing.Size(34, 24);
            this.LblOrt.TabIndex = 4;
            this.LblOrt.Text = "00";
            // 
            // LblGS
            // 
            this.LblGS.AutoSize = true;
            this.LblGS.Location = new System.Drawing.Point(153, 119);
            this.LblGS.Name = "LblGS";
            this.LblGS.Size = new System.Drawing.Size(34, 24);
            this.LblGS.TabIndex = 5;
            this.LblGS.Text = "00";
            // 
            // LblKS
            // 
            this.LblKS.AutoSize = true;
            this.LblKS.Location = new System.Drawing.Point(153, 173);
            this.LblKS.Name = "LblKS";
            this.LblKS.Size = new System.Drawing.Size(34, 24);
            this.LblKS.TabIndex = 6;
            this.LblKS.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(34, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(982, 253);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oGRORTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLDERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // not_Kayıt_SistemiDataSet
            // 
            this.not_Kayıt_SistemiDataSet.DataSetName = "Not_Kayıt_SistemiDataSet";
            this.not_Kayıt_SistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDERSBindingSource
            // 
            this.tBLDERSBindingSource.DataMember = "TBLDERS";
            this.tBLDERSBindingSource.DataSource = this.not_Kayıt_SistemiDataSet;
            // 
            // tBLDERSTableAdapter
            // 
            this.tBLDERSTableAdapter.ClearBeforeFill = true;
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            // 
            // oGRORTALAMADataGridViewTextBoxColumn
            // 
            this.oGRORTALAMADataGridViewTextBoxColumn.DataPropertyName = "OGRORTALAMA";
            this.oGRORTALAMADataGridViewTextBoxColumn.HeaderText = "OGRORTALAMA";
            this.oGRORTALAMADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRORTALAMADataGridViewTextBoxColumn.Name = "oGRORTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // BtnnOgrKaydet
            // 
            this.BtnnOgrKaydet.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnnOgrKaydet.Location = new System.Drawing.Point(115, 217);
            this.BtnnOgrKaydet.Name = "BtnnOgrKaydet";
            this.BtnnOgrKaydet.Size = new System.Drawing.Size(150, 40);
            this.BtnnOgrKaydet.TabIndex = 4;
            this.BtnnOgrKaydet.Text = "Öğrenci Kaydet";
            this.BtnnOgrKaydet.UseVisualStyleBackColor = true;
            this.BtnnOgrKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnnKaydet
            // 
            this.BtnnKaydet.Location = new System.Drawing.Point(110, 217);
            this.BtnnKaydet.Name = "BtnnKaydet";
            this.BtnnKaydet.Size = new System.Drawing.Size(124, 40);
            this.BtnnKaydet.TabIndex = 5;
            this.BtnnKaydet.Text = "Güncelle";
            this.BtnnKaydet.UseVisualStyleBackColor = true;
            this.BtnnKaydet.Click += new System.EventHandler(this.BtnnKaydet_Click);
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 579);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgretmenDetay";
            this.Text = "FrmOgretmenDetay";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_Kayıt_SistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskNumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtS1;
        private System.Windows.Forms.TextBox TxtS3;
        private System.Windows.Forms.TextBox TxtS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblOrt;
        private System.Windows.Forms.Label LblGS;
        private System.Windows.Forms.Label LblKS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Not_Kayıt_SistemiDataSet not_Kayıt_SistemiDataSet;
        private System.Windows.Forms.BindingSource tBLDERSBindingSource;
        private Not_Kayıt_SistemiDataSetTableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRORTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button BtnnOgrKaydet;
        private System.Windows.Forms.Button BtnnKaydet;
    }
}