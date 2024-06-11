namespace EFDiyetProgramiProje_PL
{
    partial class KullaniciGuncelle
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
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnKullaniciPanelineDon = new Button();
            pbYeniSifreTekrar = new PictureBox();
            pbYeniSifre = new PictureBox();
            btnKullaniciGuncelle = new Button();
            txtYeniGuvenlikSorusuYaniti = new TextBox();
            label4 = new Label();
            label7 = new Label();
            cmbYeniGuvenlikSorusu = new ComboBox();
            label8 = new Label();
            txtYeniSifreTekrar = new TextBox();
            label9 = new Label();
            txtYeniSifre = new TextBox();
            label10 = new Label();
            txtYeniKullaniciAdi = new TextBox();
            pbSifre = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSifre).BeginInit();
            SuspendLayout();
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSifre.Location = new Point(76, 101);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 65;
            lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(245, 101);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(177, 23);
            txtSifre.TabIndex = 64;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnKullaniciPanelineDon
            // 
            btnKullaniciPanelineDon.Location = new Point(313, 364);
            btnKullaniciPanelineDon.Name = "btnKullaniciPanelineDon";
            btnKullaniciPanelineDon.Size = new Size(151, 34);
            btnKullaniciPanelineDon.TabIndex = 63;
            btnKullaniciPanelineDon.Text = "Kullanıcı Paneline Dön";
            btnKullaniciPanelineDon.UseVisualStyleBackColor = true;
            btnKullaniciPanelineDon.Click += btnKullaniciPanelineDon_Click;
            // 
            // pbYeniSifreTekrar
            // 
            pbYeniSifreTekrar.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifreTekrar.Location = new Point(430, 310);
            pbYeniSifreTekrar.Margin = new Padding(3, 2, 3, 2);
            pbYeniSifreTekrar.Name = "pbYeniSifreTekrar";
            pbYeniSifreTekrar.Size = new Size(34, 20);
            pbYeniSifreTekrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifreTekrar.TabIndex = 62;
            pbYeniSifreTekrar.TabStop = false;
            pbYeniSifreTekrar.Click += pbYeniSifreTekrar_Click;
            // 
            // pbYeniSifre
            // 
            pbYeniSifre.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifre.Location = new Point(430, 268);
            pbYeniSifre.Margin = new Padding(3, 2, 3, 2);
            pbYeniSifre.Name = "pbYeniSifre";
            pbYeniSifre.Size = new Size(34, 20);
            pbYeniSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pbYeniSifre.TabIndex = 61;
            pbYeniSifre.TabStop = false;
            pbYeniSifre.Click += pbYeniSifre_Click;
            // 
            // btnKullaniciGuncelle
            // 
            btnKullaniciGuncelle.Location = new Point(76, 364);
            btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            btnKullaniciGuncelle.Size = new Size(164, 34);
            btnKullaniciGuncelle.TabIndex = 60;
            btnKullaniciGuncelle.Text = "Kullanıcı Bilgisi Güncelle";
            btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            btnKullaniciGuncelle.Click += btnKullaniciGuncelle_Click;
            // 
            // txtYeniGuvenlikSorusuYaniti
            // 
            txtYeniGuvenlikSorusuYaniti.Location = new Point(245, 227);
            txtYeniGuvenlikSorusuYaniti.Name = "txtYeniGuvenlikSorusuYaniti";
            txtYeniGuvenlikSorusuYaniti.Size = new Size(177, 23);
            txtYeniGuvenlikSorusuYaniti.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 227);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 58;
            label4.Text = "Yeni Güvenlik Sorusu Yanıtı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 186);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 57;
            label7.Text = "Yeni Güvenlik Sorusu:";
            // 
            // cmbYeniGuvenlikSorusu
            // 
            cmbYeniGuvenlikSorusu.FormattingEnabled = true;
            cmbYeniGuvenlikSorusu.Items.AddRange(new object[] { "İlk Evcil Hayvanınızın Adı?", "En Sevdiğiniz Öğretmeniniz?", "Annenizin Doğum Yılı?" });
            cmbYeniGuvenlikSorusu.Location = new Point(245, 185);
            cmbYeniGuvenlikSorusu.Name = "cmbYeniGuvenlikSorusu";
            cmbYeniGuvenlikSorusu.Size = new Size(177, 23);
            cmbYeniGuvenlikSorusu.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 310);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 55;
            label8.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(245, 310);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(177, 23);
            txtYeniSifreTekrar.TabIndex = 54;
            txtYeniSifreTekrar.TextChanged += txtYeniSifreTekrar_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 268);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 53;
            label9.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(245, 268);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(177, 23);
            txtYeniSifre.TabIndex = 52;
            txtYeniSifre.TextChanged += txtYeniSifre_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 144);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 51;
            label10.Text = "Yeni Kullanıcı Adı:";
            // 
            // txtYeniKullaniciAdi
            // 
            txtYeniKullaniciAdi.Location = new Point(245, 144);
            txtYeniKullaniciAdi.Name = "txtYeniKullaniciAdi";
            txtYeniKullaniciAdi.Size = new Size(177, 23);
            txtYeniKullaniciAdi.TabIndex = 50;
            // 
            // pbSifre
            // 
            pbSifre.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbSifre.Location = new Point(430, 101);
            pbSifre.Margin = new Padding(3, 2, 3, 2);
            pbSifre.Name = "pbSifre";
            pbSifre.Size = new Size(34, 20);
            pbSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pbSifre.TabIndex = 66;
            pbSifre.TabStop = false;
            pbSifre.Click += pbSifre_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(76, 9);
            label3.Name = "label3";
            label3.Size = new Size(264, 86);
            label3.TabIndex = 67;
            label3.Text = "HESAP BİLGİLERİ         GÜNCELLE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KullaniciGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 441);
            Controls.Add(label3);
            Controls.Add(pbSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtSifre);
            Controls.Add(btnKullaniciPanelineDon);
            Controls.Add(pbYeniSifreTekrar);
            Controls.Add(pbYeniSifre);
            Controls.Add(btnKullaniciGuncelle);
            Controls.Add(txtYeniGuvenlikSorusuYaniti);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(cmbYeniGuvenlikSorusu);
            Controls.Add(label8);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(label9);
            Controls.Add(txtYeniSifre);
            Controls.Add(label10);
            Controls.Add(txtYeniKullaniciAdi);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KullaniciGuncelle";
            Text = "KullaniciGuncelle";
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSifre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSifre;
        private TextBox txtSifre;
        private Button btnKullaniciPanelineDon;
        private PictureBox pbYeniSifreTekrar;
        private PictureBox pbYeniSifre;
        private Button btnKullaniciGuncelle;
        private TextBox txtYeniGuvenlikSorusuYaniti;
        private Label label4;
        private Label label7;
        private ComboBox cmbYeniGuvenlikSorusu;
        private Label label8;
        private TextBox txtYeniSifreTekrar;
        private Label label9;
        private TextBox txtYeniSifre;
        private Label label10;
        private TextBox txtYeniKullaniciAdi;
        private PictureBox pbSifre;
        private Label label3;
    }
}