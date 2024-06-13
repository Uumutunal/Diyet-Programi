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
            label5 = new Label();
            label3 = new Label();
            ımageList2 = new ImageList(components);
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // btnGunSonu
            // 
            btnGunSonu.ImageAlign = ContentAlignment.TopCenter;
            btnGunSonu.ImageKey = "icons8-day-and-night-50.png";
            btnGunSonu.ImageList = ımageList1;
            btnGunSonu.Location = new Point(285, 338);
            btnGunSonu.Name = "btnGunSonu";
            btnGunSonu.Size = new Size(116, 101);
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
            ımageList1.Images.SetKeyName(1, "icons8-comparison-50.png");
            ımageList1.Images.SetKeyName(2, "icons8-report-50.png");
            // 
            // btnKiyas
            // 
            btnKiyas.ImageAlign = ContentAlignment.TopCenter;
            btnKiyas.ImageKey = "icons8-comparison-50.png";
            btnKiyas.ImageList = ımageList1;
            btnKiyas.Location = new Point(465, 339);
            btnKiyas.Name = "btnKiyas";
            btnKiyas.Size = new Size(116, 100);
            btnKiyas.TabIndex = 1;
            btnKiyas.Text = "      Kıyas         Raporu";
            btnKiyas.TextAlign = ContentAlignment.BottomCenter;
            btnKiyas.UseVisualStyleBackColor = true;
            btnKiyas.Click += btnKiyas_Click;
            // 
            // btnYemekCesidi
            // 
            btnYemekCesidi.ImageAlign = ContentAlignment.TopCenter;
            btnYemekCesidi.ImageKey = "icons8-report-50.png";
            btnYemekCesidi.ImageList = ımageList1;
            btnYemekCesidi.Location = new Point(659, 332);
            btnYemekCesidi.Name = "btnYemekCesidi";
            btnYemekCesidi.Size = new Size(116, 100);
            btnYemekCesidi.TabIndex = 2;
            btnYemekCesidi.Text = "Yemek Çeşidi Raporu";
            btnYemekCesidi.TextAlign = ContentAlignment.BottomCenter;
            btnYemekCesidi.UseVisualStyleBackColor = true;
            btnYemekCesidi.Click += btnYemekCesidi_Click;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(98, 162);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(230, 27);
            dtpBaslangic.TabIndex = 3;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(98, 251);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(230, 27);
            dtpBitis.TabIndex = 4;
            // 
            // dgvYemekler
            // 
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Location = new Point(659, 116);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.Size = new Size(300, 188);
            dgvYemekler.TabIndex = 5;
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(343, 116);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.RowHeadersWidth = 51;
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.Size = new Size(300, 188);
            dgvKullanicilar.TabIndex = 6;
            // 
            // pnlRapor
            // 
            pnlRapor.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            pnlRapor.Location = new Point(261, 500);
            pnlRapor.Name = "pnlRapor";
            pnlRapor.Size = new Size(561, 237);
            pnlRapor.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 129);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 8;
            label1.Text = "Başlangıç Tarihi Seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 216);
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
            lblHataMesaji.Location = new Point(491, 461);
            lblHataMesaji.Name = "lblHataMesaji";
            lblHataMesaji.Size = new Size(0, 23);
            lblHataMesaji.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(325, 22);
            label5.Name = "label5";
            label5.Size = new Size(420, 54);
            label5.TabIndex = 21;
            label5.Text = "RAPORLARI GÖRÜNTÜLE";
            // 
            // label3
            // 
            label3.ImageKey = "reportline.png";
            label3.ImageList = ımageList2;
            label3.Location = new Point(981, -4);
            label3.Name = "label3";
            label3.Size = new Size(93, 319);
            label3.TabIndex = 22;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "reportline - Kopya.png");
            ımageList2.Images.SetKeyName(1, "reportline.png");
            // 
            // label4
            // 
            label4.ImageKey = "reportline.png";
            label4.ImageList = ımageList2;
            label4.Location = new Point(981, 294);
            label4.Name = "label4";
            label4.Size = new Size(93, 293);
            label4.TabIndex = 22;
            // 
            // label6
            // 
            label6.ImageKey = "reportline.png";
            label6.ImageList = ımageList2;
            label6.Location = new Point(981, 587);
            label6.Name = "label6";
            label6.Size = new Size(93, 297);
            label6.TabIndex = 22;
            // 
            // label7
            // 
            label7.ImageKey = "reportline - Kopya.png";
            label7.ImageList = ımageList2;
            label7.Location = new Point(-4, 587);
            label7.Name = "label7";
            label7.Size = new Size(93, 297);
            label7.TabIndex = 23;
            // 
            // label8
            // 
            label8.ImageKey = "reportline - Kopya.png";
            label8.ImageList = ımageList2;
            label8.Location = new Point(-4, 294);
            label8.Name = "label8";
            label8.Size = new Size(93, 303);
            label8.TabIndex = 24;
            // 
            // label9
            // 
            label9.ImageKey = "reportline - Kopya.png";
            label9.ImageList = ımageList2;
            label9.Location = new Point(-4, -4);
            label9.Name = "label9";
            label9.Size = new Size(93, 319);
            label9.TabIndex = 25;
            // 
            // YoneticiRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1074, 753);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
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
        private Label label5;
        private Label label3;
        private ImageList ımageList2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}