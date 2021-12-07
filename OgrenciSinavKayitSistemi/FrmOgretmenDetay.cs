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

namespace OgrenciSinavKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-704QU67;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet.TBL_DERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);

        }

       
        private void BtbOgrenciKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_DERS (OGRNO, OGRAD, OGRSOYAD,OGRSIFRE )values (@p1,@p2,@p3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@p1", MtxOgrNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
        }
    }
}
