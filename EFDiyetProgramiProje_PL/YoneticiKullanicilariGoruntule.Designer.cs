namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiKullanicilariGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiKullanicilariGoruntule));
            label1 = new Label();
            ımageList1 = new ImageList(components);
            label2 = new Label();
            label5 = new Label();
            dgvKullanicilar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ImageKey = "users.jpg";
            label1.ImageList = ımageList1;
            label1.Location = new Point(-4, -4);
            label1.Name = "label1";
            label1.Size = new Size(82, 299);
            label1.TabIndex = 0;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "users.jpg");
            ımageList1.Images.SetKeyName(1, "users - Kopya.jpg");
            // 
            // label2
            // 
            label2.ImageKey = "users - Kopya.jpg";
            label2.ImageList = ımageList1;
            label2.Location = new Point(424, -4);
            label2.Name = "label2";
            label2.Size = new Size(82, 299);
            label2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(119, 9);
            label5.Name = "label5";
            label5.Size = new Size(262, 54);
            label5.TabIndex = 28;
            label5.Text = "KULLANICILAR";
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.BackgroundColor = SystemColors.ButtonFace;
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(84, 66);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.RowHeadersWidth = 51;
            dgvKullanicilar.Size = new Size(334, 211);
            dgvKullanicilar.TabIndex = 29;
            // 
            // YoneticiKullanicilariGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 296);
            Controls.Add(dgvKullanicilar);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YoneticiKullanicilariGoruntule";
            Text = "YoneticiKullanicilariGoruntule";
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList ımageList1;
        private Label label2;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridView dgvKullanicilar;
    }
}