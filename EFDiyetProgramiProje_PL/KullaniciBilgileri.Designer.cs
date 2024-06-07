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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciBilgileri));
            cmbCinsiyet = new ComboBox();
            label1 = new Label();
            txtHedefKilo = new TextBox();
            btnKullaniciBilgiGuncelle = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDogumTarihi = new TextBox();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            ımageList1 = new ImageList(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(224, 242);
            cmbCinsiyet.Margin = new Padding(3, 2, 3, 2);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(105, 23);
            cmbCinsiyet.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 293);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 45;
            label1.Text = "Hedef Kilo (kg):";
            // 
            // txtHedefKilo
            // 
            txtHedefKilo.Location = new Point(224, 293);
            txtHedefKilo.Name = "txtHedefKilo";
            txtHedefKilo.Size = new Size(105, 23);
            txtHedefKilo.TabIndex = 44;
            // 
            // btnKullaniciBilgiGuncelle
            // 
            btnKullaniciBilgiGuncelle.Location = new Point(211, 334);
            btnKullaniciBilgiGuncelle.Name = "btnKullaniciBilgiGuncelle";
            btnKullaniciBilgiGuncelle.Size = new Size(152, 32);
            btnKullaniciBilgiGuncelle.TabIndex = 43;
            btnKullaniciBilgiGuncelle.Text = "Bilgilerimi Güncelle";
            btnKullaniciBilgiGuncelle.UseVisualStyleBackColor = true;
            btnKullaniciBilgiGuncelle.Click += btnKullaniciBilgiGuncelle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 242);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 42;
            label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 194);
            label6.Name = "label6";
            label6.Size = new Size(148, 15);
            label6.TabIndex = 41;
            label6.Text = "Doğum Tarihi (gg.aa.yyyy):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 147);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 40;
            label7.Text = "Kilo (kg) :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 100);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 39;
            label8.Text = "Boy (cm):";
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.Location = new Point(224, 194);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(105, 23);
            txtDogumTarihi.TabIndex = 38;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(224, 147);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(105, 23);
            txtKilo.TabIndex = 37;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(224, 100);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(105, 23);
            txtBoy.TabIndex = 36;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "bilgilerigüncelle.jpg");
            ımageList1.Images.SetKeyName(1, "thumbnail_image0.jpg");
            // 
            // label2
            // 
            label2.ImageKey = "bilgilerigüncelle.jpg";
            label2.ImageList = ımageList1;
            label2.Location = new Point(247, 7);
            label2.Name = "label2";
            label2.Size = new Size(151, 76);
            label2.TabIndex = 47;
            // 
            // label3
            // 
            label3.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(27, 7);
            label3.Name = "label3";
            label3.Size = new Size(203, 86);
            label3.TabIndex = 48;
            label3.Text = "BİLGİLERİ         GÜNCELLE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.ImageKey = "thumbnail_image0.jpg";
            label4.ImageList = ımageList1;
            label4.Location = new Point(-4, 308);
            label4.Name = "label4";
            label4.Size = new Size(151, 76);
            label4.TabIndex = 47;
            // 
            // KullaniciBilgileri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(395, 385);
            Controls.Add(label3);
            Controls.Add(label4);
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
            Name = "KullaniciBilgileri";
            Text = "KullaniciBilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCinsiyet;
        private Label label1;
        private TextBox txtHedefKilo;
        private Button btnKullaniciBilgiGuncelle;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDogumTarihi;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private ImageList ımageList1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}