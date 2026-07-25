namespace OgrenciKayitSistemi
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            txtBolum = new TextBox();
            nudSinif = new NumericUpDown();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dgvOgrenciler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudSinif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Numara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 265);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Bölüm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 324);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "Sınıf";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(111, 68);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(111, 125);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(111, 195);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 7;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(111, 265);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 8;
            // 
            // nudSinif
            // 
            nudSinif.Location = new Point(111, 324);
            nudSinif.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudSinif.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSinif.Name = "nudSinif";
            nudSinif.Size = new Size(150, 27);
            nudSinif.TabIndex = 9;
            nudSinif.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(21, 387);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(76, 25);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(127, 387);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(80, 25);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(244, 387);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(79, 25);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(359, 386);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(78, 27);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(1, 434);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.RowHeadersWidth = 51;
            dgvOgrenciler.Size = new Size(983, 188);
            dgvOgrenciler.TabIndex = 14;
            dgvOgrenciler.CellContentClick += dgvOgrenciler_CellContentClick;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 624);
            Controls.Add(dgvOgrenciler);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(nudSinif);
            Controls.Add(txtBolum);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Kayıt Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSinif).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private TextBox txtBolum;
        private NumericUpDown nudSinif;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private DataGridView dgvOgrenciler;
    }
}
