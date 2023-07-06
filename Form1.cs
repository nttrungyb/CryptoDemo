using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentGateway.CryptoDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            Crypto _crypto = new Crypto();
            var _rawString = txtRawString.Text;
            var _signature = txtSignatureString.Text;
            string _publicKeyPath = "D:\\Project\\ARMC\\Payment Gateway\\PaymentGateway\\PaymentGateway.CryptoDemo2\\Data\\Key\\Vietinbank_ITC2020.cer";
            var _isValid = _crypto.VerifyData(_signature, _rawString, _publicKeyPath);

            MessageBox.Show($"Kết quả kiểm tra: {_isValid}");
        }
    }
}
