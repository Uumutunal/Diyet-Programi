namespace EFDiyetProgramiProje_PL
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            btnGiris = new Button();
            pbYeniSifreTekrar = new PictureBox();
            pbYeniSifre = new PictureBox();
            btnKayitOl = new Button();
            txtGuvenlikYaniti = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cmbGuvenlikSorusu = new ComboBox();
            label3 = new Label();
            txtYeniSifreTekrar = new TextBox();
            label2 = new Label();
            txtYeniSifre = new TextBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            label4 = new Label();
            label7 = new Label();
            ımageList1 = new ImageList(components);
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(223, 477);
            btnGiris.Margin = new Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(150, 45);
            btnGiris.TabIndex = 33;
            btnGiris.Text = "Giriş Ekranına Dön";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // pbYeniSifreTekrar
            // 
            pbYeniSifreTekrar.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifreTekrar.Location = new Point(487, 353);
            pbYeniSifreTekrar.Name = "pbYeniSifreTekrar";
            pbYeniSifreTekrar.Size = new Size(39, 27);
            pbYeniSifreTekrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifreTekrar.TabIndex = 32;
            pbYeniSifreTekrar.TabStop = false;
            pbYeniSifreTekrar.Click += pbYeniSifreTekrar_Click;
            // 
            // pbYeniSifre
            // 
            pbYeniSifre.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifre.Location = new Point(487, 299);
            pbYeniSifre.Name = "pbYeniSifre";
            pbYeniSifre.Size = new Size(39, 27);
            pbYeniSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifre.TabIndex = 31;
            pbYeniSifre.TabStop = false;
            pbYeniSifre.Click += pbYeniSifre_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(223, 414);
            btnKayitOl.Margin = new Padding(3, 4, 3, 4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(150, 45);
            btnKayitOl.TabIndex = 30;
            btnKayitOl.Text = "Şifre Güncelle";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtGuvenlikYaniti
            // 
            txtGuvenlikYaniti.Location = new Point(274, 243);
            txtGuvenlikYaniti.Margin = new Padding(3, 4, 3, 4);
            txtGuvenlikYaniti.Name = "txtGuvenlikYaniti";
            txtGuvenlikYaniti.Size = new Size(202, 27);
            txtGuvenlikYaniti.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 243);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 28;
            label6.Text = "Güvenlik Sorusu Yanıtı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 188);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 27;
            label5.Text = "Güvenlik Sorusu:";
            // 
            // cmbGuvenlikSorusu
            // 
            cmbGuvenlikSorusu.FormattingEnabled = true;
            cmbGuvenlikSorusu.Items.AddRange(new object[] { "İlk Evcil Hayvanınızın Adı?", "En Sevdiğiniz Öğretmeniniz?", "Annenizin Doğum Yılı?" });
            cmbGuvenlikSorusu.Location = new Point(274, 187);
            cmbGuvenlikSorusu.Margin = new Padding(3, 4, 3, 4);
            cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            cmbGuvenlikSorusu.Size = new Size(202, 28);
            cmbGuvenlikSorusu.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 353);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 25;
            label3.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(274, 353);
            txtYeniSifreTekrar.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(202, 27);
            txtYeniSifreTekrar.TabIndex = 24;
            txtYeniSifreTekrar.TextChanged += txtYeniSifreTekrar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 299);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 23;
            label2.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(274, 299);
            txtYeniSifre.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(202, 27);
            txtYeniSifre.TabIndex = 22;
            txtYeniSifre.TextChanged += txtYeniSifre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 132);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 21;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(274, 132);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(202, 27);
            txtKullaniciAdi.TabIndex = 20;
            // 
            // label4
            // 
            label4.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(143, 5);
            label4.Name = "label4";
            label4.Size = new Size(358, 115);
            label4.TabIndex = 68;
            label4.Text = "ŞİFREMİ UNUTTUM";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.ImageKey = "passwordline - Kopya.jpg";
            label7.ImageList = ımageList1;
            label7.Location = new Point(-1, -4);
            label7.Name = "label7";
            label7.Size = new Size(108, 314);
            label7.TabIndex = 69;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "passwordline - Kopya.jpg");
            ımageList1.Images.SetKeyName(1, "passwordline.jpg");
            // 
            // label8
            // 
            label8.ImageKey = "passwordline - Kopya.jpg";
            label8.ImageList = ımageList1;
            label8.Location = new Point(-1, 310);
            label8.Name = "label8";
            label8.Size = new Size(108, 251);
            label8.TabIndex = 69;
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(538, 559);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(btnGiris);
            Controls.Add(pbYeniSifreTekrar);
            Controls.Add(pbYeniSifre);
            Controls.Add(btnKayitOl);
            Controls.Add(txtGuvenlikYaniti);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbGuvenlikSorusu);
            Controls.Add(label3);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(label2);
            Controls.Add(txtYeniSifre);
            Controls.Add(label1);
            Controls.Add(txtKullaniciAdi);
            Name = "SifremiUnuttum";
            Text = "SifremiUnuttum";
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private PictureBox pbYeniSifreTekrar;
        private PictureBox pbYeniSifre;
        private Button btnKayitOl;
        private TextBox txtGuvenlikYaniti;
        private Label label6;
        private Label label5;
        private ComboBox cmbGuvenlikSorusu;
        private Label label3;
        private TextBox txtYeniSifreTekrar;
        private Label label2;
        private TextBox txtYeniSifre;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private Label label4;
        private Label label7;
        private ImageList ımageList1;
        private Label label8;
    }
}