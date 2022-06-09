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
    }
}
