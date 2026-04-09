using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Stok_Giriş : Form
    {
        public Stok_Giriş()
        {
            InitializeComponent();
        }
        string resimPath=string.Empty;
        baglanti bg = new baglanti();
        string y;
     

        Kullanici_Giris gr = (Kullanici_Giris)System.Windows.Forms.Application.OpenForms["Kullanici_Giris"];

      

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Stok_Giriş_Load(object sender, EventArgs e)
        {
           /* y=gr.k_yetki.ToString();
            MessageBox.Show(gr.k_yetki.ToString());*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void urunResmi_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title="Eda Yazılım Stok Takip Otomasyonu";
            openFileDialog1.FileName = "Resim Seç";
            openFileDialog1.Filter = "JPG Dosyaları|*.jpg|PNG Dosyaları|*.png|Tüm Dosyalar|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                resimPath =openFileDialog1.FileName.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytresim = null;
                FileInfo fileInfo = new FileInfo(resimPath);
                long sayac = fileInfo.Length;
                FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                bytresim = br.ReadBytes((int)sayac);
                SqlConnection con = bg.baglantim();
                SqlCommand kmt = new SqlCommand("sp_urun_ekle", con);
                kmt.CommandType = CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@urun_kodu", textKodu.Text .Trim());
                kmt.Parameters.AddWithValue("@urun_adi", textAd.Text .Trim());
                kmt.Parameters.AddWithValue("@urun_fiyati", float .Parse(textFiyat.Text.Trim()));
                kmt.Parameters.AddWithValue("@urun_cinsi", comboBox1.Text.Trim());
                kmt.Parameters.AddWithValue("@urun_adedi",int .Parse(textAdedi.Text.Trim()));    
                kmt.Parameters.AddWithValue("@kritik_stok",int .Parse(textStok.Text.Trim()));
                kmt.Parameters.AddWithValue("@urun_resmi",bytresim .ToString());
                kmt.Parameters.AddWithValue("@Urun_ekleyen", gr.k_yetki .ToString());
                int sonuc = kmt.ExecuteNonQuery();
                if (sonuc == -1)
                {
                    MessageBox.Show("Bu ürün Stoklarımızda vardır. Aynı ürünü kaydedilmez", "Eda Otomasyon");
                }
                else
                {
                    MessageBox.Show("Ürün Başarılı bir şekilde kaydedildi"," Eda Otomasyonu");
                }
                    con.Close();   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eda Yazılım Stok Takip Otomasyonu");
            }
        }
        public void resim_b()
        {
            byte[] bytresim = null;
            FileInfo finfo = new FileInfo(resimPath);
            long sayac = finfo.Length; 
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);  
            BinaryReader br = new BinaryReader(fs);
            bytresim = br.ReadBytes((int)sayac);

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }
    }
}
