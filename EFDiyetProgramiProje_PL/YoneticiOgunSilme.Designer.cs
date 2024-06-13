namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiOgunSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiOgunSilme));
            ımageList1 = new ImageList(components);
            label3 = new Label();
            btnSil = new Button();
            txtOgunAdi = new TextBox();
            dgvOgunListesi = new DataGridView();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSilmeHata = new Label();
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 216);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 31;
            label3.Text = "Öğün Adı:";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(287, 247);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 29);
            btnSil.TabIndex = 30;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(254, 211);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.ReadOnly = true;
            txtOgunAdi.Size = new Size(154, 27);
            txtOgunAdi.TabIndex = 29;
            // 
            // dgvOgunListesi
            // 
            dgvOgunListesi.BackgroundColor = SystemColors.ButtonFace;
            dgvOgunListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunListesi.Location = new Point(89, 65);
            dgvOgunListesi.Name = "dgvOgunListesi";
            dgvOgunListesi.RowHeadersWidth = 51;
            dgvOgunListesi.Size = new Size(319, 129);
            dgvOgunListesi.TabIndex = 28;
            dgvOgunListesi.SelectionChanged += dgvOgunListesi_SelectionChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(89, 8);
            label5.Name = "label5";
            label5.Size = new Size(229, 54);
            label5.TabIndex = 27;
            label5.Text = "ÖĞÜN SİLME";
            // 
            // label2
            // 
            label2.ImageKey = "öğünline1 - Kopya.jpg";
            label2.ImageList = ımageList1;
            label2.Location = new Point(427, -5);
            label2.Name = "label2";
            label2.Size = new Size(78, 340);
            label2.TabIndex = 25;
            // 
            // label1
            // 
            label1.ImageKey = "öğünline1.jpg";
            label1.ImageList = ımageList1;
            label1.Location = new Point(-10, -5);
            label1.Name = "label1";
            label1.Size = new Size(93, 333);
            label1.TabIndex = 26;
            // 
            // lblSilmeHata
            // 
            lblSilmeHata.AutoSize = true;
            lblSilmeHata.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSilmeHata.ForeColor = Color.Red;
            lblSilmeHata.Location = new Point(89, 292);
            lblSilmeHata.Name = "lblSilmeHata";
            lblSilmeHata.Size = new Size(51, 20);
            lblSilmeHata.TabIndex = 33;
            lblSilmeHata.Text = "label4";
            // 
            // YoneticiOgunSilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(503, 321);
            Controls.Add(lblSilmeHata);
            Controls.Add(label3);
            Controls.Add(btnSil);
            Controls.Add(txtOgunAdi);
            Controls.Add(dgvOgunListesi);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YoneticiOgunSilme";
            Text = "YoneticiOgunSilme";
            ((System.ComponentModel.ISupportInitialize)dgvOgunListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ımageList1;
        private Label label3;
        private Button btnSil;
        private TextBox txtOgunAdi;
        private DataGridView dgvOgunListesi;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label lblSilmeHata;
    }
}