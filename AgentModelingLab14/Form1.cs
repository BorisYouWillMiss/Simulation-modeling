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
        private int operatorNumb = 0;
        private double[] operatorStatus;
        private int queue = 0;
        private int queueLim = 0;
        private int[] freeOperatorsIndexes;
        private int freeOperators;
        private int lostClients = 0;


        int[] timeOfDayForLambdas = new int[] { 6, 6, 6, 6 };
        float[] lambdas = new float[] { 0.45f, 1.15f, 1.5f, 0.75f };
        float currentHour = 0;
        float currentDay = 0;

        int overallClients = 0;
        // 1. Client arrival
        // 2. End of service

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                overallClients = 0;
                currentDay = 0;
                currentHour = 0;
                queueLim = (int)numericUpDown1.Value;
                queue = 0;
                startButton.Text = "Stop";
                operatorNumb = (int)editN.Value;
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(operatorNumb);
                freeOperators = operatorNumb;
                lostClients = 0;
                for (int i = 0; i < operatorNumb; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = "Idle";
                    dataGridView1.Rows[i].Cells[1].Value = $"Operator {i + 1}";
                }
                operatorStatus = new double[operatorNumb];
                freeOperatorsIndexes = new int[operatorNumb];
                for (int i = 0;i < operatorNumb; i++)
                {
                    freeOperatorsIndexes[i] = i;
                    operatorStatus[i] = 0;
                }
                    
                timer.Start();
            }
            else if (startButton.Text == "Stop")
            {
                startButton.Text = "Start";
                timer.Stop();
            }
        }

        public bool SimulateClientArrivalPPP()
        {
            float curLambda = 0f;
            //Finding lambda for time of day
            int k = 0;
            float currentTimeDay = currentHour;
            while(currentTimeDay >= 0)
            {
                currentTimeDay -= timeOfDayForLambdas[k];
                if (currentTimeDay < 0) break;
                else k++;
            }
            curLambda = lambdas[k];

            currentTimeDay = currentHour;

            while (true)
            {
                //New possible time for arrival (newTimeOfDayArrival can be > 24 (for day counting purposes))
                float newTimeOfDayArrival = currentHour + (-(float)Math.Log(rand.NextDouble()) / curLambda);
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
                    float timeHoursDif = Math.Abs(hourOfArrival - currentHour); //0.5hour - 23.5hour (should be 1 hour dif) (reality = 23hours)
                    if (hourOfArrival < currentHour)
                    {
                        float first = Math.Abs(24 - currentHour);
                        timeHoursDif = Math.Abs(hourOfArrival + first);
                    }

                    currentHour = hourOfArrival;

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
            lbCurrentHour.Text = "Текущее время (час): " + String.Format("{0:N3}", currentHour);

            // Counting all work done
            for (int i = 0; i < operatorNumb; i++)
            {
                if (currentDay * 100 > operatorStatus[i] && operatorStatus[i] != 0)
                {
                    operatorStatus[i] = 0;
                    freeOperators++;
                    freeOperatorsIndexes[freeOperators - 1] = i;
                    dataGridView1.Rows[freeOperatorsIndexes[freeOperators - 1]].Cells[0].Value = "Idle";
                }
            }

            // Another dude came
            queue++;
            double a = 0;
            for (; freeOperators > 0 & queue > 0; queue--) // Putting all people into free places
            {
                a = -Math.Log(rand.NextDouble()) / lambdas[(int)(currentHour / 6)];  // part of formula where (-ln(a)/lambda)
                operatorStatus[freeOperatorsIndexes[freeOperators - 1]] = (int)((currentDay + a / 24) * 100 + a % 24);
                dataGridView1.Rows[freeOperatorsIndexes[freeOperators - 1]].Cells[0].Value = "Working";
                freeOperatorsIndexes[freeOperators - 1] = -1;
                freeOperators--;
            }

            if (queue > queueLim)
            {
                lostClients += queue - queueLim;
                queue = queueLim;
            }
            label2.Text = $"Current Queue {queue}";
            lbLostClients.Text = $"Ушедшие клиенты: {lostClients}";
            

        }
    }
}
