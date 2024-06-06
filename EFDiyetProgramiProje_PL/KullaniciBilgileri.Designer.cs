namespace EFDiyetProgramiProje_PL
{
    partial class KullaniciBilgileri
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
            txtDogumTarihi = new TextBox();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnKullaniciBilgiGuncelle = new Button();
            label1 = new Label();
            txtHedefKilo = new TextBox();
            cmbCinsiyet = new ComboBox();
            label2 = new Label();
            lblKullaniciAdi = new Label();
            SuspendLayout();
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.Location = new Point(282, 204);
            txtDogumTarihi.Margin = new Padding(3, 4, 3, 4);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(119, 27);
            txtDogumTarihi.TabIndex = 20;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(282, 141);
            txtKilo.Margin = new Padding(3, 4, 3, 4);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(119, 27);
            txtKilo.TabIndex = 18;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(282, 79);
            txtBoy.Margin = new Padding(3, 4, 3, 4);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(119, 27);
            txtBoy.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 267);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 27;
            label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 204);
            label6.Name = "label6";
            label6.Size = new Size(183, 20);
            label6.TabIndex = 26;
            label6.Text = "Doğum Tarihi (gg.aa.yyyy):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 141);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 25;
            label7.Text = "Kilo (kg) :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 79);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 24;
            label8.Text = "Boy (cm):";
            // 
            // btnKullaniciBilgiGuncelle
            // 
            btnKullaniciBilgiGuncelle.Location = new Point(94, 396);
            btnKullaniciBilgiGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKullaniciBilgiGuncelle.Name = "btnKullaniciBilgiGuncelle";
            btnKullaniciBilgiGuncelle.Size = new Size(307, 64);
            btnKullaniciBilgiGuncelle.TabIndex = 32;
            btnKullaniciBilgiGuncelle.Text = "Bilgilerimi Güncelle";
            btnKullaniciBilgiGuncelle.UseVisualStyleBackColor = true;
            btnKullaniciBilgiGuncelle.Click += btnKullaniciBilgiGuncelle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 336);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 34;
            label1.Text = "Hedef Kilo (kg):";
            // 
            // txtHedefKilo
            // 
            txtHedefKilo.Location = new Point(282, 336);
            txtHedefKilo.Margin = new Padding(3, 4, 3, 4);
            txtHedefKilo.Name = "txtHedefKilo";
            txtHedefKilo.Size = new Size(119, 27);
            txtHedefKilo.TabIndex = 33;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(282, 267);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(119, 28);
            cmbCinsiyet.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(95, 28);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 37;
            label2.Text = "Kullanıcı Adı:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblKullaniciAdi.Location = new Point(282, 28);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(0, 23);
            lblKullaniciAdi.TabIndex = 38;
            // 
            // KullaniciBilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 573);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(cmbCinsiyet);
            Controls.Add(label1);
            Controls.Add(txtHedefKilo);
            Controls.Add(btnKullaniciBilgiGuncelle);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtDogumTarihi);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KullaniciBilgileri";
            Text = "KullaniciBilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDogumTarihi;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnKullaniciBilgiGuncelle;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1;
        private TextBox txtHedefKilo;
        private ComboBox cmbCinsiyet;
        private Label label2;
        private Label lblKullaniciAdi;
    }
}