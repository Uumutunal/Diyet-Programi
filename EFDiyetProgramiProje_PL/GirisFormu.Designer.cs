namespace EFDiyetProgramiProje_PL
{
    partial class GirisFormu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnSifremiUnuttum = new Button();
            btnKayitOl = new Button();
            chkSifreyiGoster = new CheckBox();
            label3 = new Label();
            ımageList1 = new ImageList(components);
            label4 = new Label();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(96, 120);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(177, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 122);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 165);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(96, 163);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(177, 23);
            txtSifre.TabIndex = 2;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(60, 260);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(177, 23);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.Location = new Point(60, 299);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(177, 23);
            btnSifremiUnuttum.TabIndex = 5;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = true;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.ImageAlign = ContentAlignment.MiddleRight;
            btnKayitOl.ImageKey = "(none)";
            btnKayitOl.Location = new Point(169, 76);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(102, 22);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.CheckAlign = ContentAlignment.MiddleRight;
            chkSifreyiGoster.Location = new Point(169, 200);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(95, 19);
            chkSifreyiGoster.TabIndex = 7;
            chkSifreyiGoster.Text = "Şifreyi Göster";
            chkSifreyiGoster.UseVisualStyleBackColor = true;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 79);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 10;
            label3.Text = "Henüz üye değil misin?";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "kullanıcıgiriş.jpg");
            // 
            // label4
            // 
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.ImageKey = "kullanıcıgiriş.jpg";
            label4.ImageList = ımageList1;
            label4.Location = new Point(-7, 1);
            label4.Name = "label4";
            label4.Size = new Size(298, 62);
            label4.TabIndex = 11;
            label4.Text = "KULLANICI GİRİŞİ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(288, 342);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(btnKayitOl);
            Controls.Add(btnSifremiUnuttum);
            Controls.Add(btnGiris);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            Controls.Add(txtKullaniciAdi);
            Name = "GirisFormu";
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private Label label1;
        private Label label2;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnSifremiUnuttum;
        private Button btnKayitOl;
        private CheckBox chkSifreyiGoster;
        private Label label3;
        private ImageList ımageList1;
        private Label label4;
    }
}
