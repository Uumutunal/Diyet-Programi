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
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(273, 322);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(151, 34);
            btnGiris.TabIndex = 33;
            btnGiris.Text = "Giriş Ekranına Dön";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // pbYeniSifreTekrar
            // 
            pbYeniSifreTekrar.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifreTekrar.Location = new Point(390, 268);
            pbYeniSifreTekrar.Margin = new Padding(3, 2, 3, 2);
            pbYeniSifreTekrar.Name = "pbYeniSifreTekrar";
            pbYeniSifreTekrar.Size = new Size(34, 20);
            pbYeniSifreTekrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifreTekrar.TabIndex = 32;
            pbYeniSifreTekrar.TabStop = false;
            pbYeniSifreTekrar.Click += pbYeniSifreTekrar_Click;
            // 
            // pbYeniSifre
            // 
            pbYeniSifre.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifre.Location = new Point(390, 227);
            pbYeniSifre.Margin = new Padding(3, 2, 3, 2);
            pbYeniSifre.Name = "pbYeniSifre";
            pbYeniSifre.Size = new Size(34, 20);
            pbYeniSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifre.TabIndex = 31;
            pbYeniSifre.TabStop = false;
            pbYeniSifre.Click += pbYeniSifre_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(63, 322);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(151, 34);
            btnKayitOl.TabIndex = 30;
            btnKayitOl.Text = "Şifre Güncelle";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtGuvenlikYaniti
            // 
            txtGuvenlikYaniti.Location = new Point(204, 185);
            txtGuvenlikYaniti.Name = "txtGuvenlikYaniti";
            txtGuvenlikYaniti.Size = new Size(177, 23);
            txtGuvenlikYaniti.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 185);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 28;
            label6.Text = "Güvenlik Sorusu Yanıtı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 144);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 27;
            label5.Text = "Güvenlik Sorusu:";
            // 
            // cmbGuvenlikSorusu
            // 
            cmbGuvenlikSorusu.FormattingEnabled = true;
            cmbGuvenlikSorusu.Items.AddRange(new object[] { "İlk Evcil Hayvanınızın Adı?", "En Sevdiğiniz Öğretmeniniz?", "Annenizin Doğum Yılı?" });
            cmbGuvenlikSorusu.Location = new Point(204, 143);
            cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            cmbGuvenlikSorusu.Size = new Size(177, 23);
            cmbGuvenlikSorusu.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 268);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 25;
            label3.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(204, 268);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(177, 23);
            txtYeniSifreTekrar.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 227);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 23;
            label2.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(204, 227);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(177, 23);
            txtYeniSifre.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 102);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 21;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(204, 102);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(177, 23);
            txtKullaniciAdi.TabIndex = 20;
            // 
            // label4
            // 
            label4.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(54, 9);
            label4.Name = "label4";
            label4.Size = new Size(313, 86);
            label4.TabIndex = 68;
            label4.Text = "ŞİFREMİ UNUTTUM";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 394);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}