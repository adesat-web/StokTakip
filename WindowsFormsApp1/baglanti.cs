using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class baglanti
    {
        public SqlConnection baglantim()
        {
            SqlConnection con = new SqlConnection(@"Server=EYDA; Integrated Security=true; Database=eda_stok_takip");
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public SqlConnection baglantim_kapat()
        {
            SqlConnection con = new SqlConnection(@"Server=EYDA; Integrated Security=true; Database=eda_stok_takip");
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
        public DataTable Tablo(string sqlCumlem)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sqlCumlem, baglantim());
            DataTable dt = new DataTable();
            try
            {
                baglantim();
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu..." + ex.Message);
            }
            adap.Dispose();
            baglantim_kapat();
            return dt;
        }
        public SqlDataReader Reader(string urun_kodu,PictureBox pictureBox1)
        {
            baglantim();
            SqlCommand komut = new SqlCommand("select urun_resmi from Stok where urun_kodu" + urun_kodu + " " + baglantim());
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    System.Drawing.Image UyeResim=null;
                    byte[] resim = (byte[])(dr[0]);
                    MemoryStream ms = new MemoryStream(resim, 0, resim.Length);
                    ms.Write(resim, 0, resim.Length);
                    UyeResim = System.Drawing.Image.FromStream(ms, true);
                    pictureBox1.Image = UyeResim;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eda stok takip otomasyonu");
            }
            return dr;
        }
    }
}
