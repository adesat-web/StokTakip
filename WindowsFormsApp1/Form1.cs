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
    public partial class stok: Form
    {
        public stok()
        {
            InitializeComponent();
        }
        class bağlanti
        {    public SqlConnection baglantım()
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stok;Integrated Security=True");
                if(con.State== ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void satToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void günlükStokSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Günlük_mail gm =new Günlük_mail();
            gm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Giriş sg = new Stok_Giriş();
            sg.ShowDialog();
        }

        private void txtkodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void stokTemizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Silme sg = new Stok_Silme();
            sg.ShowDialog();
        }

        private void stokGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Guncelleme sg = new Stok_Guncelleme();
            sg.ShowDialog();
        }

        private void canlıSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canlı_Satış cs = new Canlı_Satış();
            cs.ShowDialog();
        }

        private void günlükRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Günlük_Raporlama gr = new Günlük_Raporlama();
            gr.ShowDialog();
        }

        private void aylıkStokSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aylık_mail ay = new Aylık_mail();
            ay.ShowDialog();
        }

        private void senelilStokSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Senelik_mail sm = new Senelik_mail();
            sm.ShowDialog();
        }

        private void aylıkProgramlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aylık_Rapor ar = new Aylık_Rapor();
            ar.ShowDialog();
        }

        private void senelikRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Senelik_Raporlama sn = new Senelik_Raporlama();
            sn.ShowDialog();
        }

        private void günlükSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Günlük_satış_mail gsm =new Günlük_satış_mail();
            gsm.ShowDialog();
        }

        private void aylıkSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aylık_satıs_mail asm = new Aylık_satıs_mail();
            asm.ShowDialog();
        }

        private void senelikSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Senelik_satıs_maili ssm = new Senelik_satıs_maili();
            ssm.ShowDialog();
        }

        private void kullanıcıAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mailAyarıGÜncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail_Ayarlari_Guncelleme mag = new Mail_Ayarlari_Guncelleme();
            mag.ShowDialog();
        }

        private void şifreİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kullanici_Sifre_islemleri ksi = new Kullanici_Sifre_islemleri();
            ksi.ShowDialog();
        }

        private void şifreİşlemleriToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void adminŞifreAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Sifre_islemleri asi = new Admin_Sifre_islemleri();
            asi.ShowDialog();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanici_Sifre_islemleri ksi = new Kullanici_Sifre_islemleri();
            ksi.ShowDialog();
        }

        private void mailAyarıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail_Ayarı ma = new Mail_Ayarı();
            ma.ShowDialog();
        }

        private void günlükStokBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Web_Gunluk_Stok_Bilgisi wgsb = new Web_Gunluk_Stok_Bilgisi();
            wgsb.ShowDialog();
        }

        private void günlükSatışBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Web_Gunluk_Satıs_Bilgisi wgsb = new Web_Gunluk_Satıs_Bilgisi();
            wgsb.ShowDialog();
        }
    }
}
