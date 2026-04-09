using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Kullanici_Giris : Form
    {
        public Kullanici_Giris()
        {
            InitializeComponent();
        }

        private void Kullanici_Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        baglanti bgl= new baglanti();
        string pcModeli;
        string pcIsmi;
        Mail_Ayarı m= new Mail_Ayarı();
        public string k_yetki;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = bgl.baglantim();
                SqlCommand kmt = new SqlCommand("sp_kullanici_girisi", con);
                kmt.CommandType = CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@k_adi", txt_k_adi.Text);
                kmt.Parameters.AddWithValue("@k_sifre", txt_k_sifre.Text);
                kmt.Parameters.AddWithValue("@pc_ismi", txt_k_adi.Text);
                kmt.Parameters.AddWithValue("@pc_modeli", txt_k_sifre.Text);
                kmt.Parameters.AddWithValue("@giris_kullanici_bilgisi", txt_k_adi.Text);
                int sonuc= kmt.ExecuteNonQuery();
            
                if(sonuc == -1) {
                    MessageBox.Show("Bilgilerinizi Lütfen Kontrol Edin", "Eda Yazılım Otomasyon Sistemi");
                   }
                else if(sonuc==1)
                {   k_yetki=txt_k_adi.Text;
                    this.Hide();
                    stok f1 = new stok();
                    f1.Show();
                }}
            catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eda Stok Takip Otomasyonu");
                    }
        }
    }
}
