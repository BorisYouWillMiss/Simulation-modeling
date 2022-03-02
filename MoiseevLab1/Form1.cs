using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoiseevLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double g = 9.81;
        const double c = 0.15;
        const double rho = 1.29;

        double dt;
        double height, angle, speed, size, mass;
        double cosa, sina, beta, k;
        double spd = 0, maxheight = 0;


        private void buttonBreak_MouseEnter(object sender, EventArgs e)
        {
            buttonBreak.BackColor = Color.Red;

        }

        private void buttonBreak_MouseLeave(object sender, EventArgs e)
        {
            buttonBreak.BackColor = Color.Gray;
        }

        private void buttonBreak_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            chart1.Series[0].Points.Clear();
        }

        double t, x, y, vx, vy;

        private void btnStart_Click(object sender, EventArgs e)
        {
            height = (double)editHeight.Value;
            angle = (double)editAngle.Value;
            speed = (double)editSpeed.Value;
            size = (double)editSize.Value;
            mass = (double)editMass.Value;
            dt = (double)editStep.Value;

            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);

            beta = 0.5 * c * size * rho;
            k = beta / mass;

            t = 0;
            x = 0;
            y = height;
            vx = speed * cosa;
            vy = speed * sina;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x,y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double root = Math.Sqrt(vx * vx + vy * vy);

            t = t + dt;

            vx = vx - k * vx * root * dt;
            vy = vy - (g + k * vy * root) * dt;

            x = x + vx * dt;
            y = y + vy * dt;
            chart1.Series[0].Points.AddXY(x, y);

            if (maxheight < y)
            {
                maxheight = y;
            }
            if (spd < root)
            {
                spd = root;
            }

            if (y <= 0)
            {
                dataGridView1.Rows.Add(dt, x, maxheight, spd);
                timer1.Stop();
                maxheight = 0;
                spd = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].ValueType = typeof(double);
            }
            dataGridView1.AllowUserToDeleteRows = true;
        }
    }
}
