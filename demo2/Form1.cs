using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo2
{
    public partial class Form1 : Form
    {
        private ServiceReference1.WebService1SoapClient ws;
        public Form1()
        {
            InitializeComponent();
            ws = new ServiceReference1.WebService1SoapClient();
        }

        private void VND2USD_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.VND2USD(mon);

            lblKetQua.Text = usd.ToString();
        }
    }
}
