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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-704QU67;Initial Catalog=DbNotKayit;Integrated Security=True");
        
        
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblOgrNo.Text = numara;
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from TBL_DERS where OGRNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[3].ToString() + " " + dr[4].ToString();
                LblVize.Text = dr[5].ToString();
                LblFinal.Text = dr[6].ToString();
                LblProje.Text = dr[7].ToString();
                LblOrt.Text = dr[8].ToString();
                LblDurum.Text = dr[9].ToString();
            }
            baglanti.Close();
        }
    }
}
