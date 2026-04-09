namespace WindowsFormsApp1
{
    partial class Kullanici_Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_k_adi = new System.Windows.Forms.TextBox();
            this.txt_k_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifresi :";
            // 
            // txt_k_adi
            // 
            this.txt_k_adi.Location = new System.Drawing.Point(169, 55);
            this.txt_k_adi.Name = "txt_k_adi";
            this.txt_k_adi.Size = new System.Drawing.Size(100, 22);
            this.txt_k_adi.TabIndex = 2;
            this.txt_k_adi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_k_sifre
            // 
            this.txt_k_sifre.Location = new System.Drawing.Point(169, 104);
            this.txt_k_sifre.Name = "txt_k_sifre";
            this.txt_k_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_k_sifre.TabIndex = 3;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(280, 164);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(100, 33);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kullanici_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 269);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_k_sifre);
            this.Controls.Add(this.txt_k_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullanici_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kullanici_Giris_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_k_adi;
        private System.Windows.Forms.TextBox txt_k_sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}