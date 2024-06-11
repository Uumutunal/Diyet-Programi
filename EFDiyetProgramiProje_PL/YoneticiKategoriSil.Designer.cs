namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiKategoriSil
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
            btnKategoriSil = new Button();
            label1 = new Label();
            cbKategoriSil = new ComboBox();
            SuspendLayout();
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.Location = new Point(23, 93);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(226, 23);
            btnKategoriSil.TabIndex = 5;
            btnKategoriSil.Text = "Kategori Sil";
            btnKategoriSil.UseVisualStyleBackColor = true;
            btnKategoriSil.Click += btnKategoriSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 4;
            label1.Text = "Silmek İstediğiniz Kategoriyi Seçiniz:";
            // 
            // cbKategoriSil
            // 
            cbKategoriSil.FormattingEnabled = true;
            cbKategoriSil.Location = new Point(23, 54);
            cbKategoriSil.Name = "cbKategoriSil";
            cbKategoriSil.Size = new Size(226, 23);
            cbKategoriSil.TabIndex = 6;
            // 
            // YoneticiKategoriSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 138);
            Controls.Add(cbKategoriSil);
            Controls.Add(btnKategoriSil);
            Controls.Add(label1);
            Name = "YoneticiKategoriSil";
            Text = "YoneticiKategoriSil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKategoriSil;
        private Label label1;
        private ComboBox cbKategoriSil;
    }
}