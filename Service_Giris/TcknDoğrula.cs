using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Giris.TCKNServiceReference;
namespace Service_Giris
{
    public partial class TcknDoğrula : Form
    {
        public TcknDoğrula()
        {
            InitializeComponent();
        }

        private void TcknDoğrula_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        private void btndogrula_Click(object sender, EventArgs e)
        {
            long tckn = Convert.ToInt64(mskdTckn.Text);
            string isim = txtİsim.Text.ToUpper();
            string soyisim = txtSoyisim.Text.ToUpper();
            int dogumYili = Convert.ToInt32(mskdDogumyili.Text);

            KPSPublicSoapClient client = new KPSPublicSoapClient();


           bool sonuc= client.TCKimlikNoDogrula(tckn, isim, soyisim, dogumYili);
            if (sonuc)
            {
                MessageBox.Show("Bilgileriniz Doğru");
            }
            else
            {
                MessageBox.Show("Bilgileriniz Yanlış");
            }

        }
    }
}
