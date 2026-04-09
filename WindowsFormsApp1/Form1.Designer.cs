namespace WindowsFormsApp1
{
    partial class stok
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokTemizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canlıSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkProgramlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelikRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiilSistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükStokSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkStokSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelilStokSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelikSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıAtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webAktarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükStokBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükSatışBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.şifreİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminŞifreAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailBilgileriayarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailAyarıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailAyarıGÜncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokMenüsüToolStripMenuItem,
            this.stokToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.yedeklemeToolStripMenuItem,
            this.maiilSistemToolStripMenuItem,
            this.adminPaneliToolStripMenuItem,
            this.webAktarımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // stokMenüsüToolStripMenuItem
            // 
            this.stokMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokGirişToolStripMenuItem,
            this.stokGüncellemeToolStripMenuItem,
            this.stokTemizlemeToolStripMenuItem});
            this.stokMenüsüToolStripMenuItem.Name = "stokMenüsüToolStripMenuItem";
            this.stokMenüsüToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.stokMenüsüToolStripMenuItem.Text = "Stok Menüsü";
            // 
            // stokGirişToolStripMenuItem
            // 
            this.stokGirişToolStripMenuItem.Name = "stokGirişToolStripMenuItem";
            this.stokGirişToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.stokGirişToolStripMenuItem.Text = "Stok Giriş";
            this.stokGirişToolStripMenuItem.Click += new System.EventHandler(this.stokGirişToolStripMenuItem_Click);
            // 
            // stokGüncellemeToolStripMenuItem
            // 
            this.stokGüncellemeToolStripMenuItem.Name = "stokGüncellemeToolStripMenuItem";
            this.stokGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.stokGüncellemeToolStripMenuItem.Text = "Stok Güncelleme";
            this.stokGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.stokGüncellemeToolStripMenuItem_Click);
            // 
            // stokTemizlemeToolStripMenuItem
            // 
            this.stokTemizlemeToolStripMenuItem.Name = "stokTemizlemeToolStripMenuItem";
            this.stokTemizlemeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.stokTemizlemeToolStripMenuItem.Text = "Stok Temizleme";
            this.stokTemizlemeToolStripMenuItem.Click += new System.EventHandler(this.stokTemizlemeToolStripMenuItem_Click);
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canlıSatışToolStripMenuItem});
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.stokToolStripMenuItem.Text = "Satış";
            // 
            // canlıSatışToolStripMenuItem
            // 
            this.canlıSatışToolStripMenuItem.Name = "canlıSatışToolStripMenuItem";
            this.canlıSatışToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.canlıSatışToolStripMenuItem.Text = "Canlı Satış";
            this.canlıSatışToolStripMenuItem.Click += new System.EventHandler(this.canlıSatışToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükRaporlamaToolStripMenuItem,
            this.aylıkProgramlamaToolStripMenuItem,
            this.senelikRaporlamaToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // günlükRaporlamaToolStripMenuItem
            // 
            this.günlükRaporlamaToolStripMenuItem.Name = "günlükRaporlamaToolStripMenuItem";
            this.günlükRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.günlükRaporlamaToolStripMenuItem.Text = "Günlük Raporlama";
            this.günlükRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.günlükRaporlamaToolStripMenuItem_Click);
            // 
            // aylıkProgramlamaToolStripMenuItem
            // 
            this.aylıkProgramlamaToolStripMenuItem.Name = "aylıkProgramlamaToolStripMenuItem";
            this.aylıkProgramlamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aylıkProgramlamaToolStripMenuItem.Text = "Aylık Raporlama";
            this.aylıkProgramlamaToolStripMenuItem.Click += new System.EventHandler(this.aylıkProgramlamaToolStripMenuItem_Click);
            // 
            // senelikRaporlamaToolStripMenuItem
            // 
            this.senelikRaporlamaToolStripMenuItem.Name = "senelikRaporlamaToolStripMenuItem";
            this.senelikRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.senelikRaporlamaToolStripMenuItem.Text = "Senelik Raporlama";
            this.senelikRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.senelikRaporlamaToolStripMenuItem_Click);
            // 
            // yedeklemeToolStripMenuItem
            // 
            this.yedeklemeToolStripMenuItem.Name = "yedeklemeToolStripMenuItem";
            this.yedeklemeToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.yedeklemeToolStripMenuItem.Text = "Yedekleme";
            // 
            // maiilSistemToolStripMenuItem
            // 
            this.maiilSistemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükStokSatışToolStripMenuItem,
            this.aylıkStokSatışToolStripMenuItem,
            this.senelilStokSatışToolStripMenuItem,
            this.günlükSatışToolStripMenuItem,
            this.aylıkSatışToolStripMenuItem,
            this.senelikSatışToolStripMenuItem});
            this.maiilSistemToolStripMenuItem.Name = "maiilSistemToolStripMenuItem";
            this.maiilSistemToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.maiilSistemToolStripMenuItem.Text = "Mail  Sistemi";
            // 
            // günlükStokSatışToolStripMenuItem
            // 
            this.günlükStokSatışToolStripMenuItem.Name = "günlükStokSatışToolStripMenuItem";
            this.günlükStokSatışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.günlükStokSatışToolStripMenuItem.Text = "Günlük Stok";
            this.günlükStokSatışToolStripMenuItem.Click += new System.EventHandler(this.günlükStokSatışToolStripMenuItem_Click);
            // 
            // aylıkStokSatışToolStripMenuItem
            // 
            this.aylıkStokSatışToolStripMenuItem.Name = "aylıkStokSatışToolStripMenuItem";
            this.aylıkStokSatışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aylıkStokSatışToolStripMenuItem.Text = "Aylık Stok";
            this.aylıkStokSatışToolStripMenuItem.Click += new System.EventHandler(this.aylıkStokSatışToolStripMenuItem_Click);
            // 
            // senelilStokSatışToolStripMenuItem
            // 
            this.senelilStokSatışToolStripMenuItem.Name = "senelilStokSatışToolStripMenuItem";
            this.senelilStokSatışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.senelilStokSatışToolStripMenuItem.Text = "Senelil Stok";
            this.senelilStokSatışToolStripMenuItem.Click += new System.EventHandler(this.senelilStokSatışToolStripMenuItem_Click);
            // 
            // günlükSatışToolStripMenuItem
            // 
            this.günlükSatışToolStripMenuItem.Name = "günlükSatışToolStripMenuItem";
            this.günlükSatışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.günlükSatışToolStripMenuItem.Text = "Günlük Satış";
            this.günlükSatışToolStripMenuItem.Click += new System.EventHandler(this.günlükSatışToolStripMenuItem_Click);
            // 
            // aylıkSatışToolStripMenuItem
            // 
            this.aylıkSatışToolStripMenuItem.Name = "aylıkSatışToolStripMenuItem";
            this.aylıkSatışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aylıkSatışToolStripMenuItem.Text = "Aylık Satış";
            this.aylıkSatışToolStripMenuItem.Click += new System.EventHandler(this.aylıkSatışToolStripMenuItem_Click);
            // 
            // senelikSatışToolStripMenuItem
            // 
            this.senelikSatışToolStripMenuItem.Name = "senelikSatışToolStripMenuItem";
            this.senelikSatışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.senelikSatışToolStripMenuItem.Text = "Senelik Satış";
            this.senelikSatışToolStripMenuItem.Click += new System.EventHandler(this.senelikSatışToolStripMenuItem_Click);
            // 
            // adminPaneliToolStripMenuItem
            // 
            this.adminPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıAtaToolStripMenuItem,
            this.şifreİşlemleriToolStripMenuItem});
            this.adminPaneliToolStripMenuItem.Name = "adminPaneliToolStripMenuItem";
            this.adminPaneliToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.adminPaneliToolStripMenuItem.Text = "Admin Paneli";
            this.adminPaneliToolStripMenuItem.Click += new System.EventHandler(this.adminPaneliToolStripMenuItem_Click);
            // 
            // kullanıcıAtaToolStripMenuItem
            // 
            this.kullanıcıAtaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem1});
            this.kullanıcıAtaToolStripMenuItem.Name = "kullanıcıAtaToolStripMenuItem";
            this.kullanıcıAtaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kullanıcıAtaToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıAtaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıAtaToolStripMenuItem_Click);
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem2});
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.şifreİşlemleriToolStripMenuItem.Text = "Admin Bilgileri";
            // 
            // webAktarımToolStripMenuItem
            // 
            this.webAktarımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükStokBilgisiToolStripMenuItem,
            this.günlükSatışBilgisiToolStripMenuItem});
            this.webAktarımToolStripMenuItem.Name = "webAktarımToolStripMenuItem";
            this.webAktarımToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.webAktarımToolStripMenuItem.Text = "Web Aktarım";
            // 
            // günlükStokBilgisiToolStripMenuItem
            // 
            this.günlükStokBilgisiToolStripMenuItem.Name = "günlükStokBilgisiToolStripMenuItem";
            this.günlükStokBilgisiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.günlükStokBilgisiToolStripMenuItem.Text = "Günlük Stok Bilgisi";
            this.günlükStokBilgisiToolStripMenuItem.Click += new System.EventHandler(this.günlükStokBilgisiToolStripMenuItem_Click);
            // 
            // günlükSatışBilgisiToolStripMenuItem
            // 
            this.günlükSatışBilgisiToolStripMenuItem.Name = "günlükSatışBilgisiToolStripMenuItem";
            this.günlükSatışBilgisiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.günlükSatışBilgisiToolStripMenuItem.Text = "Günlük Satış Bilgisi";
            this.günlükSatışBilgisiToolStripMenuItem.Click += new System.EventHandler(this.günlükSatışBilgisiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // şifreİşlemleriToolStripMenuItem1
            // 
            this.şifreİşlemleriToolStripMenuItem1.Name = "şifreİşlemleriToolStripMenuItem1";
            this.şifreİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.şifreİşlemleriToolStripMenuItem1.Text = "Şifre İşlemleri";
            this.şifreİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.şifreİşlemleriToolStripMenuItem1_Click);
            // 
            // şifreİşlemleriToolStripMenuItem2
            // 
            this.şifreİşlemleriToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminŞifreAyarlarıToolStripMenuItem,
            this.kullanıcıBilgileriToolStripMenuItem,
            this.mailBilgileriayarlarıToolStripMenuItem});
            this.şifreİşlemleriToolStripMenuItem2.Name = "şifreİşlemleriToolStripMenuItem2";
            this.şifreİşlemleriToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.şifreİşlemleriToolStripMenuItem2.Text = "Şifre İşlemleri";
            this.şifreİşlemleriToolStripMenuItem2.Click += new System.EventHandler(this.şifreİşlemleriToolStripMenuItem2_Click);
            // 
            // adminŞifreAyarlarıToolStripMenuItem
            // 
            this.adminŞifreAyarlarıToolStripMenuItem.Name = "adminŞifreAyarlarıToolStripMenuItem";
            this.adminŞifreAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.adminŞifreAyarlarıToolStripMenuItem.Text = "Admin Şifre Ayarları";
            this.adminŞifreAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.adminŞifreAyarlarıToolStripMenuItem_Click);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // mailBilgileriayarlarıToolStripMenuItem
            // 
            this.mailBilgileriayarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailAyarıEkleToolStripMenuItem,
            this.mailAyarıGÜncelleToolStripMenuItem});
            this.mailBilgileriayarlarıToolStripMenuItem.Name = "mailBilgileriayarlarıToolStripMenuItem";
            this.mailBilgileriayarlarıToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.mailBilgileriayarlarıToolStripMenuItem.Text = "Mail Bilgileri/ayarları";
            // 
            // mailAyarıEkleToolStripMenuItem
            // 
            this.mailAyarıEkleToolStripMenuItem.Name = "mailAyarıEkleToolStripMenuItem";
            this.mailAyarıEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mailAyarıEkleToolStripMenuItem.Text = "Mail Ayarı Ekle";
            this.mailAyarıEkleToolStripMenuItem.Click += new System.EventHandler(this.mailAyarıEkleToolStripMenuItem_Click);
            // 
            // mailAyarıGÜncelleToolStripMenuItem
            // 
            this.mailAyarıGÜncelleToolStripMenuItem.Name = "mailAyarıGÜncelleToolStripMenuItem";
            this.mailAyarıGÜncelleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mailAyarıGÜncelleToolStripMenuItem.Text = "Mail Ayarı Güncelle";
            this.mailAyarıGÜncelleToolStripMenuItem.Click += new System.EventHandler(this.mailAyarıGÜncelleToolStripMenuItem_Click);
            // 
            // stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 476);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokTemizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canlıSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükRaporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkProgramlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senelikRaporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedeklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maiilSistemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükStokSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkStokSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senelilStokSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senelikSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webAktarımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükStokBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükSatışBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adminŞifreAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailBilgileriayarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailAyarıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailAyarıGÜncelleToolStripMenuItem;
    }
}

