using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Giris.UrunlerServiceReferance;
namespace WCF_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunlerServiceClient client = new UrunlerServiceClient();
            string mesaj= client.DoWork();
            MessageBox.Show(mesaj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunlerServiceClient cl = new UrunlerServiceClient();
            dataGridView1.DataSource = cl.UrunListesi();
            cl.Close();
        }
    }
}
