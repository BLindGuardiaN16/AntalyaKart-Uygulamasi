namespace AntalyaKart_Uygulaması
{
    partial class Form4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bakiyelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.kartekletxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd200 = new System.Windows.Forms.RadioButton();
            this.rd175 = new System.Windows.Forms.RadioButton();
            this.rd150 = new System.Windows.Forms.RadioButton();
            this.rd125 = new System.Windows.Forms.RadioButton();
            this.rd100 = new System.Windows.Forms.RadioButton();
            this.rd75 = new System.Windows.Forms.RadioButton();
            this.rd50 = new System.Windows.Forms.RadioButton();
            this.rd25 = new System.Windows.Forms.RadioButton();
            this.rd10 = new System.Windows.Forms.RadioButton();
            this.paraeklebutton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anamenubutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(210, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(867, 116);
            this.baslik.TabIndex = 4;
            this.baslik.Text = "        ANTALYA BÜYÜKŞEHİR BELEDİYESİ\r\nANTALYAKART BAKİYE YÜKLEME UYGULAMASI\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 37);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bakiyelabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 370);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kartlarım";
            // 
            // bakiyelabel
            // 
            this.bakiyelabel.AutoSize = true;
            this.bakiyelabel.BackColor = System.Drawing.Color.ForestGreen;
            this.bakiyelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyelabel.Location = new System.Drawing.Point(148, 227);
            this.bakiyelabel.Name = "bakiyelabel";
            this.bakiyelabel.Size = new System.Drawing.Size(115, 36);
            this.bakiyelabel.TabIndex = 7;
            this.bakiyelabel.Text = "505 TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "BAKİYE:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kaydetbutton);
            this.groupBox2.Controls.Add(this.kartekletxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(428, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 370);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kart Ekle";
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.kaydetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbutton.Location = new System.Drawing.Point(85, 131);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(141, 35);
            this.kaydetbutton.TabIndex = 23;
            this.kaydetbutton.Text = "KAYDET";
            this.kaydetbutton.UseVisualStyleBackColor = false;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetbutton_Click);
            // 
            // kartekletxt
            // 
            this.kartekletxt.Location = new System.Drawing.Point(6, 36);
            this.kartekletxt.Name = "kartekletxt";
            this.kartekletxt.Size = new System.Drawing.Size(300, 34);
            this.kartekletxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd200);
            this.groupBox3.Controls.Add(this.rd175);
            this.groupBox3.Controls.Add(this.rd150);
            this.groupBox3.Controls.Add(this.rd125);
            this.groupBox3.Controls.Add(this.rd100);
            this.groupBox3.Controls.Add(this.rd75);
            this.groupBox3.Controls.Add(this.rd50);
            this.groupBox3.Controls.Add(this.rd25);
            this.groupBox3.Controls.Add(this.rd10);
            this.groupBox3.Controls.Add(this.paraeklebutton);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(835, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 370);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bakiye Ekle";
            // 
            // rd200
            // 
            this.rd200.AutoSize = true;
            this.rd200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd200.Location = new System.Drawing.Point(217, 176);
            this.rd200.Name = "rd200";
            this.rd200.Size = new System.Drawing.Size(101, 29);
            this.rd200.TabIndex = 33;
            this.rd200.TabStop = true;
            this.rd200.Text = "200 TL";
            this.rd200.UseVisualStyleBackColor = true;
            // 
            // rd175
            // 
            this.rd175.AutoSize = true;
            this.rd175.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd175.Location = new System.Drawing.Point(110, 176);
            this.rd175.Name = "rd175";
            this.rd175.Size = new System.Drawing.Size(101, 29);
            this.rd175.TabIndex = 32;
            this.rd175.TabStop = true;
            this.rd175.Text = "175 TL";
            this.rd175.UseVisualStyleBackColor = true;
            // 
            // rd150
            // 
            this.rd150.AutoSize = true;
            this.rd150.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd150.Location = new System.Drawing.Point(6, 176);
            this.rd150.Name = "rd150";
            this.rd150.Size = new System.Drawing.Size(101, 29);
            this.rd150.TabIndex = 31;
            this.rd150.TabStop = true;
            this.rd150.Text = "150 TL";
            this.rd150.UseVisualStyleBackColor = true;
            // 
            // rd125
            // 
            this.rd125.AutoSize = true;
            this.rd125.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd125.Location = new System.Drawing.Point(217, 141);
            this.rd125.Name = "rd125";
            this.rd125.Size = new System.Drawing.Size(101, 29);
            this.rd125.TabIndex = 30;
            this.rd125.TabStop = true;
            this.rd125.Text = "125 TL";
            this.rd125.UseVisualStyleBackColor = true;
            // 
            // rd100
            // 
            this.rd100.AutoSize = true;
            this.rd100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd100.Location = new System.Drawing.Point(110, 141);
            this.rd100.Name = "rd100";
            this.rd100.Size = new System.Drawing.Size(101, 29);
            this.rd100.TabIndex = 29;
            this.rd100.TabStop = true;
            this.rd100.Text = "100 TL";
            this.rd100.UseVisualStyleBackColor = true;
            // 
            // rd75
            // 
            this.rd75.AutoSize = true;
            this.rd75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd75.Location = new System.Drawing.Point(6, 141);
            this.rd75.Name = "rd75";
            this.rd75.Size = new System.Drawing.Size(89, 29);
            this.rd75.TabIndex = 28;
            this.rd75.TabStop = true;
            this.rd75.Text = "75 TL";
            this.rd75.UseVisualStyleBackColor = true;
            // 
            // rd50
            // 
            this.rd50.AutoSize = true;
            this.rd50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd50.Location = new System.Drawing.Point(217, 106);
            this.rd50.Name = "rd50";
            this.rd50.Size = new System.Drawing.Size(89, 29);
            this.rd50.TabIndex = 27;
            this.rd50.TabStop = true;
            this.rd50.Text = "50 TL";
            this.rd50.UseVisualStyleBackColor = true;
            // 
            // rd25
            // 
            this.rd25.AutoSize = true;
            this.rd25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd25.Location = new System.Drawing.Point(110, 106);
            this.rd25.Name = "rd25";
            this.rd25.Size = new System.Drawing.Size(89, 29);
            this.rd25.TabIndex = 26;
            this.rd25.TabStop = true;
            this.rd25.Text = "25 TL";
            this.rd25.UseVisualStyleBackColor = true;
            // 
            // rd10
            // 
            this.rd10.AutoSize = true;
            this.rd10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd10.Location = new System.Drawing.Point(6, 106);
            this.rd10.Name = "rd10";
            this.rd10.Size = new System.Drawing.Size(89, 29);
            this.rd10.TabIndex = 25;
            this.rd10.TabStop = true;
            this.rd10.Text = "10 TL";
            this.rd10.UseVisualStyleBackColor = true;
            // 
            // paraeklebutton
            // 
            this.paraeklebutton.BackColor = System.Drawing.Color.LimeGreen;
            this.paraeklebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paraeklebutton.Location = new System.Drawing.Point(89, 244);
            this.paraeklebutton.Name = "paraeklebutton";
            this.paraeklebutton.Size = new System.Drawing.Size(141, 35);
            this.paraeklebutton.TabIndex = 24;
            this.paraeklebutton.Text = "PARA EKLE";
            this.paraeklebutton.UseVisualStyleBackColor = false;
            this.paraeklebutton.Click += new System.EventHandler(this.paraeklebutton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 37);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1334, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // anamenubutton
            // 
            this.anamenubutton.BackColor = System.Drawing.Color.Crimson;
            this.anamenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anamenubutton.Location = new System.Drawing.Point(12, 506);
            this.anamenubutton.Name = "anamenubutton";
            this.anamenubutton.Size = new System.Drawing.Size(141, 35);
            this.anamenubutton.TabIndex = 24;
            this.anamenubutton.Text = "Ana Menü";
            this.anamenubutton.UseVisualStyleBackColor = false;
            this.anamenubutton.Click += new System.EventHandler(this.anamenubutton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 553);
            this.Controls.Add(this.anamenubutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bakiyelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.TextBox kartekletxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button paraeklebutton;
        private System.Windows.Forms.RadioButton rd200;
        private System.Windows.Forms.RadioButton rd175;
        private System.Windows.Forms.RadioButton rd150;
        private System.Windows.Forms.RadioButton rd125;
        private System.Windows.Forms.RadioButton rd100;
        private System.Windows.Forms.RadioButton rd75;
        private System.Windows.Forms.RadioButton rd50;
        private System.Windows.Forms.RadioButton rd25;
        private System.Windows.Forms.RadioButton rd10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button anamenubutton;
    }
}