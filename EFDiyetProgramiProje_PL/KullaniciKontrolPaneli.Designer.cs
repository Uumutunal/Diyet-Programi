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
            lblKaloriToplamAksam = new Label();
            lblKaloriToplamSabah = new Label();
            lblKaloriToplamOgle = new Label();
            label15 = new Label();
            label13 = new Label();
            cbKategoriler = new ComboBox();
            lbYemekler = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            btnEkleSabah = new Button();
            btnEkleOgle = new Button();
            btnEkleAksam = new Button();
            flpSabahYemekler = new FlowLayoutPanel();
            flpOgleYemekler = new FlowLayoutPanel();
            flpAksamYemekler = new FlowLayoutPanel();
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
            btnKullaniciBilgileriGuncelle.Location = new Point(75, 493);
            btnKullaniciBilgileriGuncelle.Name = "btnKullaniciBilgileriGuncelle";
            btnKullaniciBilgileriGuncelle.Size = new Size(107, 87);
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
            groupBox1.Location = new Point(1240, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 308);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kalori";
            // 
            // lblGunlukToplamKalori
            // 
            lblGunlukToplamKalori.AutoSize = true;
            lblGunlukToplamKalori.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGunlukToplamKalori.Location = new Point(182, 55);
            lblGunlukToplamKalori.Name = "lblGunlukToplamKalori";
            lblGunlukToplamKalori.Size = new Size(17, 19);
            lblGunlukToplamKalori.TabIndex = 101;
            lblGunlukToplamKalori.Text = "0";
            // 
            // lblAlinanKalori
            // 
            lblAlinanKalori.AutoSize = true;
            lblAlinanKalori.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlinanKalori.ForeColor = Color.Violet;
            lblAlinanKalori.Location = new Point(199, 47);
            lblAlinanKalori.Name = "lblAlinanKalori";
            lblAlinanKalori.Size = new Size(0, 30);
            lblAlinanKalori.TabIndex = 66;
            // 
            // lbl9
            // 
            lbl9.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl9.ForeColor = Color.Violet;
            lbl9.ImageAlign = ContentAlignment.MiddleLeft;
            lbl9.ImageKey = "icons8-samsung-health-50.png";
            lbl9.ImageList = ımageList1;
            lbl9.Location = new Point(7, 44);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(164, 39);
            lbl9.TabIndex = 65;
            lbl9.Text = "Alınan Kalori:";
            lbl9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBMR
            // 
            lblBMR.AutoSize = true;
            lblBMR.Location = new Point(204, 256);
            lblBMR.Name = "lblBMR";
            lblBMR.Size = new Size(30, 15);
            lblBMR.TabIndex = 64;
            lblBMR.Text = "Kilo:";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new Point(188, 214);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(27, 15);
            lblBMI.TabIndex = 63;
            lblBMI.Text = "Boy";
            // 
            // label25
            // 
            label25.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label25.ImageAlign = ContentAlignment.MiddleLeft;
            label25.ImageKey = "icons8-bmi-30.png";
            label25.ImageList = ımageList2;
            label25.Location = new Point(7, 209);
            label25.Name = "label25";
            label25.Size = new Size(164, 27);
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
            lbl.Location = new Point(7, 247);
            lbl.Name = "lbl";
            lbl.Size = new Size(192, 32);
            lbl.TabIndex = 62;
            lbl.Text = "Bazal Metabolizma Hızı:";
            lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGunlukHedefKalori
            // 
            lblGunlukHedefKalori.AutoSize = true;
            lblGunlukHedefKalori.Location = new Point(185, 119);
            lblGunlukHedefKalori.Name = "lblGunlukHedefKalori";
            lblGunlukHedefKalori.Size = new Size(30, 15);
            lblGunlukHedefKalori.TabIndex = 60;
            lblGunlukHedefKalori.Text = "Kilo:";
            // 
            // lblHedefKilo
            // 
            lblHedefKilo.AutoSize = true;
            lblHedefKilo.Location = new Point(138, 172);
            lblHedefKilo.Name = "lblHedefKilo";
            lblHedefKilo.Size = new Size(27, 15);
            lblHedefKilo.TabIndex = 59;
            lblHedefKilo.Text = "Boy";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.ImageKey = "icons8-weighing-30 (1).png";
            label12.ImageList = ımageList2;
            label12.Location = new Point(7, 163);
            label12.Name = "label12";
            label12.Size = new Size(112, 24);
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
            label11.Location = new Point(7, 114);
            label11.Name = "label11";
            label11.Size = new Size(172, 25);
            label11.TabIndex = 58;
            label11.Text = "Günlük Hedef Kalori:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKaloriToplamAksam
            // 
            lblKaloriToplamAksam.AutoSize = true;
            lblKaloriToplamAksam.Location = new Point(1058, 225);
            lblKaloriToplamAksam.Name = "lblKaloriToplamAksam";
            lblKaloriToplamAksam.Size = new Size(82, 15);
            lblKaloriToplamAksam.TabIndex = 81;
            lblKaloriToplamAksam.Text = "Toplam Kalori:";
            // 
            // lblKaloriToplamSabah
            // 
            lblKaloriToplamSabah.AutoSize = true;
            lblKaloriToplamSabah.Location = new Point(555, 225);
            lblKaloriToplamSabah.Name = "lblKaloriToplamSabah";
            lblKaloriToplamSabah.Size = new Size(82, 15);
            lblKaloriToplamSabah.TabIndex = 80;
            lblKaloriToplamSabah.Text = "Toplam Kalori:";
            // 
            // lblKaloriToplamOgle
            // 
            lblKaloriToplamOgle.AutoSize = true;
            lblKaloriToplamOgle.Location = new Point(806, 225);
            lblKaloriToplamOgle.Name = "lblKaloriToplamOgle";
            lblKaloriToplamOgle.Size = new Size(82, 15);
            lblKaloriToplamOgle.TabIndex = 77;
            lblKaloriToplamOgle.Text = "Toplam Kalori:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(272, 354);
            label15.Name = "label15";
            label15.Size = new Size(87, 19);
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
            label13.Location = new Point(252, 38);
            label13.Name = "label13";
            label13.Size = new Size(189, 42);
            label13.TabIndex = 75;
            label13.Text = "Yemekler Listesi:";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbKategoriler
            // 
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new Point(272, 83);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new Size(159, 23);
            cbKategoriler.TabIndex = 74;
            cbKategoriler.SelectedIndexChanged += cbKategoriler_SelectedIndexChanged;
            // 
            // lbYemekler
            // 
            lbYemekler.FormattingEnabled = true;
            lbYemekler.ItemHeight = 15;
            lbYemekler.Location = new Point(272, 120);
            lbYemekler.Name = "lbYemekler";
            lbYemekler.Size = new Size(159, 229);
            lbYemekler.TabIndex = 72;
            lbYemekler.SelectedIndexChanged += lbYemekler_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(949, 223);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 70;
            label4.Text = "Akşam:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(698, 225);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 69;
            label3.Text = "Öğle:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 225);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 68;
            label2.Text = "Sabah:";
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkOrange;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.ImageKey = "icons8-diet-50 (5).png";
            label1.ImageList = ımageList1;
            label1.Location = new Point(731, 60);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 67;
            label1.Text = "Öğünler";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.ImageAlign = ContentAlignment.MiddleLeft;
            lblCinsiyet.ImageKey = "(none)";
            lblCinsiyet.ImageList = ımageList2;
            lblCinsiyet.Location = new Point(127, 363);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(55, 15);
            lblCinsiyet.TabIndex = 66;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(114, 316);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(27, 15);
            lblYas.TabIndex = 65;
            lblYas.Text = "Yaş:";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Location = new Point(114, 268);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(30, 15);
            lblKilo.TabIndex = 64;
            lblKilo.Text = "Kilo:";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(114, 220);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(27, 15);
            lblBoy.TabIndex = 63;
            lblBoy.Text = "Boy";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.ImageKey = "icons8-gender-30.png";
            label5.ImageList = ımageList2;
            label5.Location = new Point(31, 356);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
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
            label6.Location = new Point(36, 307);
            label6.Name = "label6";
            label6.Size = new Size(61, 31);
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
            label7.Location = new Point(36, 260);
            label7.Name = "label7";
            label7.Size = new Size(65, 32);
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
            label8.Location = new Point(32, 208);
            label8.Name = "label8";
            label8.Size = new Size(65, 34);
            label8.TabIndex = 59;
            label8.Text = "Boy:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnKisiselBilgileriGuncelle
            // 
            btnKisiselBilgileriGuncelle.ImageAlign = ContentAlignment.TopCenter;
            btnKisiselBilgileriGuncelle.ImageKey = "icons8-personal-growth-50.png";
            btnKisiselBilgileriGuncelle.ImageList = ımageList1;
            btnKisiselBilgileriGuncelle.Location = new Point(75, 399);
            btnKisiselBilgileriGuncelle.Name = "btnKisiselBilgileriGuncelle";
            btnKisiselBilgileriGuncelle.Size = new Size(107, 88);
            btnKisiselBilgileriGuncelle.TabIndex = 58;
            btnKisiselBilgileriGuncelle.Text = "Kişisel Bilgileri Güncelle";
            btnKisiselBilgileriGuncelle.TextAlign = ContentAlignment.BottomCenter;
            btnKisiselBilgileriGuncelle.UseVisualStyleBackColor = true;
            btnKisiselBilgileriGuncelle.Click += btnKisiselBilgileriGuncelle_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(4, 2);
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
            label10.Location = new Point(26, 165);
            label10.Name = "label10";
            label10.Size = new Size(156, 44);
            label10.TabIndex = 83;
            label10.Text = "Kişisel Bilgiler";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGunSonuRaporu
            // 
            btnGunSonuRaporu.ImageAlign = ContentAlignment.TopCenter;
            btnGunSonuRaporu.ImageKey = "icons8-diet-50 (2).png";
            btnGunSonuRaporu.ImageList = ımageList1;
            btnGunSonuRaporu.Location = new Point(1240, 327);
            btnGunSonuRaporu.Margin = new Padding(3, 2, 3, 2);
            btnGunSonuRaporu.Name = "btnGunSonuRaporu";
            btnGunSonuRaporu.Size = new Size(80, 91);
            btnGunSonuRaporu.TabIndex = 86;
            btnGunSonuRaporu.Text = "Gün Sonu Raporu";
            btnGunSonuRaporu.TextAlign = ContentAlignment.BottomCenter;
            btnGunSonuRaporu.UseVisualStyleBackColor = true;
            // 
            // btnKiyasRaporu
            // 
            btnKiyasRaporu.ImageAlign = ContentAlignment.TopCenter;
            btnKiyasRaporu.ImageKey = "icons8-diet-50 (3).png";
            btnKiyasRaporu.ImageList = ımageList1;
            btnKiyasRaporu.Location = new Point(1326, 327);
            btnKiyasRaporu.Margin = new Padding(3, 2, 3, 2);
            btnKiyasRaporu.Name = "btnKiyasRaporu";
            btnKiyasRaporu.Size = new Size(75, 91);
            btnKiyasRaporu.TabIndex = 86;
            btnKiyasRaporu.Text = "Kıyas Raporu";
            btnKiyasRaporu.TextAlign = ContentAlignment.BottomCenter;
            btnKiyasRaporu.UseVisualStyleBackColor = true;
            // 
            // btnYemekCesidiRaporu
            // 
            btnYemekCesidiRaporu.ImageAlign = ContentAlignment.TopCenter;
            btnYemekCesidiRaporu.ImageKey = "icons8-diet-30 (3).png";
            btnYemekCesidiRaporu.ImageList = ımageList2;
            btnYemekCesidiRaporu.Location = new Point(1406, 327);
            btnYemekCesidiRaporu.Margin = new Padding(3, 2, 3, 2);
            btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            btnYemekCesidiRaporu.Size = new Size(84, 91);
            btnYemekCesidiRaporu.TabIndex = 86;
            btnYemekCesidiRaporu.Text = "Yemek Çeşidi Raporu";
            btnYemekCesidiRaporu.TextAlign = ContentAlignment.BottomCenter;
            btnYemekCesidiRaporu.UseVisualStyleBackColor = true;
            // 
            // pnlRapor
            // 
            pnlRapor.Location = new Point(1241, 442);
            pnlRapor.Margin = new Padding(3, 2, 3, 2);
            pnlRapor.Name = "pnlRapor";
            pnlRapor.Size = new Size(249, 222);
            pnlRapor.TabIndex = 89;
            // 
            // lblMotivasyonSozleri
            // 
            lblMotivasyonSozleri.AutoSize = true;
            lblMotivasyonSozleri.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMotivasyonSozleri.ForeColor = SystemColors.ActiveCaption;
            lblMotivasyonSozleri.Location = new Point(618, 7);
            lblMotivasyonSozleri.Name = "lblMotivasyonSozleri";
            lblMotivasyonSozleri.Size = new Size(231, 30);
            lblMotivasyonSozleri.TabIndex = 90;
            lblMotivasyonSozleri.Text = "Motivasyon Sözleri";
            // 
            // btnOturumuKapat
            // 
            btnOturumuKapat.Location = new Point(75, 586);
            btnOturumuKapat.Name = "btnOturumuKapat";
            btnOturumuKapat.Size = new Size(107, 78);
            btnOturumuKapat.TabIndex = 91;
            btnOturumuKapat.Text = "Oturumu Kapat";
            btnOturumuKapat.UseVisualStyleBackColor = true;
            btnOturumuKapat.Click += btnOturumuKapat_Click;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(365, 354);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(66, 23);
            txtAdet.TabIndex = 92;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.Location = new Point(238, 411);
            label17.Name = "label17";
            label17.Size = new Size(41, 19);
            label17.TabIndex = 94;
            label17.Text = "Tarif:";
            // 
            // rtxtTarif
            // 
            rtxtTarif.Location = new Point(246, 442);
            rtxtTarif.Name = "rtxtTarif";
            rtxtTarif.ReadOnly = true;
            rtxtTarif.Size = new Size(185, 222);
            rtxtTarif.TabIndex = 95;
            rtxtTarif.Text = "";
            // 
            // btnEkleSabah
            // 
            btnEkleSabah.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkleSabah.ImageAlign = ContentAlignment.TopCenter;
            btnEkleSabah.ImageKey = "icons8-diet-50 (6).png";
            btnEkleSabah.ImageList = ımageList1;
            btnEkleSabah.Location = new Point(447, 139);
            btnEkleSabah.Name = "btnEkleSabah";
            btnEkleSabah.Size = new Size(227, 70);
            btnEkleSabah.TabIndex = 96;
            btnEkleSabah.Text = "Ekle";
            btnEkleSabah.TextAlign = ContentAlignment.BottomCenter;
            btnEkleSabah.UseVisualStyleBackColor = true;
            btnEkleSabah.Click += btnEkleSabah_Click;
            // 
            // btnEkleOgle
            // 
            btnEkleOgle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkleOgle.ImageAlign = ContentAlignment.TopCenter;
            btnEkleOgle.ImageKey = "icons8-diet-50 (6).png";
            btnEkleOgle.ImageList = ımageList1;
            btnEkleOgle.Location = new Point(698, 139);
            btnEkleOgle.Name = "btnEkleOgle";
            btnEkleOgle.Size = new Size(231, 70);
            btnEkleOgle.TabIndex = 97;
            btnEkleOgle.Text = "Ekle";
            btnEkleOgle.TextAlign = ContentAlignment.BottomCenter;
            btnEkleOgle.UseVisualStyleBackColor = true;
            btnEkleOgle.Click += btnEkleOgle_Click;
            // 
            // btnEkleAksam
            // 
            btnEkleAksam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkleAksam.ImageAlign = ContentAlignment.TopCenter;
            btnEkleAksam.ImageKey = "icons8-diet-50 (6).png";
            btnEkleAksam.ImageList = ımageList1;
            btnEkleAksam.Location = new Point(950, 139);
            btnEkleAksam.Name = "btnEkleAksam";
            btnEkleAksam.Size = new Size(231, 70);
            btnEkleAksam.TabIndex = 98;
            btnEkleAksam.Text = "Ekle";
            btnEkleAksam.TextAlign = ContentAlignment.BottomCenter;
            btnEkleAksam.UseVisualStyleBackColor = true;
            btnEkleAksam.Click += btnEkleAksam_Click;
            // 
            // flpSabahYemekler
            // 
            flpSabahYemekler.AutoScroll = true;
            flpSabahYemekler.Location = new Point(449, 249);
            flpSabahYemekler.Name = "flpSabahYemekler";
            flpSabahYemekler.Size = new Size(225, 415);
            flpSabahYemekler.TabIndex = 99;
            // 
            // flpOgleYemekler
            // 
            flpOgleYemekler.AutoScroll = true;
            flpOgleYemekler.Location = new Point(698, 249);
            flpOgleYemekler.Name = "flpOgleYemekler";
            flpOgleYemekler.Size = new Size(225, 415);
            flpOgleYemekler.TabIndex = 100;
            // 
            // flpAksamYemekler
            // 
            flpAksamYemekler.AutoScroll = true;
            flpAksamYemekler.Location = new Point(950, 249);
            flpAksamYemekler.Name = "flpAksamYemekler";
            flpAksamYemekler.Size = new Size(225, 415);
            flpAksamYemekler.TabIndex = 100;
            // 
            // KullaniciKontrolPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 676);
            Controls.Add(flpAksamYemekler);
            Controls.Add(flpOgleYemekler);
            Controls.Add(flpSabahYemekler);
            Controls.Add(btnEkleAksam);
            Controls.Add(btnEkleOgle);
            Controls.Add(btnEkleSabah);
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
            Controls.Add(lblKaloriToplamAksam);
            Controls.Add(lblKaloriToplamSabah);
            Controls.Add(lblKaloriToplamOgle);
            Controls.Add(label13);
            Controls.Add(cbKategoriler);
            Controls.Add(lbYemekler);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label lblKaloriToplamAksam;
        private Label lblKaloriToplamSabah;
        private Label lblKaloriToplamOgle;
        private Label label15;
        private Label label13;
        private ComboBox cbKategoriler;
        private ListBox lbYemekler;
        private Label label4;
        private Label label3;
        private Label label2;
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
        private Button btnEkleSabah;
        private Button btnEkleOgle;
        private Button btnEkleAksam;
        private FlowLayoutPanel flpSabahYemekler;
        private FlowLayoutPanel flpOgleYemekler;
        private FlowLayoutPanel flpAksamYemekler;
        private Label lblGunlukToplamKalori;
    }
}