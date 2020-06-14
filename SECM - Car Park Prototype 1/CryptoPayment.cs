using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using System.Net;
using System.IO;

namespace SECM___Car_Park_Prototype_1
{
    public partial class CryptoPayment : Form
    {
        PaymentMachine _pM;
        double _totalPrice, moneyReceived = 0;
        public CryptoPayment(PaymentMachine pM, double totalPrice)
        {
            InitializeComponent();
            var firebase = new FirebaseClient("https://qrcodepayment-5f0c4.firebaseio.com/cryptopayment/");
            Task await = firebase.Child("due").PutAsync(totalPrice.ToString());
            _pM = pM;
            _totalPrice = totalPrice;
            amountdue_lbl.Text = totalPrice.ToString() + " GBP";
            qrcodeBox.Image = Properties.Resources.qrcode;
            timer1.Start();
        }

        private void paymentstatus_lbl_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            var firebase = new FirebaseClient("https://qrcodepayment-5f0c4.firebaseio.com/cryptopayment/");
            Task await = firebase.Child("received").PutAsync(0);

            MessageBox.Show("Payment received.");
            _pM.SetQRPaid(moneyReceived);
            this.Close();

        }

        private void timer1_TickAsync(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp("https://qrcodepayment-5f0c4.firebaseio.com/cryptopayment/received/.json");
            request.Method = "GET";
            request.ContentType = "application/json: charset-utf-8";

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream responsestream = response.GetResponseStream())
            {
                StreamReader Read = new StreamReader(responsestream, Encoding.UTF8);
                moneyReceived = Convert.ToDouble(Read.ReadToEnd().ToString());
                if(moneyReceived == _totalPrice)
                    paymentstatus_lbl.Text = "Paid";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
