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

namespace WindowsFormsApp1
{
    public partial class Stok_Silme: Form
    {
        public Stok_Silme()
        {
            InitializeComponent();
        }
        Stok_Guncelleme sg = (Stok_Guncelleme)System.Windows.Forms.Application.OpenForms["Stok_Guncelleme"];
        baglanti bgl = new baglanti();
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
       
        public void gncl()
        {
            DataTable dt = bgl.Tablo("Select * from Stok");
            datagrid_veriler.DataSource = dt;
        }
        private void guncelleme_Click(object sender, EventArgs e)
        {

            try
            {
                if (textKodu.Text == String.Empty)
                {
                    MessageBox.Show("Lütfen Aşağıdan Ürün Seçiniz", "Eda Stok Takip Otomasyon");
                }
                else
                {
                    if (MessageBox.Show( "Seçilen veriyi silmekte emin misiniz?", "Eda Stok Takip Otomasyon", MessageBoxButtons.OKCancel,  MessageBoxIcon.Question ) == DialogResult.OK)
                    {
                        SqlConnection con = bgl.baglantim();
                        SqlCommand kmt = new SqlCommand("sp_urun_sil", con);
                        kmt.CommandType = CommandType.StoredProcedure;
                        kmt.Parameters.AddWithValue("@urun_kodu", textKodu.Text.Trim());
                        kmt.ExecuteNonQuery();
                        con.Close();
                        gncl();
                    }

                    else { }
                }
            }
            catch (Exception ex) { }
        }

        private void Stok_Silme_Load(object sender, EventArgs e)
        {
            gncl();
            dzn();
        }

        private void datagrid_veriler_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void datagrid_veriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textKodu.Text = datagrid_veriler.CurrentRow.Cells[1].Value.ToString();
            textAd.Text = datagrid_veriler.CurrentRow.Cells[2].Value.ToString();
            textFiyat.Text = datagrid_veriler.CurrentRow.Cells[3].Value.ToString();
            textCins.Text = datagrid_veriler.CurrentRow.Cells[4].Value.ToString();
            textAdedi.Text = datagrid_veriler.CurrentRow.Cells[5].Value.ToString();
            textStok.Text = datagrid_veriler.CurrentRow.Cells[6].Value.ToString();
            bgl.Reader(textKodu.Text, pictureBox1);
        }
    }
}
