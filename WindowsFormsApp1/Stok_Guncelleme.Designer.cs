namespace WindowsFormsApp1
{
    partial class Stok_Guncelleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCins = new System.Windows.Forms.TextBox();
            this.datagrid_veriler = new System.Windows.Forms.DataGridView();
            this.textStok = new System.Windows.Forms.TextBox();
            this.textAdedi = new System.Windows.Forms.TextBox();
            this.textFiyat = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textKodu = new System.Windows.Forms.TextBox();
            this.guncelleme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.urunResmi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_veriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCins);
            this.groupBox1.Controls.Add(this.datagrid_veriler);
            this.groupBox1.Controls.Add(this.textStok);
            this.groupBox1.Controls.Add(this.textAdedi);
            this.groupBox1.Controls.Add(this.textFiyat);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.textKodu);
            this.groupBox1.Controls.Add(this.guncelleme);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.urunResmi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 449);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textCins
            // 
            this.textCins.Location = new System.Drawing.Point(404, 102);
            this.textCins.Name = "textCins";
            this.textCins.Size = new System.Drawing.Size(100, 22);
            this.textCins.TabIndex = 31;
            // 
            // datagrid_veriler
            // 
            this.datagrid_veriler.AllowUserToAddRows = false;
            this.datagrid_veriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_veriler.Location = new System.Drawing.Point(29, 287);
            this.datagrid_veriler.MultiSelect = false;
            this.datagrid_veriler.Name = "datagrid_veriler";
            this.datagrid_veriler.RowHeadersWidth = 51;
            this.datagrid_veriler.RowTemplate.Height = 24;
            this.datagrid_veriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_veriler.Size = new System.Drawing.Size(704, 150);
            this.datagrid_veriler.TabIndex = 30;
            this.datagrid_veriler.CellBorderStyleChanged += new System.EventHandler(this.datagrid_veriler_CellBorderStyleChanged);
            this.datagrid_veriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_veriler_CellContentClick);
            // 
            // textStok
            // 
            this.textStok.Location = new System.Drawing.Point(404, 185);
            this.textStok.Name = "textStok";
            this.textStok.Size = new System.Drawing.Size(100, 22);
            this.textStok.TabIndex = 28;
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
            // guncelleme
            // 
            this.guncelleme.Location = new System.Drawing.Point(215, 242);
            this.guncelleme.Name = "guncelleme";
            this.guncelleme.Size = new System.Drawing.Size(107, 23);
            this.guncelleme.TabIndex = 23;
            this.guncelleme.Text = "Güncelleme";
            this.guncelleme.UseVisualStyleBackColor = true;
            this.guncelleme.Click += new System.EventHandler(this.guncelleme_Click);
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
            // Stok_Guncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stok_Guncelleme";
            this.Text = "Stok_Guncelleme";
            this.Load += new System.EventHandler(this.Stok_Guncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_veriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagrid_veriler;
        private System.Windows.Forms.TextBox textStok;
        private System.Windows.Forms.TextBox textAdedi;
        private System.Windows.Forms.TextBox textFiyat;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textKodu;
        private System.Windows.Forms.Button guncelleme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label urunResmi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCins;
    }
}