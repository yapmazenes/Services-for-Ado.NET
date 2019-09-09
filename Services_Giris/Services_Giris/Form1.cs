using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services_Giris.UrunServiceReference;
namespace Services_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kimlik k = new Kimlik { KullaniciAdi = "Admin", Parola = "123" };
        private void button1_Click(object sender, EventArgs e)
        {
            UrunlerServiceSoapClient client = new UrunlerServiceSoapClient();
            string msg = client.HelloWorld();
            MessageBox.Show(msg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunlerServiceSoapClient cl = new UrunlerServiceSoapClient();
            dataGridView1.DataSource = cl.UrunlerListesi(k);
        }
    }
}
