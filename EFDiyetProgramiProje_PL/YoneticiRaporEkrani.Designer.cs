namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiRaporEkrani
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiRaporEkrani));
            btnGunSonu = new Button();
            ımageList1 = new ImageList(components);
            btnKiyas = new Button();
            btnYemekCesidi = new Button();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            dgvYemekler = new DataGridView();
            dgvKullanicilar = new DataGridView();
            pnlRapor = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblHataMesaji = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // btnGunSonu
            // 
            btnGunSonu.ImageAlign = ContentAlignment.TopCenter;
            btnGunSonu.ImageKey = "icons8-day-and-night-50.png";
            btnGunSonu.ImageList = ımageList1;
            btnGunSonu.Location = new Point(342, 326);
            btnGunSonu.Name = "btnGunSonu";
            btnGunSonu.Size = new Size(116, 95);
            btnGunSonu.TabIndex = 0;
            btnGunSonu.Text = "Gün Sonu Raporu";
            btnGunSonu.TextAlign = ContentAlignment.BottomCenter;
            btnGunSonu.UseVisualStyleBackColor = true;
            btnGunSonu.Click += btnGunSonu_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-day-and-night-50.png");
            // 
            // btnKiyas
            // 
            btnKiyas.Location = new Point(522, 327);
            btnKiyas.Name = "btnKiyas";
            btnKiyas.Size = new Size(116, 94);
            btnKiyas.TabIndex = 1;
            btnKiyas.Text = "      Kıyas         Raporu";
            btnKiyas.TextAlign = ContentAlignment.BottomCenter;
            btnKiyas.UseVisualStyleBackColor = true;
            btnKiyas.Click += btnKiyas_Click;
            // 
            // btnYemekCesidi
            // 
            btnYemekCesidi.Location = new Point(716, 320);
            btnYemekCesidi.Name = "btnYemekCesidi";
            btnYemekCesidi.Size = new Size(116, 94);
            btnYemekCesidi.TabIndex = 2;
            btnYemekCesidi.Text = "Yemek Çeşidi Raporu";
            btnYemekCesidi.TextAlign = ContentAlignment.BottomCenter;
            btnYemekCesidi.UseVisualStyleBackColor = true;
            btnYemekCesidi.Click += btnYemekCesidi_Click;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(155, 150);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(230, 27);
            dtpBaslangic.TabIndex = 3;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(155, 239);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(230, 27);
            dtpBitis.TabIndex = 4;
            // 
            // dgvYemekler
            // 
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Location = new Point(716, 104);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.Size = new Size(300, 188);
            dgvYemekler.TabIndex = 5;
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(400, 104);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.RowHeadersWidth = 51;
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.Size = new Size(300, 188);
            dgvKullanicilar.TabIndex = 6;
            // 
            // pnlRapor
            // 
            pnlRapor.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            pnlRapor.Location = new Point(318, 488);
            pnlRapor.Name = "pnlRapor";
            pnlRapor.Size = new Size(561, 237);
            pnlRapor.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 117);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 8;
            label1.Text = "Başlangıç Tarihi Seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 204);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 8;
            label2.Text = "Bitiş Tarihi Seçiniz:";
            // 
            // lblHataMesaji
            // 
            lblHataMesaji.AutoSize = true;
            lblHataMesaji.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHataMesaji.ForeColor = Color.Red;
            lblHataMesaji.Location = new Point(548, 449);
            lblHataMesaji.Name = "lblHataMesaji";
            lblHataMesaji.Size = new Size(0, 23);
            lblHataMesaji.TabIndex = 9;
            // 
            // YoneticiRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 737);
            Controls.Add(lblHataMesaji);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlRapor);
            Controls.Add(dgvKullanicilar);
            Controls.Add(dgvYemekler);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(btnYemekCesidi);
            Controls.Add(btnKiyas);
            Controls.Add(btnGunSonu);
            Name = "YoneticiRaporEkrani";
            Text = "YoneticiRaporEkrani";
            Load += YoneticiRaporEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGunSonu;
        private Button btnKiyas;
        private Button btnYemekCesidi;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private DataGridView dgvYemekler;
        private DataGridView dgvKullanicilar;
        private Panel pnlRapor;
        private Label label1;
        private Label label2;
        private ImageList ımageList1;
        private Label lblHataMesaji;
    }
}