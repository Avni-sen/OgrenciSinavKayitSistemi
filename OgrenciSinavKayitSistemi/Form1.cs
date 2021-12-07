using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinavKayitSistemi
{
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        private void BtbGiris_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay frm = new FrmOgrenciDetay();
            frm.numara = MtxOgrenciNo.Text;
            frm.Show();

        }

        private void ogretmen_giris(object sender, EventArgs e)
        {
            if (MtxOgrenciNo.Text =="111111111" && MtxSifre.Text=="111111111")
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.Show();
            }
        }
    }
}
