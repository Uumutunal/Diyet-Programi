namespace EFDiyetProgramiProje_PL
{
    partial class YoneticiYeniKategoriEkle
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
            label1 = new Label();
            btnKategoriEkle = new Button();
            txtYeniKategoriEkle = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(226, 15);
            label1.TabIndex = 1;
            label1.Text = "Eklemek İstediğiniz Kategori Adını Yazınız:";
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(36, 89);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(226, 23);
            btnKategoriEkle.TabIndex = 2;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // txtYeniKategoriEkle
            // 
            txtYeniKategoriEkle.Location = new Point(36, 50);
            txtYeniKategoriEkle.Name = "txtYeniKategoriEkle";
            txtYeniKategoriEkle.Size = new Size(226, 23);
            txtYeniKategoriEkle.TabIndex = 3;
            // 
            // KullaniciYeniKategoriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 124);
            Controls.Add(txtYeniKategoriEkle);
            Controls.Add(btnKategoriEkle);
            Controls.Add(label1);
            Name = "KullaniciYeniKategoriEkle";
            Text = "KullaniciYeniKategoriEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnKategoriEkle;
        private TextBox txtYeniKategoriEkle;
    }
}