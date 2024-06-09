namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiKontrolPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiKontrolPaneli));
            label5 = new Label();
            btnSifreDegistir = new Button();
            ımageList1 = new ImageList(components);
            btnYemekSilme = new Button();
            btnRaporGoster = new Button();
            btnKullanicilariGoruntule = new Button();
            btnYemekGuncelleme = new Button();
            btnYemekEkleme = new Button();
            btnOgunSilme = new Button();
            btnOgunGuncelleme = new Button();
            btnOgunEkleme = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(91, 19);
            label5.Name = "label5";
            label5.Size = new Size(308, 54);
            label5.TabIndex = 46;
            label5.Text = "YÖNETİCİ EKRANI";
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSifreDegistir.ImageAlign = ContentAlignment.TopCenter;
            btnSifreDegistir.ImageKey = "icons8-password-50.png";
            btnSifreDegistir.ImageList = ımageList1;
            btnSifreDegistir.Location = new Point(336, 392);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(129, 120);
            btnSifreDegistir.TabIndex = 37;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.TextAlign = ContentAlignment.BottomCenter;
            btnSifreDegistir.UseVisualStyleBackColor = true;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-cooking-50.png");
            ımageList1.Images.SetKeyName(1, "icons8-dead-food-50.png");
            ımageList1.Images.SetKeyName(2, "icons8-report-50.png");
            ımageList1.Images.SetKeyName(3, "icons8-users-50.png");
            ımageList1.Images.SetKeyName(4, "icons8-password-50.png");
            ımageList1.Images.SetKeyName(5, "icons8-help-50.png");
            ımageList1.Images.SetKeyName(6, "noun-waste-food-2266947.png");
            ımageList1.Images.SetKeyName(7, "icons8-meal-50 (1).png");
            ımageList1.Images.SetKeyName(8, "icons8-meal-50.png");
            ımageList1.Images.SetKeyName(9, "icons8-food-donor-50.png");
            ımageList1.Images.SetKeyName(10, "icons8-no-food-50.png");
            // 
            // btnYemekSilme
            // 
            btnYemekSilme.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYemekSilme.ImageAlign = ContentAlignment.TopCenter;
            btnYemekSilme.ImageKey = "icons8-no-food-50.png";
            btnYemekSilme.ImageList = ımageList1;
            btnYemekSilme.Location = new Point(336, 255);
            btnYemekSilme.Name = "btnYemekSilme";
            btnYemekSilme.Size = new Size(129, 120);
            btnYemekSilme.TabIndex = 38;
            btnYemekSilme.Text = "   Yemek     Silme";
            btnYemekSilme.TextAlign = ContentAlignment.BottomCenter;
            btnYemekSilme.UseVisualStyleBackColor = true;
            btnYemekSilme.Click += btnYemekSilme_Click;
            // 
            // btnRaporGoster
            // 
            btnRaporGoster.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRaporGoster.ImageAlign = ContentAlignment.TopCenter;
            btnRaporGoster.ImageKey = "icons8-report-50.png";
            btnRaporGoster.ImageList = ımageList1;
            btnRaporGoster.Location = new Point(186, 392);
            btnRaporGoster.Name = "btnRaporGoster";
            btnRaporGoster.Size = new Size(129, 120);
            btnRaporGoster.TabIndex = 39;
            btnRaporGoster.Text = "Rapor Göster";
            btnRaporGoster.TextAlign = ContentAlignment.BottomCenter;
            btnRaporGoster.UseVisualStyleBackColor = true;
            btnRaporGoster.Click += btnRaporGoster_Click;
            // 
            // btnKullanicilariGoruntule
            // 
            btnKullanicilariGoruntule.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKullanicilariGoruntule.ImageAlign = ContentAlignment.TopCenter;
            btnKullanicilariGoruntule.ImageKey = "icons8-users-50.png";
            btnKullanicilariGoruntule.ImageList = ımageList1;
            btnKullanicilariGoruntule.Location = new Point(40, 392);
            btnKullanicilariGoruntule.Name = "btnKullanicilariGoruntule";
            btnKullanicilariGoruntule.Size = new Size(129, 120);
            btnKullanicilariGoruntule.TabIndex = 40;
            btnKullanicilariGoruntule.Text = "Kullanıcıları Görüntüle";
            btnKullanicilariGoruntule.TextAlign = ContentAlignment.BottomCenter;
            btnKullanicilariGoruntule.UseVisualStyleBackColor = true;
            btnKullanicilariGoruntule.Click += btnKullanicilariGoruntule_Click;
            // 
            // btnYemekGuncelleme
            // 
            btnYemekGuncelleme.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYemekGuncelleme.ImageAlign = ContentAlignment.TopCenter;
            btnYemekGuncelleme.ImageKey = "icons8-food-donor-50.png";
            btnYemekGuncelleme.ImageList = ımageList1;
            btnYemekGuncelleme.Location = new Point(186, 255);
            btnYemekGuncelleme.Name = "btnYemekGuncelleme";
            btnYemekGuncelleme.Size = new Size(129, 120);
            btnYemekGuncelleme.TabIndex = 41;
            btnYemekGuncelleme.Text = "Yemek Güncelleme";
            btnYemekGuncelleme.TextAlign = ContentAlignment.BottomCenter;
            btnYemekGuncelleme.UseVisualStyleBackColor = true;
            btnYemekGuncelleme.Click += btnYemekGuncelleme_Click;
            // 
            // btnYemekEkleme
            // 
            btnYemekEkleme.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYemekEkleme.ImageAlign = ContentAlignment.TopCenter;
            btnYemekEkleme.ImageKey = "icons8-cooking-50.png";
            btnYemekEkleme.ImageList = ımageList1;
            btnYemekEkleme.Location = new Point(40, 255);
            btnYemekEkleme.Name = "btnYemekEkleme";
            btnYemekEkleme.Size = new Size(129, 120);
            btnYemekEkleme.TabIndex = 42;
            btnYemekEkleme.Text = "Yemek Ekleme";
            btnYemekEkleme.TextAlign = ContentAlignment.BottomCenter;
            btnYemekEkleme.UseVisualStyleBackColor = true;
            btnYemekEkleme.Click += btnYemekEkleme_Click;
            // 
            // btnOgunSilme
            // 
            btnOgunSilme.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunSilme.ImageAlign = ContentAlignment.TopCenter;
            btnOgunSilme.ImageKey = "icons8-dead-food-50.png";
            btnOgunSilme.ImageList = ımageList1;
            btnOgunSilme.Location = new Point(336, 105);
            btnOgunSilme.Name = "btnOgunSilme";
            btnOgunSilme.Size = new Size(129, 120);
            btnOgunSilme.TabIndex = 43;
            btnOgunSilme.Text = "    Öğün       Silme";
            btnOgunSilme.TextAlign = ContentAlignment.BottomCenter;
            btnOgunSilme.UseVisualStyleBackColor = true;
            btnOgunSilme.Click += btnOgunSilme_Click;
            // 
            // btnOgunGuncelleme
            // 
            btnOgunGuncelleme.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunGuncelleme.ImageAlign = ContentAlignment.TopCenter;
            btnOgunGuncelleme.ImageKey = "icons8-meal-50 (1).png";
            btnOgunGuncelleme.ImageList = ımageList1;
            btnOgunGuncelleme.Location = new Point(186, 105);
            btnOgunGuncelleme.Name = "btnOgunGuncelleme";
            btnOgunGuncelleme.Size = new Size(129, 120);
            btnOgunGuncelleme.TabIndex = 44;
            btnOgunGuncelleme.Text = "Öğün Güncelleme";
            btnOgunGuncelleme.TextAlign = ContentAlignment.BottomCenter;
            btnOgunGuncelleme.UseVisualStyleBackColor = true;
            btnOgunGuncelleme.Click += btnOgunGuncelleme_Click;
            // 
            // btnOgunEkleme
            // 
            btnOgunEkleme.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunEkleme.ImageAlign = ContentAlignment.TopCenter;
            btnOgunEkleme.ImageKey = "icons8-meal-50.png";
            btnOgunEkleme.ImageList = ımageList1;
            btnOgunEkleme.Location = new Point(40, 105);
            btnOgunEkleme.Name = "btnOgunEkleme";
            btnOgunEkleme.Size = new Size(129, 120);
            btnOgunEkleme.TabIndex = 45;
            btnOgunEkleme.Text = "Öğün Ekleme";
            btnOgunEkleme.TextAlign = ContentAlignment.BottomCenter;
            btnOgunEkleme.UseVisualStyleBackColor = true;
            btnOgunEkleme.Click += btnOgunEkleme_Click;
            // 
            // YoneticiKontrolPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 534);
            Controls.Add(label5);
            Controls.Add(btnSifreDegistir);
            Controls.Add(btnYemekSilme);
            Controls.Add(btnRaporGoster);
            Controls.Add(btnKullanicilariGoruntule);
            Controls.Add(btnYemekGuncelleme);
            Controls.Add(btnYemekEkleme);
            Controls.Add(btnOgunSilme);
            Controls.Add(btnOgunGuncelleme);
            Controls.Add(btnOgunEkleme);
            Name = "YoneticiKontrolPaneli";
            Text = "YoneticiKontrolPaneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button9;
        private Button button6;
        private ImageList ımageList1;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnOgunEkleme;
        private Button btnOgunGuncelleme;
        private Button OgunEkleme;
        private Button btnSifreDegistir;
        private Button btnYemekSilme;
        private Button btnRaporGoster;
        private Button btnKullanicilariGoruntule;
        private Button btnYemekGuncelleme;
        private Button btnYemekEkleme;
        private Button btnOgunSilme;
    }
}