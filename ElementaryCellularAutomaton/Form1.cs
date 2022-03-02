using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementaryCellularAutomaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int buttonNumber = 0;
        int rows = 0; 
        int columns = 0;
        int rule = 0;
        int step = 0;
        int cr;
        int[] previousDeck;
        string board;
        Button[] cells;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            rows = (int)editRows.Value;
            columns = (int)editColumns.Value;
            rule = (int)editRule.Value;
            step = columns;

            buttonNumber = rows * columns;

            panelStart.Enabled = false;
            panelStop.Enabled = true;

            progressBar.Maximum = buttonNumber;

            // MEASUREMENTS

            int height = (panelCells.Height / rows);
            int width = (panelCells.Width / columns);

            logs.Text += "Panel height = " + panelCells.Height + "; width = " + panelCells.Width + "\n";
            logs.Text += "Cell height = "+height + "; width = " + width + "\n";

            ///////////////

            

            cells = new Button[buttonNumber];

            int i = 0;

            // POSITIONING
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < columns; col++)
                {
                    cells[i] = new Button();
                    cells[i].Width = width;
                    cells[i].Height = height;
                    panelCells.Controls.Add(cells[i]);
                    cells[i].TabStop = false;
                    cells[i].FlatStyle = FlatStyle.Flat;
                    cells[i].FlatAppearance.BorderSize = 0;
                    cells[i].BackColor = Color.White;
                    cells[i].Name = "cell" + (col+1);

                    if (row == 0)
                    {
                        cells[i].Click += new System.EventHandler(cells_Click);
                        cells[i].BackColor = Color.WhiteSmoke;
                        cells[i].FlatAppearance.BorderSize = 1;
                    }

                    cells[i].Left = (col * width);
                    cells[i].Top = (row * height);

                    i++;
                    progressBar.Value += 1;
                }

            }
            //////////////
            progressBar.Value = 0;

            buttonFF.Enabled = true;
            buttonStep.Enabled = true;
        }

        private void cells_Click(object sender, EventArgs e)
        {
            Button cell = (Button)sender;

            if (cell.BackColor != Color.Green)
                cell.BackColor = Color.Green;
            else cell.BackColor = Color.White;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            panelStop.Enabled = false;
            panelStart.Enabled = true; 
            buttonFF.Enabled = false;
            buttonFF.Text = "Fast Forward";
            buttonStep.Enabled = false;

            logs.Clear();
            panelCells.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonFF.Enabled = false;
            buttonStep.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cr = step - columns;
            board = "";
            previousDeck = new int[columns];

            for (int i = 0; i < columns; i++)
            {
                if (cells[i + cr].BackColor == Color.Green)
                {
                    board += "1";
                }
                else board += "0";
            }

            for (int i = 0; i < previousDeck.Length; i++)
            {
                string number = "";
                if (i == 0)
                {
                    number += board[board.Length - 1];
                    number += board[i];
                    number += board[i + 1];
                }
                else if (i == previousDeck.Length - 1)
                {
                    number += board[board.Length - 2];
                    number += board[i];
                    number += board[0];
                }
                else
                {
                    number += board[i - 1];
                    number += board[i];
                    number += board[i + 1];
                }
                previousDeck[i] = Convert.ToInt32(number);
            }

            for (int i = 0; i < previousDeck.Length; i++) previousDeck[i] = Convert.ToInt32(previousDeck[i].ToString(), 2);

            for (int col = 0; col < columns; col++)
            {
                bool convert = (rule & (1 << previousDeck[col])) != 0;

                if (convert) cells[step].BackColor = Color.Green;

                step++;
            }
            if (step >= buttonNumber)
            {
                buttonFF.Enabled = false;
                buttonStep.Enabled = false;
                timer.Stop();
            }
            if (step >= columns)
                for (int i = 0; i < columns; i++)
                {
                    cells[i].Enabled = false;
                    cells[i].FlatAppearance.BorderSize = 0;
                }
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            int cr = step-columns;
            string binaryRule = Convert.ToString(rule, 2);
            int l = binaryRule.Length;
            if (l < 8)
            {
                binaryRule = "";
                for (int i = 0; i < 8 - l; i++)
                    binaryRule += "0";
                binaryRule += Convert.ToString(rule, 2);
            }

            board = "";
            previousDeck = new int[columns];

            for (int i = 0; i < columns; i++)
            {
                if (cells[i+cr].BackColor == Color.Green)
                {
                    board += "1";
                }
                else board += "0";
            }

            for (int i = 0; i < previousDeck.Length; i++)
            {
                string number = "";
                if (i == 0)
                {
                    number += board[board.Length - 1];
                    number += board[i];
                    number += board[i + 1];
                }
                else if (i == previousDeck.Length - 1)
                {
                    number += board[board.Length - 2];
                    number += board[i];
                    number += board[0];
                }
                else
                {
                    number += board[i - 1];
                    number += board[i];
                    number += board[i + 1];
                }
                previousDeck[i] = Convert.ToInt32(number);
            }

            logs.Text += "Previous board : " + board + "\n";
            logs.Text += "Thirds : ";
            for (int i = 0; i < previousDeck.Length; i++) logs.Text += previousDeck[i] + " ";
            for (int i = 0; i < previousDeck.Length; i++) previousDeck[i] = Convert.ToInt32(previousDeck[i].ToString(), 2);
            logs.Text += "\nDecimal number : ";
            for (int i = 0; i < previousDeck.Length; i++) logs.Text += previousDeck[i] + " ";
            logs.Text += "\nRule: " + binaryRule + "\n";

            

            for (int col = 0; col < columns; col++)
            {
                // cells[] - buttons array
                // board - 00001111 - set bools
                // previousDeck[] - decimal numbers representing cell pattern array
                // binaryRule - 01101110 - next gen
                //        User sets:
                //         00001111  -   -   -   -   -   -   > board[]
                //        Neighbours:
                //   100 0 0 1 11 111 111 110 
                //     4 0 0 1  3  7   7   6   => previousDeck[]
                //       Rule:    __________________      
                //     76543210   4 0 0 1 3 7 7 6   \______
                //     01101110   0 0 0 1 1 0 0 1   /      \
                //         /                             Converting     
                // binaryRule[]
                // 
                //
                bool convert = (rule & (1 << previousDeck[col])) != 0;

                if (convert) cells[step].BackColor = Color.Green;

                step++;
            }

            if (step >= buttonNumber)
            {
                buttonFF.Enabled = false;
                buttonStep.Enabled = false;
            }
            if (step >= columns)
                for (int i = 0; i < columns; i++) { 
                    cells[i].Enabled = false;
                    cells[i].FlatAppearance.BorderSize = 0;
                }
            
        }

        private void buttonFF_Click(object sender, EventArgs e)
        {
            if (buttonFF.Text == "Fast Forward")
            {
                int cr = step - columns;
                buttonFF.Text = "Pause";
                foreach (Button b in cells)
                {
                    b.Enabled = false;
                }
                buttonStep.Enabled = false;
                timer.Start();
            }
            else
            {
                buttonStep.Enabled = true;
                buttonFF.Text = "Fast Forward";
                timer.Stop();
            }
        }
    }
}
