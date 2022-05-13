using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomEventsLab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int GetChances()
        {
            return (int)(edit1.Value + edit2.Value + edit3.Value + edit4.Value);
        }

        int[] prevChances;
        int[] emp = new int[5];
        private void Form1_Load(object sender, EventArgs e)
        {
            labelAuto.Text = (100 - GetChances()).ToString();
            prevChances =  new int[5];
            for (int i = 0; i < 5; i++)
            {
                prevChances[i] = 20;
                emp[i] = 0;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < editTestsNumber.Value; i++)
            {
                int dice = rand.Next(101);
                int j = -1;

                while (dice > 0 && j<4)
                {
                    j++;
                    dice -= prevChances[j];
                }
                if (j == -1) j = 0;
                emp[j]++;
            }

            double sum = 0;
            for (int i = 0; i < 5; i++)
                sum += emp[i];

            chart1.Series[0].Points.Clear();

            double Mittelwert = 0;
            float newsum = 0;
            double square = 0;

            for (int i = 0; i < 5; i++)
            {
                chart1.Series[0].Points.AddXY(i, (float)emp[i] / (float)(sum));
                Mittelwert += (float)emp[i] / (float)(sum)   * i;
                newsum += (float)prevChances[i] / 100 * i;
                square += (float)(emp[i]*emp[i])/(float)(sum*(float)(prevChances[i])/100);
            }
            square -= sum;
            square = Math.Round(square,2);

            double dispersion = 0;
            double dispersionFlawless = 0;

            for (int i = 0; i < 5; i++)
            {
                dispersion += (float)(emp[i]/(float)(sum))*(i - Mittelwert)*(i - Mittelwert);
                dispersionFlawless += (float)(prevChances[i] / (float)100) * (i - newsum) * (i - newsum);
                emp[i] = 0;
            }

            dispersion = Math.Round(dispersion, 3);

            labelAverage.Text = "Average: " + Mittelwert.ToString() + " (error = "+Math.Round(Math.Abs((float)(newsum - Mittelwert))/ newsum * 100, 2)+"%)";
            labelVariance.Text = "Variance: " + dispersion.ToString() + " (error = "+Math.Round(Math.Abs((float)(dispersion - dispersionFlawless))/dispersionFlawless * 100, 2) +"%)";
            labelSquared.Text = "Chi-squared: "+square+" > 9.488 is ";
            if (square > 9.488)
                labelSquared.Text += "true";
            else labelSquared.Text += "false";

        }

        private void edit1_ValueChanged_1(object sender, EventArgs e)
        {
            if (GetChances() <= 100)
            {
                prevChances[0] = (int)edit1.Value;
                labelAuto.Text = (100 - GetChances()).ToString();
            }

            if (GetChances() + int.Parse(labelAuto.Text) > 100)
            {
                edit1.Value = prevChances[0];
            }
        }

        private void edit2_ValueChanged(object sender, EventArgs e)
        {
            if (GetChances() <= 100)
            {
                prevChances[1] = (int)edit2.Value;
                labelAuto.Text = (100 - GetChances()).ToString();
            }

            if (GetChances() + int.Parse(labelAuto.Text) > 100)
            {
                edit2.Value = prevChances[1];
            }
        }

        private void edit3_ValueChanged(object sender, EventArgs e)
        {
            if (GetChances() <= 100)
            {
                prevChances[2] = (int)edit3.Value;
                labelAuto.Text = (100 - GetChances()).ToString();
            }

            if (GetChances() + int.Parse(labelAuto.Text) > 100)
            {
                edit3.Value = prevChances[2];
            }
        }

        private void edit4_ValueChanged(object sender, EventArgs e)
        {
            if (GetChances() <= 100)
            {
                prevChances[3] = (int)edit4.Value;
                labelAuto.Text = (100 - GetChances()).ToString();
            }

            if (GetChances() + int.Parse(labelAuto.Text) > 100)
            {
                edit4.Value = prevChances[3];
            }
        }
    }
}
