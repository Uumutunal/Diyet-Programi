namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiYemekSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiYemekSilme));
            label12 = new Label();
            label8 = new Label();
            ımageList1 = new ImageList(components);
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label10 = new Label();
            label1 = new Label();
            btnYemekOgunleEkle = new Button();
            cbYemekSecSil = new ComboBox();
            cbKategoriSecSil = new ComboBox();
            pbYemekGörseliGuncelleme = new PictureBox();
            rtxtTarifiGuncelleme = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbYemekGörseliGuncelleme).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(212, 398);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 59;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.ImageKey = "linefood - Kopya.png";
            label8.ImageList = ımageList1;
            label8.Location = new Point(-1, 215);
            label8.Name = "label8";
            label8.Size = new Size(66, 209);
            label8.TabIndex = 57;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "linefood - Kopya.png");
            ımageList1.Images.SetKeyName(1, "linefood.png");
            // 
            // label9
            // 
            label9.ImageKey = "linefood - Kopya.png";
            label9.ImageList = ımageList1;
            label9.Location = new Point(-1, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 215);
            label9.TabIndex = 58;
            // 
            // label7
            // 
            label7.ImageKey = "linefood.png";
            label7.ImageList = ımageList1;
            label7.Location = new Point(439, 208);
            label7.Name = "label7";
            label7.Size = new Size(61, 215);
            label7.TabIndex = 55;
            // 
            // label6
            // 
            label6.ImageKey = "linefood.png";
            label6.ImageList = ımageList1;
            label6.Location = new Point(439, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 215);
            label6.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(166, 7);
            label5.Name = "label5";
            label5.Size = new Size(197, 43);
            label5.TabIndex = 54;
            label5.Text = "YEMEK SİLME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 255);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 48;
            label4.Text = "Yemek Görseli:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 136);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 49;
            label3.Text = "Tarifi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(90, 90);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 52;
            label10.Text = "Yemek Seç:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 61);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 53;
            label1.Text = "Kategori Seç:";
            // 
            // btnYemekOgunleEkle
            // 
            btnYemekOgunleEkle.Location = new Point(242, 356);
            btnYemekOgunleEkle.Margin = new Padding(3, 2, 3, 2);
            btnYemekOgunleEkle.Name = "btnYemekOgunleEkle";
            btnYemekOgunleEkle.Size = new Size(150, 20);
            btnYemekOgunleEkle.TabIndex = 47;
            btnYemekOgunleEkle.Text = "SİL";
            btnYemekOgunleEkle.UseVisualStyleBackColor = true;
            btnYemekOgunleEkle.Click += btnYemekOgunleEkle_Click;
            // 
            // cbYemekSecSil
            // 
            cbYemekSecSil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYemekSecSil.FormattingEnabled = true;
            cbYemekSecSil.Location = new Point(166, 88);
            cbYemekSecSil.Margin = new Padding(3, 2, 3, 2);
            cbYemekSecSil.Name = "cbYemekSecSil";
            cbYemekSecSil.Size = new Size(227, 23);
            cbYemekSecSil.TabIndex = 46;
            cbYemekSecSil.SelectedIndexChanged += cbYemekSecSil_SelectedIndexChanged;
            // 
            // cbKategoriSecSil
            // 
            cbKategoriSecSil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategoriSecSil.FormattingEnabled = true;
            cbKategoriSecSil.Location = new Point(165, 58);
            cbKategoriSecSil.Margin = new Padding(3, 2, 3, 2);
            cbKategoriSecSil.Name = "cbKategoriSecSil";
            cbKategoriSecSil.Size = new Size(227, 23);
            cbKategoriSecSil.TabIndex = 45;
            cbKategoriSecSil.SelectedIndexChanged += cbKategoriSecSil_SelectedIndexChanged;
            // 
            // pbYemekGörseliGuncelleme
            // 
            pbYemekGörseliGuncelleme.Location = new Point(165, 241);
            pbYemekGörseliGuncelleme.Margin = new Padding(3, 2, 3, 2);
            pbYemekGörseliGuncelleme.Name = "pbYemekGörseliGuncelleme";
            pbYemekGörseliGuncelleme.Size = new Size(227, 111);
            pbYemekGörseliGuncelleme.TabIndex = 44;
            pbYemekGörseliGuncelleme.TabStop = false;
            // 
            // rtxtTarifiGuncelleme
            // 
            rtxtTarifiGuncelleme.Location = new Point(165, 124);
            rtxtTarifiGuncelleme.Margin = new Padding(3, 2, 3, 2);
            rtxtTarifiGuncelleme.Name = "rtxtTarifiGuncelleme";
            rtxtTarifiGuncelleme.ReadOnly = true;
            rtxtTarifiGuncelleme.Size = new Size(227, 105);
            rtxtTarifiGuncelleme.TabIndex = 43;
            rtxtTarifiGuncelleme.Text = "";
            // 
            // YoneticiYemekSilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(502, 425);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(btnYemekOgunleEkle);
            Controls.Add(cbYemekSecSil);
            Controls.Add(cbKategoriSecSil);
            Controls.Add(pbYemekGörseliGuncelleme);
            Controls.Add(rtxtTarifiGuncelleme);
            Margin = new Padding(3, 2, 3, 2);
            Name = "YoneticiYemekSilme";
            Text = "YoneticiYemekSilme";
            ((System.ComponentModel.ISupportInitialize)pbYemekGörseliGuncelleme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label8;
        private ImageList ımageList1;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label1;
        private Button btnYemekOgunleEkle;
        private ComboBox cbYemekSecSil;
        private ComboBox cbKategoriSecSil;
        private PictureBox pbYemekGörseliGuncelleme;
        private RichTextBox rtxtTarifiGuncelleme;
    }
}