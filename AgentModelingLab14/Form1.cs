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

        int[] timeOfDayForLabdas = new int[] { 6, 12, 18, 24};
        float[] lambdas = new float[] { 0f, 1f, 1.5f,  0.35f};
        float currentTimeOfDay = 0;
        float currentDay = 0;

        public bool SimulateClientArrivalPPP()
        {
            float curLambda = 0f;
            //Finding lambda for time of day
            int k = 0;
            float currentTime = currentTimeOfDay;
            while(currentTime >=0)
            {
                currentTime -= timeOfDayForLabdas[k];
                if (currentTime < 0) break;
                else k++;
            }
            curLambda = lambdas[k];

            currentTime = currentTimeOfDay;

            //New possible time for arrival
            float newTimeofDayArrival = currentTimeOfDay + (-(float)Math.Log(rand.NextDouble()) / curLambda);
            //newTimeofDayArrival = newTimeofDayArrival 

            return true;///
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SimulateClientArrivalPPP();
        }
    }
}
