using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchangeLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        const double k = 0.05;
        double rateEuro, rateDollar;
        int days = 0;
        Random random = new Random();

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            if (buttonPredict.Text == "Stop")
            {
                buttonPredict.Text = "Predict again";
                timer1.Stop();
                days = 0;
            }
            else
            {
                rateEuro = (double)editExRateEuro.Value;
                rateDollar = (double)editExRateDollar.Value;
                //days = (int)editDays.Value;

                chartLines.Series[0].Points.Clear();
                chartLines.Series[0].Points.AddXY(0, rateEuro);

                chartLines.Series[1].Points.Clear();
                chartLines.Series[1].Points.AddXY(0, rateDollar);

                buttonPredict.Text = "Stop";
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                
            rateEuro = rateEuro * (1 + k * (random.NextDouble() - 0.5));
            rateDollar = rateDollar * (1 + k * (random.NextDouble() - 0.5));
            chartLines.Series[0].Points.AddXY(days, rateEuro);
            chartLines.Series[1].Points.AddXY(days, rateDollar);
            days++;

        }
    }
}
