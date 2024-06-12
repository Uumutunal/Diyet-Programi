namespace EFDiyetProgramiProje_PL
{
    partial class KullaniciKontrolPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKontrolPaneli));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ımageList1 = new ImageList(components);
            btnKullaniciBilgileriGuncelle = new Button();
            groupBox1 = new GroupBox();
            lblGunlukToplamKalori = new Label();
            lblAlinanKalori = new Label();
            lbl9 = new Label();
            lblBMR = new Label();
            lblBMI = new Label();
            label25 = new Label();
            ımageList2 = new ImageList(components);
            lbl = new Label();
            lblGunlukHedefKalori = new Label();
            lblHedefKilo = new Label();
            label12 = new Label();
            label11 = new Label();
            label15 = new Label();
            label13 = new Label();
            cbKategoriler = new ComboBox();
            lbYemekler = new ListBox();
            label1 = new Label();
            lblCinsiyet = new Label();
            lblYas = new Label();
            lblKilo = new Label();
            lblBoy = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnKisiselBilgileriGuncelle = new Button();
            monthCalendar1 = new MonthCalendar();
            label10 = new Label();
            btnGunSonuRaporu = new Button();
            btnKiyasRaporu = new Button();
            btnYemekCesidiRaporu = new Button();
            pnlRapor = new Panel();
            lblMotivasyonSozleri = new Label();
            btnOturumuKapat = new Button();
            txtAdet = new TextBox();
            label17 = new Label();
            rtxtTarif = new RichTextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label9 = new Label();
            label14 = new Label();
            pnlYemekler = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-diet-50.png");
            ımageList1.Images.SetKeyName(1, "icons8-about-me-50.png");
            ımageList1.Images.SetKeyName(2, "icons8-personal-growth-50.png");
            ımageList1.Images.SetKeyName(3, "ico-diet-50.png");
            ımageList1.Images.SetKeyName(4, "icons8diet-50.png");
            ımageList1.Images.SetKeyName(5, "icons8-samsung-health-50.png");
            ımageList1.Images.SetKeyName(6, "icons8-diet-50 (2).png");
            ımageList1.Images.SetKeyName(7, "icons8-diet-50 (1).png");
            ımageList1.Images.SetKeyName(8, "icons8-diet-50.png");
            ımageList1.Images.SetKeyName(9, "icons8-diet-50 (3).png");
            ımageList1.Images.SetKeyName(10, "icons8-diet-50 (4).png");
            ımageList1.Images.SetKeyName(11, "icons8-diet-50 (5).png");
            ımageList1.Images.SetKeyName(12, "icons8-diet-50 (6).png");
            // 
            // btnKullaniciBilgileriGuncelle
            // 
            btnKullaniciBilgileriGuncelle.ImageAlign = ContentAlignment.TopCenter;
            btnKullaniciBilgileriGuncelle.ImageKey = "icons8-about-me-50.png";
            btnKullaniciBilgileriGuncelle.ImageList = ımageList1;
            btnKullaniciBilgileriGuncelle.Location = new Point(86, 657);
            btnKullaniciBilgileriGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKullaniciBilgileriGuncelle.Name = "btnKullaniciBilgileriGuncelle";
            btnKullaniciBilgileriGuncelle.Size = new Size(122, 116);
            btnKullaniciBilgileriGuncelle.TabIndex = 46;
            btnKullaniciBilgileriGuncelle.Text = "Kullanıcı Bilgilerini Değiştir";
            btnKullaniciBilgileriGuncelle.TextAlign = ContentAlignment.BottomCenter;
            btnKullaniciBilgileriGuncelle.UseVisualStyleBackColor = true;
            btnKullaniciBilgileriGuncelle.Click += btnKullaniciBilgileriGuncelle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblGunlukToplamKalori);
            groupBox1.Controls.Add(lblAlinanKalori);
            groupBox1.Controls.Add(lbl9);
            groupBox1.Controls.Add(lblBMR);
            groupBox1.Controls.Add(lblBMI);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(lblGunlukHedefKalori);
            groupBox1.Controls.Add(lblHedefKilo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(1419, 3);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(304, 365);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kalori";
            // 
            // lblGunlukToplamKalori
            // 
            lblGunlukToplamKalori.AutoSize = true;
            lblGunlukToplamKalori.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGunlukToplamKalori.Location = new Point(207, 55);
            lblGunlukToplamKalori.Name = "lblGunlukToplamKalori";
            lblGunlukToplamKalori.Size = new Size(19, 23);
            lblGunlukToplamKalori.TabIndex = 101;
            lblGunlukToplamKalori.Text = "0";
            // 
            // lblAlinanKalori
            // 
            lblAlinanKalori.AutoSize = true;
            lblAlinanKalori.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlinanKalori.ForeColor = Color.Violet;
            lblAlinanKalori.Location = new Point(226, 47);
            lblAlinanKalori.Name = "lblAlinanKalori";
            lblAlinanKalori.Size = new Size(0, 38);
            lblAlinanKalori.TabIndex = 66;
            // 
            // lbl9
            // 
            lbl9.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl9.ForeColor = Color.Violet;
            lbl9.ImageAlign = ContentAlignment.MiddleLeft;
            lbl9.ImageKey = "icons8-samsung-health-50.png";
            lbl9.ImageList = ımageList1;
            lbl9.Location = new Point(7, 41);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(187, 52);
            lbl9.TabIndex = 65;
            lbl9.Text = "Alınan Kalori:";
            lbl9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBMR
            // 
            lblBMR.AutoSize = true;
            lblBMR.Location = new Point(237, 321);
            lblBMR.Name = "lblBMR";
            lblBMR.Size = new Size(38, 20);
            lblBMR.TabIndex = 64;
            lblBMR.Text = "Kilo:";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new Point(240, 261);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(34, 20);
            lblBMI.TabIndex = 63;
            lblBMI.Text = "Boy";
            // 
            // label25
            // 
            label25.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label25.ImageAlign = ContentAlignment.MiddleLeft;
            label25.ImageKey = "icons8-bmi-30.png";
            label25.ImageList = ımageList2;
            label25.Location = new Point(39, 252);
            label25.Name = "label25";
            label25.Size = new Size(187, 36);
            label25.TabIndex = 61;
            label25.Text = "Vücut Kitle Endeksi:";
            label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "icons8-height-40.png");
            ımageList2.Images.SetKeyName(1, "icons8-weighing-30.png");
            ımageList2.Images.SetKeyName(2, "icons8-age-30.png");
            ımageList2.Images.SetKeyName(3, "icons8-gender-30.png");
            ımageList2.Images.SetKeyName(4, "icons8-samsung-health-30.png");
            ımageList2.Images.SetKeyName(5, "icons8-bmi-30.png");
            ımageList2.Images.SetKeyName(6, "icons8-weighing-30 (1).png");
            ımageList2.Images.SetKeyName(7, "icons8-diet-30 (2).png");
            ımageList2.Images.SetKeyName(8, "icons8-diet-30 (1).png");
            ımageList2.Images.SetKeyName(9, "icons8-diet-30.png");
            ımageList2.Images.SetKeyName(10, "icons8-diet-30 (5).png");
            ımageList2.Images.SetKeyName(11, "icons8-diet-30 (4).png");
            ımageList2.Images.SetKeyName(12, "icons8-diet-30 (3).png");
            // 
            // lbl
            // 
            lbl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl.ImageAlign = ContentAlignment.MiddleLeft;
            lbl.ImageKey = "icons8-diet-30 (2).png";
            lbl.ImageList = ımageList2;
            lbl.Location = new Point(7, 308);
            lbl.Name = "lbl";
            lbl.Size = new Size(219, 43);
            lbl.TabIndex = 62;
            lbl.Text = "Bazal Metabolizma Hızı:";
            lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGunlukHedefKalori
            // 
            lblGunlukHedefKalori.AutoSize = true;
            lblGunlukHedefKalori.Location = new Point(237, 141);
            lblGunlukHedefKalori.Name = "lblGunlukHedefKalori";
            lblGunlukHedefKalori.Size = new Size(38, 20);
            lblGunlukHedefKalori.TabIndex = 60;
            lblGunlukHedefKalori.Text = "Kilo:";
            // 
            // lblHedefKilo
            // 
            lblHedefKilo.AutoSize = true;
            lblHedefKilo.Location = new Point(240, 201);
            lblHedefKilo.Name = "lblHedefKilo";
            lblHedefKilo.Size = new Size(34, 20);
            lblHedefKilo.TabIndex = 59;
            lblHedefKilo.Text = "Boy";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.ImageKey = "icons8-weighing-30 (1).png";
            label12.ImageList = ımageList2;
            label12.Location = new Point(98, 193);
            label12.Name = "label12";
            label12.Size = new Size(128, 32);
            label12.TabIndex = 57;
            label12.Text = "Hedef Kilo:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.ImageKey = "icons8-diet-30.png";
            label11.ImageList = ımageList2;
            label11.Location = new Point(30, 133);
            label11.Name = "label11";
            label11.Size = new Size(197, 33);
            label11.TabIndex = 58;
            label11.Text = "Günlük Hedef Kalori:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(311, 472);
            label15.Name = "label15";
            label15.Size = new Size(103, 23);
            label15.TabIndex = 51;
            label15.Text = "Adet Giriniz:";
            // 
            // label13
            // 
            label13.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.YellowGreen;
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.ImageKey = "icons8diet-50.png";
            label13.ImageList = ımageList1;
            label13.Location = new Point(288, 51);
            label13.Name = "label13";
            label13.Size = new Size(216, 56);
            label13.TabIndex = 75;
            label13.Text = "Yemekler Listesi:";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbKategoriler
            // 
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new Point(311, 111);
            cbKategoriler.Margin = new Padding(3, 4, 3, 4);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new Size(181, 28);
            cbKategoriler.TabIndex = 74;
            cbKategoriler.SelectedIndexChanged += cbKategoriler_SelectedIndexChanged;
            // 
            // lbYemekler
            // 
            lbYemekler.FormattingEnabled = true;
            lbYemekler.Location = new Point(311, 160);
            lbYemekler.Margin = new Padding(3, 4, 3, 4);
            lbYemekler.Name = "lbYemekler";
            lbYemekler.Size = new Size(181, 304);
            lbYemekler.TabIndex = 72;
            lbYemekler.SelectedIndexChanged += lbYemekler_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkOrange;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.ImageKey = "icons8-diet-50 (5).png";
            label1.ImageList = ımageList1;
            label1.Location = new Point(835, 80);
            label1.Name = "label1";
            label1.Size = new Size(137, 67);
            label1.TabIndex = 67;
            label1.Text = "Öğünler";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.ImageAlign = ContentAlignment.MiddleLeft;
            lblCinsiyet.ImageKey = "(none)";
            lblCinsiyet.ImageList = ımageList2;
            lblCinsiyet.Location = new Point(145, 484);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(63, 20);
            lblCinsiyet.TabIndex = 66;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(130, 421);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(33, 20);
            lblYas.TabIndex = 65;
            lblYas.Text = "Yaş:";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Location = new Point(130, 357);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(38, 20);
            lblKilo.TabIndex = 64;
            lblKilo.Text = "Kilo:";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(130, 293);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(34, 20);
            lblBoy.TabIndex = 63;
            lblBoy.Text = "Boy";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.ImageKey = "icons8-gender-30.png";
            label5.ImageList = ımageList2;
            label5.Location = new Point(35, 475);
            label5.Name = "label5";
            label5.Size = new Size(104, 37);
            label5.TabIndex = 62;
            label5.Text = "Cinsiyet:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.ImageKey = "icons8-age-30.png";
            label6.ImageList = ımageList2;
            label6.Location = new Point(41, 409);
            label6.Name = "label6";
            label6.Size = new Size(70, 41);
            label6.TabIndex = 61;
            label6.Text = "Yaş:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.ImageKey = "icons8-weighing-30.png";
            label7.ImageList = ımageList2;
            label7.Location = new Point(41, 347);
            label7.Name = "label7";
            label7.Size = new Size(74, 43);
            label7.TabIndex = 60;
            label7.Text = "Kilo:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.ImageKey = "icons8-height-40.png";
            label8.ImageList = ımageList2;
            label8.Location = new Point(37, 277);
            label8.Name = "label8";
            label8.Size = new Size(74, 45);
            label8.TabIndex = 59;
            label8.Text = "Boy:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnKisiselBilgileriGuncelle
            // 
            btnKisiselBilgileriGuncelle.ImageAlign = ContentAlignment.TopCenter;
            btnKisiselBilgileriGuncelle.ImageKey = "icons8-personal-growth-50.png";
            btnKisiselBilgileriGuncelle.ImageList = ımageList1;
            btnKisiselBilgileriGuncelle.Location = new Point(86, 532);
            btnKisiselBilgileriGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKisiselBilgileriGuncelle.Name = "btnKisiselBilgileriGuncelle";
            btnKisiselBilgileriGuncelle.Size = new Size(122, 117);
            btnKisiselBilgileriGuncelle.TabIndex = 58;
            btnKisiselBilgileriGuncelle.Text = "Kişisel Bilgileri Güncelle";
            btnKisiselBilgileriGuncelle.TextAlign = ContentAlignment.BottomCenter;
            btnKisiselBilgileriGuncelle.UseVisualStyleBackColor = true;
            btnKisiselBilgileriGuncelle.Click += btnKisiselBilgileriGuncelle_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(5, 3);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 57;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Firebrick;
            label10.ImageAlign = ContentAlignment.MiddleRight;
            label10.ImageKey = "icons8-diet-50.png";
            label10.ImageList = ımageList1;
            label10.Location = new Point(30, 220);
            label10.Name = "label10";
            label10.Size = new Size(178, 59);
            label10.TabIndex = 83;
            label10.Text = "Kişisel Bilgiler";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGunSonuRaporu
            // 
            btnGunSonuRaporu.ImageAlign = ContentAlignment.TopCenter;
            btnGunSonuRaporu.ImageKey = "icons8-diet-50 (2).png";
            btnGunSonuRaporu.ImageList = ımageList1;
            btnGunSonuRaporu.Location = new Point(1443, 375);
            btnGunSonuRaporu.Name = "btnGunSonuRaporu";
            btnGunSonuRaporu.Size = new Size(91, 100);
            btnGunSonuRaporu.TabIndex = 86;
            btnGunSonuRaporu.Text = "Gün Sonu Raporu";
            btnGunSonuRaporu.TextAlign = ContentAlignment.BottomCenter;
            btnGunSonuRaporu.UseVisualStyleBackColor = true;
            btnGunSonuRaporu.Click += btnGunSonuRaporu_Click;
            // 
            // btnKiyasRaporu
            // 
            btnKiyasRaporu.ImageAlign = ContentAlignment.TopCenter;
            btnKiyasRaporu.ImageKey = "icons8-diet-50 (3).png";
            btnKiyasRaporu.ImageList = ımageList1;
            btnKiyasRaporu.Location = new Point(1542, 375);
            btnKiyasRaporu.Name = "btnKiyasRaporu";
            btnKiyasRaporu.Size = new Size(86, 100);
            btnKiyasRaporu.TabIndex = 86;
            btnKiyasRaporu.Text = "Kıyas Raporu";
            btnKiyasRaporu.TextAlign = ContentAlignment.BottomCenter;
            btnKiyasRaporu.UseVisualStyleBackColor = true;
            btnKiyasRaporu.Click += btnKiyasRaporu_Click;
            // 
            // btnYemekCesidiRaporu
            // 
            btnYemekCesidiRaporu.ImageAlign = ContentAlignment.TopCenter;
            btnYemekCesidiRaporu.ImageKey = "icons8-diet-30 (3).png";
            btnYemekCesidiRaporu.ImageList = ımageList2;
            btnYemekCesidiRaporu.Location = new Point(1633, 375);
            btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            btnYemekCesidiRaporu.Size = new Size(96, 100);
            btnYemekCesidiRaporu.TabIndex = 86;
            btnYemekCesidiRaporu.Text = "Yemek Çeşidi Raporu";
            btnYemekCesidiRaporu.TextAlign = ContentAlignment.BottomCenter;
            btnYemekCesidiRaporu.UseVisualStyleBackColor = true;
            btnYemekCesidiRaporu.Click += btnYemekCesidiRaporu_Click;
            // 
            // pnlRapor
            // 
            pnlRapor.Location = new Point(1370, 548);
            pnlRapor.Name = "pnlRapor";
            pnlRapor.Size = new Size(351, 349);
            pnlRapor.TabIndex = 89;
            // 
            // lblMotivasyonSozleri
            // 
            lblMotivasyonSozleri.AutoSize = true;
            lblMotivasyonSozleri.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMotivasyonSozleri.ForeColor = SystemColors.ActiveCaption;
            lblMotivasyonSozleri.Location = new Point(706, 9);
            lblMotivasyonSozleri.Name = "lblMotivasyonSozleri";
            lblMotivasyonSozleri.Size = new Size(293, 38);
            lblMotivasyonSozleri.TabIndex = 90;
            lblMotivasyonSozleri.Text = "Motivasyon Sözleri";
            // 
            // btnOturumuKapat
            // 
            btnOturumuKapat.Location = new Point(86, 781);
            btnOturumuKapat.Margin = new Padding(3, 4, 3, 4);
            btnOturumuKapat.Name = "btnOturumuKapat";
            btnOturumuKapat.Size = new Size(122, 104);
            btnOturumuKapat.TabIndex = 91;
            btnOturumuKapat.Text = "Oturumu Kapat";
            btnOturumuKapat.UseVisualStyleBackColor = true;
            btnOturumuKapat.Click += btnOturumuKapat_Click;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(417, 472);
            txtAdet.Margin = new Padding(3, 4, 3, 4);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(75, 27);
            txtAdet.TabIndex = 92;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.Location = new Point(272, 548);
            label17.Name = "label17";
            label17.Size = new Size(47, 23);
            label17.TabIndex = 94;
            label17.Text = "Tarif:";
            // 
            // rtxtTarif
            // 
            rtxtTarif.Location = new Point(281, 589);
            rtxtTarif.Margin = new Padding(3, 4, 3, 4);
            rtxtTarif.Name = "rtxtTarif";
            rtxtTarif.ReadOnly = true;
            rtxtTarif.Size = new Size(211, 295);
            rtxtTarif.TabIndex = 95;
            rtxtTarif.Text = "";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(1464, 481);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(268, 27);
            dtpStartDate.TabIndex = 104;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(1464, 514);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(268, 27);
            dtpEndDate.TabIndex = 104;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1382, 486);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 105;
            label9.Text = "Başlangıç:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1418, 520);
            label14.Name = "label14";
            label14.Size = new Size(40, 20);
            label14.TabIndex = 105;
            label14.Text = "Bitiş:";
            // 
            // pnlYemekler
            // 
            pnlYemekler.AutoScroll = true;
            pnlYemekler.Location = new Point(499, 160);
            pnlYemekler.Margin = new Padding(3, 4, 3, 4);
            pnlYemekler.Name = "pnlYemekler";
            pnlYemekler.Size = new Size(865, 725);
            pnlYemekler.TabIndex = 106;
            // 
            // KullaniciKontrolPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1735, 901);
            Controls.Add(pnlYemekler);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(rtxtTarif);
            Controls.Add(label17);
            Controls.Add(txtAdet);
            Controls.Add(btnOturumuKapat);
            Controls.Add(lblMotivasyonSozleri);
            Controls.Add(pnlRapor);
            Controls.Add(label15);
            Controls.Add(btnYemekCesidiRaporu);
            Controls.Add(btnKiyasRaporu);
            Controls.Add(btnGunSonuRaporu);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Controls.Add(cbKategoriler);
            Controls.Add(lbYemekler);
            Controls.Add(label1);
            Controls.Add(lblCinsiyet);
            Controls.Add(lblYas);
            Controls.Add(lblKilo);
            Controls.Add(lblBoy);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnKisiselBilgileriGuncelle);
            Controls.Add(monthCalendar1);
            Controls.Add(btnKullaniciBilgileriGuncelle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KullaniciKontrolPaneli";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnKullaniciBilgileriGuncelle;
        private GroupBox groupBox1;
        private Label lblAlinanKalori;
        private Label lbl9;
        private Label lblBMR;
        private Label lblBMI;
        private Label label25;
        private Label lbl;
        private Label lblGunlukHedefKalori;
        private Label lblHedefKilo;
        private Label label12;
        private Label label11;
        private Label label15;
        private Label label13;
        private ComboBox cbKategoriler;
        private ListBox lbYemekler;
        private Label label1;
        private Label lblCinsiyet;
        private Label lblYas;
        private Label lblKilo;
        private Label lblBoy;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnKisiselBilgileriGuncelle;
        private MonthCalendar monthCalendar1;
        private Label label10;
        private ImageList ımageList2;
        private ImageList ımageList1;
        private Button btnGunSonuRaporu;
        private Button btnKiyasRaporu;
        private Button btnYemekCesidiRaporu;
        private Panel pnlRapor;
        private Label lblMotivasyonSozleri;
        private Button btnOturumuKapat;
        private TextBox txtAdet;
        private Label label17;
        private RichTextBox rtxtTarif;
        private Label lblGunlukToplamKalori;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label9;
        private Label label14;
        private Panel pnlYemekler;
    }
}