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
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            txtYeniSifre = new TextBox();
            label2 = new Label();
            txtYeniSifreTekrar = new TextBox();
            label3 = new Label();
            cmbGuvenlikSorusu = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtGuvenlikYaniti = new TextBox();
            btnKayitOl = new Button();
            pbYeniSifre = new PictureBox();
            pbYeniSifreTekrar = new PictureBox();
            label4 = new Label();
            btnGiris = new Button();
            label8 = new Label();
            label7 = new Label();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(310, 139);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(202, 27);
            txtKullaniciAdi.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 139);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 21;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(310, 306);
            txtYeniSifre.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(202, 27);
            txtYeniSifre.TabIndex = 22;
            txtYeniSifre.TextChanged += txtYeniSifre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 306);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 23;
            label2.Text = "Yeni Şifre:";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(310, 360);
            txtYeniSifreTekrar.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(202, 27);
            txtYeniSifreTekrar.TabIndex = 24;
            txtYeniSifreTekrar.TextChanged += txtYeniSifreTekrar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 360);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 25;
            label3.Text = "Yeni Şifre Tekrar:";
            // 
            // cmbGuvenlikSorusu
            // 
            cmbGuvenlikSorusu.FormattingEnabled = true;
            cmbGuvenlikSorusu.Items.AddRange(new object[] { "İlk Evcil Hayvanınızın Adı?", "En Sevdiğiniz Öğretmeniniz?", "Annenizin Doğum Yılı?" });
            cmbGuvenlikSorusu.Location = new Point(310, 194);
            cmbGuvenlikSorusu.Margin = new Padding(3, 4, 3, 4);
            cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            cmbGuvenlikSorusu.Size = new Size(202, 28);
            cmbGuvenlikSorusu.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 195);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 27;
            label5.Text = "Güvenlik Sorusu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 250);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 28;
            label6.Text = "Güvenlik Sorusu Yanıtı:";
            // 
            // txtGuvenlikYaniti
            // 
            txtGuvenlikYaniti.Location = new Point(310, 250);
            txtGuvenlikYaniti.Margin = new Padding(3, 4, 3, 4);
            txtGuvenlikYaniti.Name = "txtGuvenlikYaniti";
            txtGuvenlikYaniti.Size = new Size(202, 27);
            txtGuvenlikYaniti.TabIndex = 29;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(220, 415);
            btnKayitOl.Margin = new Padding(3, 4, 3, 4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(173, 45);
            btnKayitOl.TabIndex = 30;
            btnKayitOl.Text = "Şifre Güncelle";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // pbYeniSifre
            // 
            pbYeniSifre.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifre.Location = new Point(523, 306);
            pbYeniSifre.Name = "pbYeniSifre";
            pbYeniSifre.Size = new Size(39, 27);
            pbYeniSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifre.TabIndex = 31;
            pbYeniSifre.TabStop = false;
            pbYeniSifre.Click += pbYeniSifre_Click;
            // 
            // pbYeniSifreTekrar
            // 
            pbYeniSifreTekrar.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifreTekrar.Location = new Point(523, 360);
            pbYeniSifreTekrar.Name = "pbYeniSifreTekrar";
            pbYeniSifreTekrar.Size = new Size(39, 27);
            pbYeniSifreTekrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifreTekrar.TabIndex = 32;
            pbYeniSifreTekrar.TabStop = false;
            pbYeniSifreTekrar.Click += pbYeniSifreTekrar_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(139, 15);
            label4.Name = "label4";
            label4.Size = new Size(358, 115);
            label4.TabIndex = 68;
            label4.Text = "ŞİFREMİ UNUTTUM";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(220, 482);
            btnGiris.Margin = new Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(173, 45);
            btnGiris.TabIndex = 33;
            btnGiris.Text = "Giriş Ekranına Dön";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label8
            // 
            label8.ImageKey = "passwordline - Kopya.jpg";
            label8.ImageList = ımageList1;
            label8.Location = new Point(-7, 312);
            label8.Name = "label8";
            label8.Size = new Size(108, 251);
            label8.TabIndex = 70;
            // 
            // label7
            // 
            label7.ImageKey = "passwordline - Kopya.jpg";
            label7.ImageList = ımageList1;
            label7.Location = new Point(-7, -2);
            label7.Name = "label7";
            label7.Size = new Size(108, 314);
            label7.TabIndex = 71;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "passwordline - Kopya.jpg");
            ımageList1.Images.SetKeyName(1, "passwordline.jpg");
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 556);
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
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private Label label1;
        private TextBox txtYeniSifre;
        private Label label2;
        private TextBox txtYeniSifreTekrar;
        private Label label3;
        private ComboBox cmbGuvenlikSorusu;
        private Label label5;
        private Label label6;
        private TextBox txtGuvenlikYaniti;
        private Button btnKayitOl;
        private PictureBox pbYeniSifre;
        private PictureBox pbYeniSifreTekrar;
        private Label label4;
        private Button btnGiris;
        private Label label8;
        private Label label7;
        private ImageList ımageList1;
    }
}