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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
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
            label2.Location = new Point(368, 0);
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
            // textBox1
            // 
            textBox1.Location = new Point(193, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 30;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(130, 231);
            button1.Name = "button1";
            button1.Size = new Size(189, 40);
            button1.TabIndex = 32;
            button1.Text = "Şifreyi Değiştir";
            button1.UseVisualStyleBackColor = true;
            // 
            // YoneticiSifreDegistir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(446, 300);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YoneticiSifreDegistir";
            Text = "YoneticiSifreDegistir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList ımageList1;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button button1;
    }
}