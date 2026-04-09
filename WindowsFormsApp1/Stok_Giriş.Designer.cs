namespace WindowsFormsApp1
{
    partial class Stok_Giriş
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textStok = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textAdedi = new System.Windows.Forms.TextBox();
            this.textFiyat = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textKodu = new System.Windows.Forms.TextBox();
            this.urunResmi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textStok
            // 
            this.textStok.Location = new System.Drawing.Point(404, 185);
            this.textStok.Name = "textStok";
            this.textStok.Size = new System.Drawing.Size(100, 22);
            this.textStok.TabIndex = 28;
            this.toolTip1.SetToolTip(this.textStok, "Kritik Stok Ürünlerinizdeki Minumum Sayıdır.Bu Sayıya Ulaştığında Uyarı Verecekti" +
        "r.\r\n\r\n");
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(252, 229);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 23);
            this.kaydet.TabIndex = 23;
            this.kaydet.Text = "Kaydet";
            this.toolTip1.SetToolTip(this.kaydet, "Kaydetmek İçin Butona Baınız.");
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(581, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 124);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Resim Eklemek  İçin Tıklayınız.");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textStok);
            this.groupBox1.Controls.Add(this.textAdedi);
            this.groupBox1.Controls.Add(this.textFiyat);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.textKodu);
            this.groupBox1.Controls.Add(this.kaydet);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.urunResmi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(404, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // textAdedi
            // 
            this.textAdedi.Location = new System.Drawing.Point(404, 140);
            this.textAdedi.Name = "textAdedi";
            this.textAdedi.Size = new System.Drawing.Size(100, 22);
            this.textAdedi.TabIndex = 27;
            // 
            // textFiyat
            // 
            this.textFiyat.Location = new System.Drawing.Point(125, 188);
            this.textFiyat.Name = "textFiyat";
            this.textFiyat.Size = new System.Drawing.Size(100, 22);
            this.textFiyat.TabIndex = 26;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(125, 146);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 22);
            this.textAd.TabIndex = 25;
            // 
            // textKodu
            // 
            this.textKodu.Location = new System.Drawing.Point(125, 105);
            this.textKodu.Name = "textKodu";
            this.textKodu.Size = new System.Drawing.Size(100, 22);
            this.textKodu.TabIndex = 24;
            // 
            // urunResmi
            // 
            this.urunResmi.AutoSize = true;
            this.urunResmi.Location = new System.Drawing.Point(625, 56);
            this.urunResmi.Name = "urunResmi";
            this.urunResmi.Size = new System.Drawing.Size(77, 16);
            this.urunResmi.TabIndex = 21;
            this.urunResmi.Text = "Ürün Resmi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kritik Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ürün Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ürün Cinsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Kodu";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Stok_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stok_Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokEklemeAlanı";
            this.Load += new System.EventHandler(this.Stok_Giriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textStok;
        private System.Windows.Forms.TextBox textAdedi;
        private System.Windows.Forms.TextBox textFiyat;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textKodu;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label urunResmi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}