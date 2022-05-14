using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomEventsLab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            double variance = (double)varianceEdit.Value;
            double mean = (double)meanEdit.Value;
            int sample = (int)sampleEdit.Value;

            double[] array = new double[sample];

            for (int i = 0; i < sample; i++)
            {
                double BoxMuller = Math.Sqrt(-2 * Math.Log(rand.NextDouble())) * Math.Cos(2 * Math.PI * rand.NextDouble());

                array[i] = BoxMuller * variance + mean;

            }

            int k = (int)Math.Log(sample, 2) + 1;

            double max = -100;
            double min = 100;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
                
            }

            double interval =  (double)(max- min)/(double)k;

            double[] distribution = new double[k];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (array[i] <= min + interval * (j + 1))
                    {
                        distribution[j]++;
                        j = k;
                    }
                }
            }

            double dispersion = 0;
            double Mittelwert = 0;
            double square = 0;
            double probs = 0;


            for (int i = 0; i < distribution.Length; i++)
            {
                Mittelwert += (double)distribution[i] / (double)sample * i;
                probs = func(min + (interval/2) * (i + 1), variance, mean);
                square += (double)(distribution[i] * distribution[i]) / (double)(sample * (double)probs);
            }
            square -= sample;
            square = Math.Round(square, 2);

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < distribution.Length; i++)
            {
                dispersion += (double)distribution[i] / (double)(sample) * (i - Mittelwert) * (i - Mittelwert);
                distribution[i] = (double)distribution[i] / (double)sample;
                chart1.Series[0].Points.AddXY("("+ Math.Round(min + interval * i, 2) + ";"+Math.Round(min + interval * (i+1),2)+"]", distribution[i]);
            }

            label4.Text = "Average: " + Math.Round(Mittelwert,2).ToString() + " (error = " + Math.Round(Math.Abs((float)(mean - Mittelwert)) / mean * 100, 2) + "%)";
            label5.Text = "Variance: " + Math.Round(dispersion,2).ToString() + " (error = " + Math.Round(Math.Abs((float)(dispersion - variance)) / variance * 100, 2) + "%)";
            label6.Text = "Chi-squared: " + square + " > 11.07 is ";
            if (square > 11.07)
                label6.Text += "true";
            else label6.Text += "false";
        }

        private double func(double x, double var, double m)
        {


            return 1 / (Math.Sqrt(var) * Math.Sqrt(2 * Math.PI)) * Math.Pow(Math.E, -((x-m)*(x-m))/(2*var));
        }

    }
}
