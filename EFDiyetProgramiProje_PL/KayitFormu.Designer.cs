﻿namespace EFDiyetProgramiProje_PL
{
    partial class KayitFormu
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
            label2 = new Label();
            txtSifre = new TextBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            cmbGuvenlikSorusu = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtGuvenlikYaniti = new TextBox();
            btnKayitOl = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnGiris = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 139);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 7;
            label2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(336, 136);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(202, 27);
            txtSifre.TabIndex = 6;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 76);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(336, 73);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(202, 27);
            txtKullaniciAdi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 202);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 9;
            label3.Text = "Şifre Tekrar:";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(336, 199);
            txtSifreTekrar.Margin = new Padding(3, 4, 3, 4);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(202, 27);
            txtSifreTekrar.TabIndex = 8;
            txtSifreTekrar.TextChanged += txtSifreTekrar_TextChanged;
            // 
            // cmbGuvenlikSorusu
            // 
            cmbGuvenlikSorusu.FormattingEnabled = true;
            cmbGuvenlikSorusu.Items.AddRange(new object[] { "İlk Evcil Hayvanınızın Adı?", "En Sevdiğiniz Öğretmeniniz?", "Annenizin Doğum Yılı?" });
            cmbGuvenlikSorusu.Location = new Point(336, 268);
            cmbGuvenlikSorusu.Margin = new Padding(3, 4, 3, 4);
            cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            cmbGuvenlikSorusu.Size = new Size(202, 28);
            cmbGuvenlikSorusu.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 271);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 13;
            label5.Text = "Güvenlik Sorusu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 334);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 14;
            label6.Text = "Güvenlik Sorusu Yanıtı:";
            // 
            // txtGuvenlikYaniti
            // 
            txtGuvenlikYaniti.Location = new Point(336, 331);
            txtGuvenlikYaniti.Margin = new Padding(3, 4, 3, 4);
            txtGuvenlikYaniti.Name = "txtGuvenlikYaniti";
            txtGuvenlikYaniti.Size = new Size(202, 27);
            txtGuvenlikYaniti.TabIndex = 15;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(178, 409);
            btnKayitOl.Margin = new Padding(3, 4, 3, 4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(173, 45);
            btnKayitOl.TabIndex = 16;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pictureBox1.Location = new Point(552, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pictureBox2.Location = new Point(552, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(418, 409);
            btnGiris.Margin = new Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(173, 45);
            btnGiris.TabIndex = 19;
            btnGiris.Text = "Giriş Ekranına Dön";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // KayitFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 617);
            Controls.Add(btnGiris);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnKayitOl);
            Controls.Add(txtGuvenlikYaniti);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbGuvenlikSorusu);
            Controls.Add(label3);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            Controls.Add(txtKullaniciAdi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KayitFormu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtSifre;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtSifreTekrar;
        private ComboBox cmbGuvenlikSorusu;
        private Label label5;
        private Label label6;
        private TextBox txtGuvenlikYaniti;
        private Button btnKayitOl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGiris;
    }
}