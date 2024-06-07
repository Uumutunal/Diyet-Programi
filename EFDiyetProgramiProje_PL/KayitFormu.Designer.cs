namespace EFDiyetProgramiProje_PL
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
            btnGiris = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnKayitOl = new Button();
            txtGuvenlikYaniti = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cmbGuvenlikSorusu = new ComboBox();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(251, 294);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(151, 34);
            btnGiris.TabIndex = 63;
            btnGiris.Text = "Giriş Ekranına Dön";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pictureBox2.Location = new Point(368, 136);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pictureBox1.Location = new Point(368, 89);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(41, 294);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(151, 34);
            btnKayitOl.TabIndex = 60;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtGuvenlikYaniti
            // 
            txtGuvenlikYaniti.Location = new Point(179, 236);
            txtGuvenlikYaniti.Name = "txtGuvenlikYaniti";
            txtGuvenlikYaniti.Size = new Size(177, 23);
            txtGuvenlikYaniti.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 238);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 58;
            label6.Text = "Güvenlik Sorusu Yanıtı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 190);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 57;
            label5.Text = "Güvenlik Sorusu:";
            // 
            // cmbGuvenlikSorusu
            // 
            cmbGuvenlikSorusu.FormattingEnabled = true;
            cmbGuvenlikSorusu.Items.AddRange(new object[] { "İlk Evcil Hayvanınızın Adı?", "En Sevdiğiniz Öğretmeniniz?", "Annenizin Doğum Yılı?" });
            cmbGuvenlikSorusu.Location = new Point(179, 188);
            cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            cmbGuvenlikSorusu.Size = new Size(177, 23);
            cmbGuvenlikSorusu.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 139);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 55;
            label3.Text = "Şifre Tekrar:";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(179, 136);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(177, 23);
            txtSifreTekrar.TabIndex = 54;
            txtSifreTekrar.TextChanged += txtSifreTekrar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 92);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 53;
            label2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(179, 89);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(177, 23);
            txtSifre.TabIndex = 52;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 51;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(179, 42);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(177, 23);
            txtKullaniciAdi.TabIndex = 50;
            // 
            // KayitFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 362);
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
            Name = "KayitFormu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnKayitOl;
        private TextBox txtGuvenlikYaniti;
        private Label label6;
        private Label label5;
        private ComboBox cmbGuvenlikSorusu;
        private Label label3;
        private TextBox txtSifreTekrar;
        private Label label2;
        private TextBox txtSifre;
        private Label label1;
        private TextBox txtKullaniciAdi;
    }
}