namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiSifreDegistir));
            label1 = new Label();
            ımageList1 = new ImageList(components);
            label2 = new Label();
            label5 = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            txtYeniSifreTekrar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnSifreDegistir = new Button();
            pbEskiSifre = new PictureBox();
            pbYeniSifreTekrar = new PictureBox();
            pbYeniSifre = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbEskiSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ImageKey = "passwordline.jpg";
            label1.ImageList = ımageList1;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 303);
            label1.TabIndex = 0;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "passwordline - Kopya.jpg");
            ımageList1.Images.SetKeyName(1, "passwordline.jpg");
            // 
            // label2
            // 
            label2.ImageKey = "passwordline - Kopya.jpg";
            label2.ImageList = ımageList1;
            label2.Location = new Point(417, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 303);
            label2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(82, 9);
            label5.Name = "label5";
            label5.Size = new Size(283, 54);
            label5.TabIndex = 29;
            label5.Text = "ŞİFRE DEĞİŞTİR";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(193, 90);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.Size = new Size(172, 27);
            txtEskiSifre.TabIndex = 30;
            txtEskiSifre.TextChanged += txtEskiSifre_TextChanged;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(193, 134);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(172, 27);
            txtYeniSifre.TabIndex = 30;
            txtYeniSifre.TextChanged += txtYeniSifre_TextChanged;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(193, 181);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(172, 27);
            txtYeniSifreTekrar.TabIndex = 30;
            txtYeniSifreTekrar.TextChanged += txtYeniSifreTekrar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 93);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 31;
            label3.Text = "Eski Şifreniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 137);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 31;
            label4.Text = "Yeni Şifreniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 184);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 31;
            label6.Text = "Yeni Şifre Tekrar:";
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSifreDegistir.Location = new Point(133, 233);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(189, 40);
            btnSifreDegistir.TabIndex = 32;
            btnSifreDegistir.Text = "Şifreyi Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = true;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // pbEskiSifre
            // 
            pbEskiSifre.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbEskiSifre.Location = new Point(376, 90);
            pbEskiSifre.Name = "pbEskiSifre";
            pbEskiSifre.Size = new Size(35, 27);
            pbEskiSifre.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEskiSifre.TabIndex = 49;
            pbEskiSifre.TabStop = false;
            pbEskiSifre.Click += pbEskiSifre_Click;
            // 
            // pbYeniSifreTekrar
            // 
            pbYeniSifreTekrar.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifreTekrar.Location = new Point(376, 181);
            pbYeniSifreTekrar.Name = "pbYeniSifreTekrar";
            pbYeniSifreTekrar.Size = new Size(35, 27);
            pbYeniSifreTekrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYeniSifreTekrar.TabIndex = 50;
            pbYeniSifreTekrar.TabStop = false;
            pbYeniSifreTekrar.Click += pbYeniSifreTekrar_Click;
            // 
            // pbYeniSifre
            // 
            pbYeniSifre.Image = Properties.Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            pbYeniSifre.Location = new Point(376, 134);
            pbYeniSifre.Name = "pbYeniSifre";
            pbYeniSifre.Size = new Size(35, 27);
            pbYeniSifre.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYeniSifre.TabIndex = 51;
            pbYeniSifre.TabStop = false;
            pbYeniSifre.Click += pbYeniSifre_Click;
            // 
            // YoneticiSifreDegistir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(495, 300);
            Controls.Add(pbEskiSifre);
            Controls.Add(pbYeniSifreTekrar);
            Controls.Add(pbYeniSifre);
            Controls.Add(btnSifreDegistir);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtEskiSifre);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YoneticiSifreDegistir";
            Text = "YoneticiSifreDegistir";
            ((System.ComponentModel.ISupportInitialize)pbEskiSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifreTekrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniSifre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList ımageList1;
        private Label label2;
        private Label label5;
        private TextBox txtEskiSifre;
        private TextBox txtYeniSifre;
        private TextBox txtYeniSifreTekrar;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnSifreDegistir;
        private PictureBox pbEskiSifre;
        private PictureBox pbYeniSifreTekrar;
        private PictureBox pbYeniSifre;
    }
}