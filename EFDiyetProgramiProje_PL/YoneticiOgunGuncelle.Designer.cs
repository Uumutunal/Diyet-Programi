namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiOgunGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiOgunGuncelle));
            label3 = new Label();
            btnGuncelle = new Button();
            txtYeniOgunAdi = new TextBox();
            dgvOgunListesi = new DataGridView();
            label5 = new Label();
            label2 = new Label();
            ımageList1 = new ImageList(components);
            label1 = new Label();
            lblGuncelleHata = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgunListesi).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 205);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 31;
            label3.Text = "Öğün Adı:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(275, 236);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(120, 29);
            btnGuncelle.TabIndex = 30;
            btnGuncelle.Text = "KAYDET";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtYeniOgunAdi
            // 
            txtYeniOgunAdi.Location = new Point(242, 203);
            txtYeniOgunAdi.Name = "txtYeniOgunAdi";
            txtYeniOgunAdi.Size = new Size(154, 27);
            txtYeniOgunAdi.TabIndex = 29;
            // 
            // dgvOgunListesi
            // 
            dgvOgunListesi.BackgroundColor = SystemColors.ButtonFace;
            dgvOgunListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunListesi.Location = new Point(98, 68);
            dgvOgunListesi.Name = "dgvOgunListesi";
            dgvOgunListesi.RowHeadersWidth = 51;
            dgvOgunListesi.Size = new Size(298, 129);
            dgvOgunListesi.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(98, 8);
            label5.Name = "label5";
            label5.Size = new Size(293, 54);
            label5.TabIndex = 27;
            label5.Text = "ÖĞÜN GÜNCELLE";
            // 
            // label2
            // 
            label2.ImageKey = "öğünline1 - Kopya.jpg";
            label2.ImageList = ımageList1;
            label2.Location = new Point(415, -11);
            label2.Name = "label2";
            label2.Size = new Size(78, 332);
            label2.TabIndex = 25;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "öğünline1 - Kopya.jpg");
            ımageList1.Images.SetKeyName(1, "öğünline1.jpg");
            // 
            // label1
            // 
            label1.ImageKey = "öğünline1.jpg";
            label1.ImageList = ımageList1;
            label1.Location = new Point(-3, -11);
            label1.Name = "label1";
            label1.Size = new Size(78, 332);
            label1.TabIndex = 26;
            // 
            // lblGuncelleHata
            // 
            lblGuncelleHata.AutoSize = true;
            lblGuncelleHata.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGuncelleHata.ForeColor = Color.Red;
            lblGuncelleHata.Location = new Point(98, 283);
            lblGuncelleHata.Name = "lblGuncelleHata";
            lblGuncelleHata.Size = new Size(51, 20);
            lblGuncelleHata.TabIndex = 32;
            lblGuncelleHata.Text = "label4";
            // 
            // YoneticiOgunGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 321);
            Controls.Add(lblGuncelleHata);
            Controls.Add(label3);
            Controls.Add(btnGuncelle);
            Controls.Add(txtYeniOgunAdi);
            Controls.Add(dgvOgunListesi);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YoneticiOgunGuncelle";
            Text = "YoneticiOgunGuncelle";
            ((System.ComponentModel.ISupportInitialize)dgvOgunListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnGuncelle;
        private TextBox txtOgunGuncelle;
        private DataGridView dgvOgunlerGuncelleme;
        private Label label5;
        private Label label2;
        private ImageList ımageList1;
        private Label label1;
        private Label lblGuncelleHata;
        private DataGridView dgvOgunListesi;
        private TextBox txtYeniOgunAdi;
    }
}