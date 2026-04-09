using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Stok_Guncelleme : Form
    {
        public Stok_Guncelleme()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void gncl()
        { DataTable dt = bgl.Tablo("Select * from Stok");
            datagrid_veriler.DataSource = dt;
        }
        public void dzn()
        {
            datagrid_veriler.Columns[0].HeaderText = "ID";
            datagrid_veriler.Columns[1].HeaderText = "Ürün Barkod Numarası";
            datagrid_veriler.Columns[2].HeaderText = "Ürün Adı";
            datagrid_veriler.Columns[3].HeaderText = "Ürün Fiyatı";
            datagrid_veriler.Columns[4].HeaderText = "Ürün Cinsi";
            datagrid_veriler.Columns[5].HeaderText = "Ürün Adedi";
            datagrid_veriler.Columns[6].HeaderText = "Kritik Stok";
            datagrid_veriler.Columns[7].HeaderText = "Ürün Resmi";
            datagrid_veriler.Columns[8].HeaderText = "Saat";
            datagrid_veriler.Columns[9].HeaderText = "Tarih";
            datagrid_veriler.Columns[10].HeaderText = "Ekleyen Kişi";
        }
        baglanti bgl = new baglanti();
        Kullanici_Giris gr = (Kullanici_Giris)System.Windows.Forms.Application.OpenForms["Kullanici_Giris"];
        string resimPath = string.Empty;
        private void Stok_Guncelleme_Load(object sender, EventArgs e)
        {
            gncl();
            dzn();
        }
        
        private void datagrid_veriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (datagrid_veriler.CurrentRow == null) return;

            DataGridViewRow row = datagrid_veriler.CurrentRow;

            textKodu.Text = row.Cells["urun_kodu"].Value.ToString();
            textAd.Text = row.Cells["urun_adi"].Value.ToString();
            textFiyat.Text = row.Cells["urun_fiyati"].Value.ToString();
            textCins.Text = row.Cells["urun_cinsi"].Value.ToString();
            textAdedi.Text = row.Cells["urun_adedi"].Value.ToString();
            textStok.Text = row.Cells["kritik_stok"].Value.ToString();

            bgl.Reader(textKodu.Text, pictureBox1);
        }
        private void guncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                if (resimPath == "")
                {
                    resimli_proc();
                    gncl();
                }
                else
                {
                    resimsiz_proc();
                    gncl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eda Stok Takip Otomasyonu");
            }
        }
        public void resimsiz_proc()
        {
            SqlConnection con = bgl.baglantim();
            SqlCommand kmt = new SqlCommand("sp_urun_guncelle_resimsiz", con);
            kmt.CommandType = CommandType.StoredProcedure;

            kmt.Parameters.AddWithValue("@urun_kodu", textKodu.Text.Trim());
            kmt.Parameters.AddWithValue("@urun_adi", textAd.Text.Trim());
            kmt.Parameters.AddWithValue("@urun_fiyati", float.Parse(textFiyat.Text.Trim()));
            kmt.Parameters.AddWithValue("@urun_cinsi", textCins.Text.Trim());
            kmt.Parameters.AddWithValue("@urun_adedi", int.Parse(textAdedi.Text.Trim()));
            kmt.Parameters.AddWithValue("@kritik_stok", int.Parse(textStok.Text.Trim()));
            kmt.Parameters.AddWithValue("@Urun_ekleyen", gr.k_yetki.ToString());

            kmt.ExecuteNonQuery(); // ⭐ BUNU EKLEDİK
            con.Close();
        }

        public void resimli_proc()
        {
            byte[] bytresim = null;
            FileInfo fileInfo = new FileInfo(resimPath);
            long sayac = fileInfo.Length;
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            bytresim = br.ReadBytes((int)sayac);
            SqlConnection con = bgl.baglantim();
            SqlCommand kmt = new SqlCommand("sp_urun_guncelle_resimli", con);
            kmt.CommandType = CommandType.StoredProcedure;
            kmt.Parameters.AddWithValue("@urun_kodu", textKodu.Text.Trim());
            kmt.Parameters.AddWithValue("@urun_adi", textAd.Text.Trim());
            kmt.Parameters.AddWithValue("@urun_fiyati", float.Parse(textFiyat.Text.Trim()));
            kmt.Parameters.AddWithValue("@urun_cinsi", textCins.Text.Trim());
            kmt.Parameters.AddWithValue("@urun_adedi", int.Parse(textAdedi.Text.Trim()));
            kmt.Parameters.AddWithValue("@kritik_stok", int.Parse(textStok.Text.Trim()));
            kmt.Parameters.Add("@urun_resmi", SqlDbType.VarBinary).Value = bytresim;
            kmt.Parameters.AddWithValue("@Urun_ekleyen", gr.k_yetki.ToString());
            int sonuc = kmt.ExecuteNonQuery();
            con.Close();
        }

        private void datagrid_veriler_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}

