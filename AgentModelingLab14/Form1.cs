using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentModelingLab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random(Guid.NewGuid().GetHashCode());

        // 1. Client arrival
        // 2. End of service

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                startButton.Text = "Stop";
                timer.Start();
            }
            else if (startButton.Text == "Stop")
            {
                startButton.Text = "Start";
                timer.Stop();
            }
        }

        int[] timeOfDayForLambdas = new int[] { 6, 6, 6, 6};
        float[] lambdas = new float[] { 0.45f, 1.15f, 1.5f,  0.75f};
        float currentTimeOfDay = 0;
        float currentDay = 0;

        int overallClients = 0;

        public bool SimulateClientArrivalPPP()
        {
            float curLambda = 0f;
            //Finding lambda for time of day
            int k = 0;
            float currentTimeDay = currentTimeOfDay;
            while(currentTimeDay >= 0)
            {
                currentTimeDay -= timeOfDayForLambdas[k];
                if (currentTimeDay < 0) break;
                else k++;
            }
            curLambda = lambdas[k];

            currentTimeDay = currentTimeOfDay;

            while (true)
            {
                //New possible time for arrival (newTimeOfDayArrival can be > 24 (for day counting purposes))
                float newTimeOfDayArrival = currentTimeOfDay + (-(float)Math.Log(rand.NextDouble()) / curLambda);
                float hourOfArrival = newTimeOfDayArrival;
                if(hourOfArrival > 24) hourOfArrival -= 24;
                    

                int lambdaint = (int)(curLambda * 100);

                float u = 0f;
                u = (float)((int)(rand.NextDouble() * (lambdaint + 1))) / 100f;

                //lambda for new time
                k = 0;
                currentTimeDay = hourOfArrival;
                while (currentTimeDay >= 0)
                {
                    currentTimeDay -= timeOfDayForLambdas[k];
                    if (currentTimeDay < 0) break;
                    else k++;
                }
                float newLambda = lambdas[k];

                if (newLambda >= u)
                {
                    //Lets gooooo
                    float timeHoursDif = Math.Abs(hourOfArrival - currentTimeOfDay); //0.5hour - 23.5hour (should be 1 hour dif) (reality = 23hours)
                    if (hourOfArrival < currentTimeOfDay)
                    {
                        float first = Math.Abs(24 - currentTimeOfDay);
                        timeHoursDif = Math.Abs(hourOfArrival + first);
                    }

                    currentTimeOfDay = hourOfArrival;

                    currentDay += timeHoursDif / 24f;
                    overallClients++;
                    return true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SimulateClientArrivalPPP();
            lbAllClients.Text = "Всего клиентов пришло: " + overallClients.ToString();
            lbLastClientTime.Text = "Время прихода последнего клиента (день): " + String.Format("{0:N3}", currentDay);
            lbCurrentHour.Text = "Текущее время (час): " + String.Format("{0:N3}", currentTimeOfDay);
        }
    }
}
