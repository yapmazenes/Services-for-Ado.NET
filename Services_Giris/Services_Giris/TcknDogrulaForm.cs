using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services_Giris.TcknKPSPublicService;
namespace Services_Giris
{
    public partial class TcknDogrulaForm : Form
    {
        public TcknDogrulaForm()
        {
            InitializeComponent();
        }

        private void TcknDogrulaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Dogrula_Click(object sender, EventArgs e)
        {
            long tckn = Convert.ToInt64(mskdTCKN.Text);
            string isim = txt_isim.Text.ToUpper();
            string soyisim = txt_soyisim.Text.ToUpper();
            int dogumyili = Convert.ToInt32(msk_txt_dogumyili.Text);
            KPSPublicSoapClient cl = new KPSPublicSoapClient();

       bool sonuc=cl.TCKimlikNoDogrula(tckn, isim, soyisim, dogumyili);
       if (sonuc)
       {
           MessageBox.Show("TCKN Doğrulandı");
           
       }
       else
       {
           MessageBox.Show("Yok");
       }
        }
    }
}
