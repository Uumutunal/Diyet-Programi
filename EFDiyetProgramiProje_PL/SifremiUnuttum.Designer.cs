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
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(308, 337);
            btnGiris.Margin = new Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(173, 45);
            btnGiris.TabIndex = 33;
            btnGiris.Text = "Giriş Ekranına Dön";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // pbYeniSifreTekrar
            // 
            pbYeniSifreTekrar.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifreTekrar.Location = new Point(442, 265);
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
            pbYeniSifre.Location = new Point(442, 210);
            pbYeniSifre.Name = "pbYeniSifre";
            pbYeniSifre.Size = new Size(39, 27);
            pbYeniSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifre.TabIndex = 31;
            pbYeniSifre.TabStop = false;
            pbYeniSifre.Click += pbYeniSifre_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(68, 337);
            btnKayitOl.Margin = new Padding(3, 4, 3, 4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(173, 45);
            btnKayitOl.TabIndex = 30;
            btnKayitOl.Text = "Şifre Güncelle";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtGuvenlikYaniti
            // 
            txtGuvenlikYaniti.Location = new Point(230, 155);
            txtGuvenlikYaniti.Margin = new Padding(3, 4, 3, 4);
            txtGuvenlikYaniti.Name = "txtGuvenlikYaniti";
            txtGuvenlikYaniti.Size = new Size(202, 27);
            txtGuvenlikYaniti.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 155);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 28;
            label6.Text = "Güvenlik Sorusu Yanıtı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 100);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 27;
            label5.Text = "Güvenlik Sorusu:";
            // 
            // cmbGuvenlikSorusu
            // 
            cmbGuvenlikSorusu.FormattingEnabled = true;
            cmbGuvenlikSorusu.Items.AddRange(new object[] { "İlk Evcil Hayvanınızın Adı?", "En Sevdiğiniz Öğretmeniniz?", "Annenizin Doğum Yılı?" });
            cmbGuvenlikSorusu.Location = new Point(230, 99);
            cmbGuvenlikSorusu.Margin = new Padding(3, 4, 3, 4);
            cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            cmbGuvenlikSorusu.Size = new Size(202, 28);
            cmbGuvenlikSorusu.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 265);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 25;
            label3.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(230, 265);
            txtYeniSifreTekrar.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(202, 27);
            txtYeniSifreTekrar.TabIndex = 24;
            txtYeniSifreTekrar.TextChanged += txtYeniSifreTekrar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 210);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 23;
            label2.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(230, 210);
            txtYeniSifre.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(202, 27);
            txtYeniSifre.TabIndex = 22;
            txtYeniSifre.TextChanged += txtYeniSifre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 21;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(230, 44);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(202, 27);
            txtKullaniciAdi.TabIndex = 20;
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
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
    }
}