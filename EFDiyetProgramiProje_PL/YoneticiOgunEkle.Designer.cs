﻿namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiOgunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiOgunEkle));
            ımageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            dgvOgunListesi = new DataGridView();
            txtOgunEkle = new TextBox();
            btnEkle = new Button();
            label3 = new Label();
            lblEkleHata = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgunListesi).BeginInit();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "öğünline1 - Kopya.jpg");
            ımageList1.Images.SetKeyName(1, "öğünline1.jpg");
            ımageList1.Images.SetKeyName(2, "öğünline2 - Kopya.jpg");
            ımageList1.Images.SetKeyName(3, "öğünline2.jpg");
            // 
            // label1
            // 
            label1.ImageKey = "öğünline1.jpg";
            label1.ImageList = ımageList1;
            label1.Location = new Point(-4, -2);
            label1.Name = "label1";
            label1.Size = new Size(72, 242);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.ImageKey = "öğünline1 - Kopya.jpg";
            label2.ImageList = ımageList1;
            label2.Location = new Point(361, -2);
            label2.Name = "label2";
            label2.Size = new Size(72, 242);
            label2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(115, 5);
            label5.Name = "label5";
            label5.Size = new Size(163, 43);
            label5.TabIndex = 20;
            label5.Text = "ÖĞÜN EKLE";
            // 
            // dgvOgunListesi
            // 
            dgvOgunListesi.BackgroundColor = SystemColors.ButtonFace;
            dgvOgunListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunListesi.Location = new Point(73, 50);
            dgvOgunListesi.Margin = new Padding(3, 2, 3, 2);
            dgvOgunListesi.Name = "dgvOgunListesi";
            dgvOgunListesi.RowHeadersWidth = 51;
            dgvOgunListesi.Size = new Size(282, 97);
            dgvOgunListesi.TabIndex = 21;
            // 
            // txtOgunEkle
            // 
            txtOgunEkle.Location = new Point(220, 161);
            txtOgunEkle.Margin = new Padding(3, 2, 3, 2);
            txtOgunEkle.Name = "txtOgunEkle";
            txtOgunEkle.Size = new Size(135, 23);
            txtOgunEkle.TabIndex = 22;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(250, 185);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(105, 22);
            btnEkle.TabIndex = 23;
            btnEkle.Text = "KAYDET";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 163);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 24;
            label3.Text = "Öğün Adı:";
            // 
            // lblEkleHata
            // 
            lblEkleHata.AutoSize = true;
            lblEkleHata.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEkleHata.ForeColor = Color.Red;
            lblEkleHata.Location = new Point(158, 218);
            lblEkleHata.Name = "lblEkleHata";
            lblEkleHata.Size = new Size(0, 15);
            lblEkleHata.TabIndex = 33;
            lblEkleHata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YoneticiOgunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 240);
            Controls.Add(lblEkleHata);
            Controls.Add(label3);
            Controls.Add(btnEkle);
            Controls.Add(txtOgunEkle);
            Controls.Add(dgvOgunListesi);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "YoneticiOgunEkle";
            Text = "YoneticiOgunEkle";
            ((System.ComponentModel.ISupportInitialize)dgvOgunListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ımageList1;
        private Label label1;
        private Label label2;
        private Label label5;
        private DataGridView dgvOgunlerEkle;
        private TextBox txtOgunEkle;
        private Button btnEkle;
        private Label label3;
        private Label lblEkleHata;
        private DataGridView dgvOgunListesi;
    }
}