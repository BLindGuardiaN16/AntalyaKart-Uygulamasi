namespace AntalyaKart_Uygulaması
{
    partial class Form3
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
            this.baslik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tckimliktxt = new System.Windows.Forms.TextBox();
            this.girisbutton = new System.Windows.Forms.Button();
            this.anamenubutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(158, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(867, 116);
            this.baslik.TabIndex = 12;
            this.baslik.Text = "        ANTALYA BÜYÜKŞEHİR BELEDİYESİ\r\nANTALYAKART BAKİYE YÜKLEME UYGULAMASI\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sifretxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tckimliktxt);
            this.groupBox1.Location = new System.Drawing.Point(407, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 163);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(163, 105);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(169, 22);
            this.sifretxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifreniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC Kimliğiniz:";
            // 
            // tckimliktxt
            // 
            this.tckimliktxt.Location = new System.Drawing.Point(163, 57);
            this.tckimliktxt.Name = "tckimliktxt";
            this.tckimliktxt.Size = new System.Drawing.Size(169, 22);
            this.tckimliktxt.TabIndex = 0;
            // 
            // girisbutton
            // 
            this.girisbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.girisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbutton.Location = new System.Drawing.Point(487, 400);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(182, 35);
            this.girisbutton.TabIndex = 22;
            this.girisbutton.Text = "GİRİŞ";
            this.girisbutton.UseVisualStyleBackColor = false;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // anamenubutton
            // 
            this.anamenubutton.BackColor = System.Drawing.Color.Crimson;
            this.anamenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anamenubutton.Location = new System.Drawing.Point(12, 506);
            this.anamenubutton.Name = "anamenubutton";
            this.anamenubutton.Size = new System.Drawing.Size(141, 35);
            this.anamenubutton.TabIndex = 23;
            this.anamenubutton.Text = "Ana Menü";
            this.anamenubutton.UseVisualStyleBackColor = false;
            this.anamenubutton.Click += new System.EventHandler(this.anamenubutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.anamenubutton);
            this.Controls.Add(this.girisbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tckimliktxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button girisbutton;
        private System.Windows.Forms.Button anamenubutton;
    }
}