using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int columns = 0;
        int rows = 0;
        float cellHeight;
        float cellWidth;
        Pen penGrid;
        System.Drawing.SolidBrush brushGreen;
        System.Drawing.SolidBrush brushRed;
        System.Drawing.SolidBrush brushBlue;
        System.Drawing.SolidBrush brushBrown;
        System.Drawing.SolidBrush fillBrush;
        bool paintAccess; // Global variable to access/block canvas
        bool toRedraw;    // Global variable for canvas clearance-clearance
        bool userDraw;    // User draws rectangle on mouse click
        bool drawGrid;    // Grid must be redrawn
        bool generateField; // Auto-generation
        bool previewRedraw;
        bool previewDraw;
        int userElement; // 0, 1, 2 ...
        int[,] cells;
        int[,] cellsFire;
        int[,] cellsWood;
        int[,] cellsWater;
        int[,] cellsWilderness;
        int mousex, mousey;
        bool checkBoxDrawGridBool;
        string flowSpeed;

        bool massDrawOnMouseDown;

        Color previousColor;

        int firePercent = 25;
        int waterPercent = 25;
        int forestPercent = 25;
        int wildPercent = 25;
        Random random = new Random();

        // GAMESETTINGS
        

        //
        //  0 - Water, 1 - Wood, 2 - Fire, 3 -wilderness
        //
        //  001 
        //  012 ---> cells[0,0,1,0,1,2,2,1,0]
        //  210                    |
        //                    cellsFire[5] = 2; 
        //                    cellsWood[5] = 2;
        //                    cellsWater[5] = 4;
        //
        //

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // LAYOUT
            canvas.Width = this.Width - 600;
            canvas.Height = this.Height-50;
            //
            panelPlay.Left = this.Width - 300;
            panelPlay.Height = this.Height;
            //
            progressBar.Width = this.Width - 600;
            progressBar.Top = canvas.Height;
            //
            panelEnd.Top = this.Height - 110;
            panelEnd.Left = this.Width - 300;
            //
            logs.Height = this.Height - 300;
            panelLogs.Height = this.Height - 300;
            //
            panelCustomize.Left = 300 + (canvas.Width / 2) - panelCustomize.Width / 2;
            //////////////////////////////////////
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            penGrid = new Pen(Color.DarkGray, 1);
            buttonGridColor.BackColor = penGrid.Color;
            previousColor = penGrid.Color;

            brushGreen = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            brushRed = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            brushBlue = new System.Drawing.SolidBrush(System.Drawing.Color.RoyalBlue);
            brushBrown = new System.Drawing.SolidBrush(System.Drawing.Color.SandyBrown);
            fillBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);

            flowSpeed = "Pause";

            oceanGeneration.Checked = true;

            paintAccess = false;
            toRedraw = false;
            userDraw = false;
            drawGrid = true;
            previewRedraw = true;
            generateField = true;
            previewDraw = true;
            checkBoxDrawGridBool = checkBoxDrawGrid.Checked;
            userElement = 1;
            buttonForest.FlatAppearance.BorderSize = 2;
            buttonForest.FlatAppearance.BorderColor = Color.Gray;
            massDrawOnMouseDown = false;

        }

        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            columns = Convert.ToInt32(editColumns.Value);
            rows = Convert.ToInt32(editRows.Value);

            cellWidth = (float)canvas.Width / (float)columns;
            cellHeight = (float)canvas.Height / (float)rows;

            cells = new int[rows, columns];
            cellsFire = new int[rows, columns];
            cellsWater = new int[rows, columns];
            cellsWood = new int[rows, columns];
            cellsWilderness = new int[rows, columns];

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            cells = new int[rows, columns];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    cells[i, j] = 0;
                }

            //panelSettings.Enabled = false;
            panelPlay.Enabled = true;

            paintAccess = true; // Global variable to access/block canvas
            toRedraw = true;  // Global variable for canvas clearance-clearance
            drawGrid = true;
            generateField = true;
            // WHICH CELLS ARE WHICH

            int dom = 0;

            logs.Clear();

            if (generateField)
            {
                if (randomGeneration.Checked)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            dom = random.Next(4);
                            cells[row, col] = dom;
                            if (cells[row, col] == 2)
                            {
                                dom = random.Next(3);
                                if (dom == 0) cells[row, col] = 0;
                                else if (dom == 1) cells[row, col] = 1;
                                else if (dom == 2) cells[row, col] = 3;
                            }
                            //logs.Text += " " + cells[row, col]; // Debug info
                        }
                    }
                }
                else if (oceanGeneration.Checked)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            cells[row, col] = 0;
                            //logs.Text += " " + cells[row, col]; // Debug info
                        }
                    }
                }
                else if (forestGeneration.Checked)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            cells[row, col] = 1;
                            //logs.Text += " " + cells[row, col]; // Debug info
                        }
                    }
                }
                else if (firefieldGeneration.Checked)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            cells[row, col] = 2;
                            //logs.Text += " " + cells[row, col]; // Debug info
                        }
                    }
                }
                else if (wildGeneration.Checked)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            cells[row, col] = 3;
                        }
                    }
                }
                else
                {
                    int run;

                    for (int row =0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            run = random.Next(maxPercent);
                            if (run < waterPercent)
                                cells[row, col] = 0;
                            else if (run >= waterPercent && run < waterPercent + forestPercent)
                                cells[row, col] = 1;
                            else if (run >= waterPercent + forestPercent && run < waterPercent + forestPercent + firePercent)
                                cells[row, col] = 2;
                            else if (run >= waterPercent + forestPercent + firePercent)
                                cells[row, col] = 3;
                        }
                    }
                    

                }
            }
            canvas.Enabled = true;

            logs.Text += "CellWidth: " + cellWidth + " of (" + canvas.Width + ")\n";
            logs.Text += "CellHeight: " + cellHeight + " of (" + canvas.Height + ")\n";
            logs.Text += "Right gap: " + (canvas.Width - columns * cellWidth) + "\n";
            logs.Text += "Bottom gap: " + (canvas.Height - rows * cellHeight) + "\n";
            logs.Text += "Screen enabled\n";

            panelSettings.Enabled = false;
            buttonEnd.Enabled = true;
            panelPlay.Enabled = true;
            buttonStart.BackColor = Color.LightGreen;
            buttonSettings.BackColor = Color.LightGoldenrodYellow;
            buttonEnd.BackColor = Color.LightCoral;
            buttonEnd.Text = "End";

            buttonForest.BackColor = Color.Green;
            buttonWater.BackColor = Color.RoyalBlue;
            buttonFire.BackColor = Color.Red;
            buttonWild.BackColor = Color.SandyBrown;

            // Game Flow
            buttonTick.FlatAppearance.BorderSize = 1;
            buttonFlowNormal.FlatAppearance.BorderSize = 1;
            buttonFlowFast.FlatAppearance.BorderSize = 1;
            buttonFlowFastest.FlatAppearance.BorderSize = 1;
            buttonFlowPause.FlatAppearance.BorderSize = 1;

            
            
            flowSpeed = "Pause";
            logs.Text += "Time flow: " + flowSpeed + "\n\n";
            buttonFlowPause.BackColor = Color.Gray; 
            buttonFlowNormal.BackColor = Color.LightGray;
            buttonFlowFast.BackColor = Color.LightGray;
            buttonFlowFastest.BackColor = Color.LightGray;
            buttonTick.BackColor = Color.CadetBlue;
            buttonTick.Enabled = true;

            buttonForest.FlatAppearance.BorderColor = Color.Black;
            buttonFire.FlatAppearance.BorderColor = Color.Black;
            buttonWater.FlatAppearance.BorderColor = Color.Black;
            buttonWild.FlatAppearance.BorderColor= Color.Black;

        }


        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (paintAccess)
            {
                ////////////////////////////////////////////////
                //columns = Convert.ToInt32(editColumns.Value);
                //rows = Convert.ToInt32(editRows.Value);

                cellWidth = (float)canvas.Width / (float)columns;
                cellHeight = (float)canvas.Height / (float)rows;
                ////////////////////////////////////////////////

                if (canvas.Image == null) canvas.Image = new Bitmap(canvas.Width, canvas.Height);
                if (toRedraw)
                {
                    canvas.Image.Dispose();
                    canvas.Image = null;
                    canvas.Image = new Bitmap(canvas.Width, canvas.Height);
                    toRedraw = false;
                }
                Graphics screen = Graphics.FromImage(canvas.Image);


                // GRID RENDER
                if (drawGrid && checkBoxDrawGridBool) // checkBoxDrawGrid.Checked may cause bugs (not confirmed)
                {
                    for (int row = 1; row < rows + 1; row++)
                    {
                        screen.DrawLine(penGrid, 0, row * cellHeight, columns * cellWidth, row * cellHeight);
                        //screen.DrawLine(penGrid, 0, row * cellHeight, canvas.Width, row * cellHeight);

                        for (int col = 1; col < columns + 1; col++)
                        {
                            screen.DrawLine(penGrid, col * cellWidth, 0, col * cellWidth, rows * cellHeight);
                            //screen.DrawLine(penGrid, col * cellWidth, 0, col * cellWidth, canvas.Height);
                        }
                    }
                    drawGrid = false;
                    canvas.Invalidate();
                }
                /////////////////////
                // Board Generation depending on cells[row,col] array
                if (generateField)
                {

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            // DRAW CELLS GENERATED ON BUTTON START
                            switch (cells[row, col]) {
                                case 0: 
                                    screen.FillRectangle(brushBlue, col * cellWidth, row * cellHeight, cellWidth, cellHeight);
                                    break;
                                case 1: screen.FillRectangle(brushGreen, col * cellWidth, row * cellHeight, cellWidth, cellHeight);
                                    break;
                                case 2: screen.FillRectangle(brushRed, col * cellWidth, row * cellHeight, cellWidth, cellHeight);
                                    break;
                                case 3: screen.FillRectangle(brushBrown, col * cellWidth, row * cellHeight, cellWidth, cellHeight);
                                    break;
                                default: break;
                            }
                        }
                    }

                    canvas.Invalidate();

                    drawGrid = true;

                    generateField = false;
                }
                ///////////////////////////////////////////

                // User massDrawOnMouse
                

                // User Mouse Draw Call
                if (userDraw)
                {
                    float r = 0;
                    float c = 0;
                    int counter = 0;

                    do{
                        c += (float)cellWidth;
                        counter++;
                    }
                    while (c <= mousex);
                    // C = column; [1 to columns]
                    c = counter;

                    counter = 0;

                    do
                    {
                        r += (float)cellHeight;
                        counter++;
                    }
                    while (r <= mousey);
                    // R = row; [1 to rows]
                    r = counter;

                    //Change array value data
                    bool match = false;
                    if (cells[(int)(r - 1), (int)(c - 1)] == userElement) match = true;
                    else cells[(int)(r - 1), (int)(c - 1)] = userElement;

                    //logs.Text += "Fire: " + cellsFire[(int)(r - 1), (int)(c - 1)] + "\n";
                    //logs.Text += "Water: " + cellsWater[(int)(r - 1), (int)(c - 1)] + "\n";
                    //logs.Text += "Wood: " + cellsWood[(int)(r - 1), (int)(c - 1)] + "\n";

                    // Draw rectangle
                    if (!match)
                    {

                        switch (userElement)
                        {
                            case 0: fillBrush = brushBlue; break;
                            case 1: fillBrush = brushGreen; break;
                            case 2: fillBrush = brushRed; break;
                            case 3: fillBrush = brushBrown; break;

                            default: break;
                        }


                        screen.FillRectangle(fillBrush, cellWidth * (c - 1), cellHeight * (r - 1), cellWidth, cellHeight);


                        //logs.Text += "Cells[r,c] = [" + (r - 1) + ", " + (c - 1) + "]    ";
                        //logs.Text += "Row/Col: " + r + ", " + c + "\n";
                        //logs.Text += "Rectangle drawn(" + (cellWidth * (c - 1)) + "," + (cellHeight * (r - 1)) + ";" + ((cellWidth * (c - 1)) + cellWidth) + "," + ((cellHeight * (r - 1)) + cellHeight) + ")\n";
                    }

                    if (!massDrawOnMouseDown)
                    {
                        drawGrid = true;
                        canvas.Invalidate();
                    }

                    userDraw = false;

                    //logs.Text += "\n";
                }
                ///////////////////////////
                if (progressBar.Value == progressBar.Maximum) progressBar.Value = 0;
            }

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelCustomize.Left = 300 + (canvas.Width / 2) - panelCustomize.Width / 2;
            panelSettings.Enabled = false;
            panelCustomize.Visible = true;
            buttonEnd.Enabled = false;
            previewDraw = true;
            buttonStart.BackColor = Color.LightGreen;
            buttonSettings.BackColor = Color.LightGoldenrodYellow;
            if (buttonEnd.BackColor == Color.YellowGreen)
                buttonEnd.BackColor = Color.LightGreen;
        }


        int maxPercent = 100;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            maxPercent = (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value);

            if (maxPercent == 0) maxPercent = 100;

            labelFirePercent.Text = ((trackBar1.Value * 100) / maxPercent).ToString() + "%";
            labelWaterPercent.Text = ((trackBar2.Value * 100) / maxPercent).ToString() + "%";
            labelForestPercent.Text = ((trackBar3.Value * 100) / maxPercent).ToString() + "%";
            labelWildPercent.Text = ((trackBar4.Value * 100) / maxPercent).ToString() + "%";

            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            maxPercent = (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value);

            if (maxPercent == 0) maxPercent = 100;

            labelFirePercent.Text = ((trackBar1.Value * 100) / maxPercent).ToString() + "%";
            labelWaterPercent.Text = ((trackBar2.Value * 100) / maxPercent).ToString() + "%";
            labelForestPercent.Text = ((trackBar3.Value * 100) / maxPercent).ToString() + "%";
            labelWildPercent.Text = ((trackBar4.Value * 100) / maxPercent).ToString() + "%";

            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            maxPercent = (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value);

            if (maxPercent == 0) maxPercent = 100;

            labelFirePercent.Text = ((trackBar1.Value * 100) / maxPercent).ToString() + "%";
            labelWaterPercent.Text = ((trackBar2.Value * 100) / maxPercent).ToString() + "%";
            labelForestPercent.Text = ((trackBar3.Value * 100) / maxPercent).ToString() + "%";
            labelWildPercent.Text = ((trackBar4.Value * 100) / maxPercent).ToString() + "%";

            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            maxPercent = (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value);

            if (maxPercent == 0) maxPercent = 100;

            labelFirePercent.Text = ((trackBar1.Value * 100) / maxPercent).ToString() + "%";
            labelWaterPercent.Text = ((trackBar2.Value * 100) / maxPercent).ToString() + "%";
            labelForestPercent.Text = ((trackBar3.Value * 100) / maxPercent).ToString() + "%";
            labelWildPercent.Text = ((trackBar4.Value * 100) / maxPercent).ToString() + "%";

            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;
        }
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent)
            {
                do
                {
                    if (trackBar2.Value != 100)
                        trackBar2.Value += 1;
                    else
                        if (trackBar3.Value != 100)
                        trackBar3.Value += 1;
                    else if (trackBar1.Value != 100)
                        trackBar1.Value += 1;
                    else if (trackBar4.Value != 100)
                        trackBar4.Value += 1;
                }
                while (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent);
            }
            labelFirePercent.Text = ((float)((trackBar1.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWaterPercent.Text = ((float)((trackBar2.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelForestPercent.Text = ((float)((trackBar3.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWildPercent.Text = ((float)((trackBar4.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;

            previewDraw = true;
            canvasPreview.Invalidate();

            //this.Text = maxPercent + ": " + trackBar1.Value + " " + trackBar2.Value + " " + trackBar3.Value;
        }

        private void trackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent)
            {
                do
                {
                    if (trackBar1.Value != 100)
                        trackBar1.Value += 1;
                    else
                        if (trackBar3.Value != 100)
                        trackBar3.Value += 1;
                    else if (trackBar2.Value != 100)
                        trackBar2.Value += 1;
                    else if (trackBar4.Value != 100)
                        trackBar4.Value += 1;
                }
                while (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent);
            }
            labelFirePercent.Text = ((float)((trackBar1.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWaterPercent.Text = ((float)((trackBar2.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelForestPercent.Text = ((float)((trackBar3.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWildPercent.Text = ((float)((trackBar4.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;

            previewDraw = true;
            canvasPreview.Invalidate();
        }

        private void trackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent)
            {
                do
                {
                    if (trackBar1.Value != 100)
                        trackBar1.Value += 1;
                    else
                        if (trackBar2.Value != 100)
                        trackBar2.Value += 1;
                    else if (trackBar3.Value != 100)
                        trackBar3.Value += 1;
                    else if (trackBar4.Value != 100)
                        trackBar4.Value += 1;
                }
                while (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent);
            }
            labelFirePercent.Text = ((float)((trackBar1.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWaterPercent.Text = ((float)((trackBar2.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelForestPercent.Text = ((float)((trackBar3.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWildPercent.Text = ((float)((trackBar4.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;

            previewDraw = true;
            canvasPreview.Invalidate();

        }

        private void trackBar4_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent)
            {
                do
                {
                    if (trackBar1.Value != 100)
                        trackBar1.Value += 1;
                    else
                        if (trackBar3.Value != 100)
                        trackBar3.Value += 1;
                    else if (trackBar2.Value != 100)
                        trackBar2.Value += 1;
                    else if (trackBar4.Value != 100)
                        trackBar4.Value += 1;
                }
                while (trackBar1.Value + trackBar2.Value + trackBar3.Value + trackBar4.Value != maxPercent);
            }
            labelFirePercent.Text = ((float)((trackBar1.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWaterPercent.Text = ((float)((trackBar2.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelForestPercent.Text = ((float)((trackBar3.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            labelWildPercent.Text = ((float)((trackBar4.Value * 100)) / (float)maxPercent).ToString("0.00") + "%";
            firePercent = trackBar1.Value;
            waterPercent = trackBar2.Value;
            forestPercent = trackBar3.Value;
            wildPercent = trackBar4.Value;

            previewDraw = true;
            canvasPreview.Invalidate();
        }

        private void canvasPreview_Paint(object sender, PaintEventArgs e)
        {

            float pW = (float)canvasPreview.Width/ (float)editColumns.Value;
            float pH = (float)canvasPreview.Height/ (float)editRows.Value;

            if (canvasPreview.Image == null) canvasPreview.Image = new Bitmap(canvasPreview.Width, canvasPreview.Height);
            if (previewRedraw)
            {
                canvasPreview.Image.Dispose();
                canvasPreview.Image = null;
                canvasPreview.Image = new Bitmap(canvasPreview.Width, canvasPreview.Height);
                previewRedraw = false;
            }
            Graphics preview = Graphics.FromImage(canvasPreview.Image);

            if (previewDraw)
            {
                for (int row = 0; row < editRows.Value; row++)
                {
                    for (int col = 0; col < editColumns.Value; col++)
                    {
                        // DRAW CELLS GENERATED ON BUTTON START 10   2 3 5  0 1 2 3 4 5 6 7 8 9
                        int randi = random.Next(maxPercent);
                        if (randi < waterPercent)
                            preview.FillRectangle(brushBlue, col * pW, row * pH, pW, pH);
                        else if (randi >= waterPercent && randi < waterPercent + forestPercent)
                            preview.FillRectangle(brushGreen, col * pW, row * pH, pW, pH);
                        else if (randi >= waterPercent + forestPercent && randi < waterPercent+forestPercent+firePercent)
                            preview.FillRectangle(brushRed, col * pW, row * pH, pW, pH);
                        else if (randi >= waterPercent + forestPercent + firePercent)
                            preview.FillRectangle(brushBrown, col * pW, row * pH, pW, pH);

                    }
                }
                previewDraw = false;
                canvasPreview.Invalidate();
            }
            timerPreview.Start();
        }

        private void timerPreview_Tick(object sender, EventArgs e)
        {
            previewDraw = true;
            canvasPreview.Invalidate();

        }

        private void editColumns_ValueChanged(object sender, EventArgs e)
        {

            previewRedraw = true;
        }

        private void editRows_ValueChanged(object sender, EventArgs e)
        {
            previewRedraw = true;
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelCustomize.Visible = false;
            panelSettings.Enabled = true;
            timerPreview.Stop();
            penGrid.Color = previousColor;
            buttonGridColor.BackColor = previousColor;

            buttonSettings.BackColor = Color.Gold;
            buttonStart.BackColor = Color.YellowGreen;

            if (buttonEnd.Text == "Resume")
            {
                buttonEnd.Enabled = true;
            }
            if (buttonEnd.BackColor == Color.LightGreen)
            {
                buttonEnd.BackColor = Color.YellowGreen;
            }

        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            timerPreview.Stop();
        }

        private void trackBar2_MouseDown(object sender, MouseEventArgs e)
        {
            timerPreview.Stop();
        }

        private void trackBar3_MouseDown(object sender, MouseEventArgs e)
        {
            timerPreview.Stop();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            if (buttonEnd.Text == "End")
            {
                timer.Stop();

                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximizeBox = true;
                this.MinimizeBox = true;
                panelPlay.Enabled = false;
                panelSettings.Enabled = true;
                buttonStart.BackColor = Color.YellowGreen;
                buttonSettings.BackColor = Color.Gold;
                canvas.Enabled = false;
                buttonEnd.Text = "Resume";
                buttonEnd.BackColor = Color.YellowGreen;

                buttonForest.BackColor = Color.LightGray;
                buttonWater.BackColor = Color.LightGray;
                buttonFire.BackColor = Color.LightGray;
                buttonWild.BackColor = Color.LightGray;

                buttonTick.FlatAppearance.BorderSize = 0;
                buttonFlowNormal.FlatAppearance.BorderSize = 0;
                buttonFlowFast.FlatAppearance.BorderSize = 0;
                buttonFlowFastest.FlatAppearance.BorderSize = 0;
                buttonFlowPause.FlatAppearance.BorderSize = 0;
                buttonTick.BackColor = Color.LightGray;

                buttonForest.FlatAppearance.BorderColor = Color.Gray;
                buttonFire.FlatAppearance.BorderColor = Color.Gray;
                buttonWater.FlatAppearance.BorderColor = Color.Gray;
                buttonWild.FlatAppearance.BorderColor = Color.Gray;

                logs.Text += "Screen disabled\n";
            }
            else if (buttonEnd.Text == "Resume")
            {
                toRedraw = true;
                generateField = true;
                //canvas.Invalidate();
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                canvas.Enabled = true;
                panelSettings.Enabled=false;
                buttonEnd.Text = "End";
                buttonEnd.BackColor = Color.LightCoral;
                panelPlay.Enabled = true;

                buttonForest.BackColor = Color.Green;
                buttonWater.BackColor = Color.RoyalBlue;
                buttonFire.BackColor = Color.Red;
                buttonWild.BackColor = Color.SandyBrown;

                buttonTick.FlatAppearance.BorderSize = 1;
                buttonFlowNormal.FlatAppearance.BorderSize = 1;
                buttonFlowFast.FlatAppearance.BorderSize = 1;
                buttonFlowFastest.FlatAppearance.BorderSize = 1;
                buttonFlowPause.FlatAppearance.BorderSize = 1;
                buttonTick.BackColor = Color.CadetBlue;

                buttonForest.FlatAppearance.BorderColor = Color.Black;
                buttonFire.FlatAppearance.BorderColor = Color.Black;
                buttonWater.FlatAppearance.BorderColor = Color.Black;
                buttonWild.FlatAppearance.BorderColor = Color.Black;

                logs.Text += "Screen enabled\n";

                if (flowSpeed != "Pause") timer.Start();
            }

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            randomGeneration.Checked = false;
            forestGeneration.Checked = false;
            oceanGeneration.Checked = false;
            firefieldGeneration.Checked = false;

            if (checkBoxDrawGrid.Checked) checkBoxDrawGridBool = true;
            else checkBoxDrawGridBool = false;

            panelCustomize.Visible = false;
            panelSettings.Enabled = true;

            previousColor = penGrid.Color;
            buttonStart.BackColor = Color.YellowGreen;
            buttonSettings.BackColor = Color.Gold;

            if (buttonEnd.Text == "Resume") buttonEnd.Enabled = true;
            if (buttonEnd.BackColor == Color.LightGreen) buttonEnd.BackColor = Color.YellowGreen;

            logs.Text = "Generation: Forest(" + labelForestPercent.Text + "), Water(" + labelWaterPercent.Text + "), Fire(" + labelFirePercent.Text + "), Wild(" + labelWildPercent.Text + ")\n";
            logs.Text += "Draw grid: Yes (";
            logs.AppendText(penGrid.Color.Name);
            logs.Text +=")\n";
        }

        private void buttonGridColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonGridColor.BackColor = colorDialog.Color;
                penGrid.Color = colorDialog.Color;
            }
        }

        private void buttonForest_Click(object sender, EventArgs e)
        {
            userElement = 1;
            buttonForest.FlatAppearance.BorderSize = 1;
            buttonWater.FlatAppearance.BorderSize = 0;
            buttonFire.FlatAppearance.BorderSize = 0;
        }

        private void buttonWater_Click(object sender, EventArgs e)
        {
            userElement = 0;
            buttonWater.FlatAppearance.BorderSize = 1;
            buttonForest.FlatAppearance.BorderSize = 0;
            buttonFire.FlatAppearance.BorderSize = 0;
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            userElement = 2;
            buttonFire.FlatAppearance.BorderSize = 1;
            buttonForest.FlatAppearance.BorderSize = 0;
            buttonWater.FlatAppearance.BorderSize = 0;
        }
        private void buttonWild_Click(object sender, EventArgs e)
        {
            userElement = 3;
            buttonWild.FlatAppearance.BorderSize = 1;
            buttonFire.FlatAppearance.BorderSize = 0;
            buttonForest.FlatAppearance.BorderSize = 0;
            buttonWater.FlatAppearance.BorderSize = 0;
        }

        private void buttonFlowPause_Click(object sender, EventArgs e)
        {
            if (flowSpeed != "Pause")
            {
                timer.Stop();

                buttonFlowNormal.BackColor = Color.LightGray;
                buttonFlowFast.BackColor = Color.LightGray;
                buttonFlowFastest.BackColor = Color.LightGray;
                buttonFlowPause.BackColor = Color.Gray;
                flowSpeed = "Pause";
                logs.Text += "Paused\n";
                buttonTick.Enabled = true;
                buttonTick.BackColor = Color.CadetBlue;
            }

        }

        private void buttonFlowFastest_Click(object sender, EventArgs e)
        {
            if (flowSpeed != "Fastest") {
                buttonFlowNormal.BackColor = Color.LightGray;
                buttonFlowFast.BackColor = Color.LightGray;
                buttonFlowPause.BackColor = Color.LightGray;
                buttonFlowFastest.BackColor = Color.Gray;
                flowSpeed = "Fastest";
                logs.Text += "Time speed set to " + flowSpeed + "\n";
                buttonTick.Enabled = false;
                buttonTick.BackColor = Color.LightGray;
                timer.Interval = 200;
                timer.Start();
            }
        }

        private void buttonFlowFast_Click(object sender, EventArgs e)
        {
            if (flowSpeed != "Fast")
            {
                buttonFlowNormal.BackColor = Color.LightGray;
                buttonFlowPause.BackColor = Color.LightGray;
                buttonFlowFastest.BackColor = Color.LightGray;
                buttonFlowFast.BackColor = Color.Gray;
                flowSpeed = "Fast";
                logs.Text += "Time speed set to " + flowSpeed + "\n";
                buttonTick.Enabled = false;
                buttonTick.BackColor = Color.LightGray;
                timer.Interval = 500; 
                timer.Start();
            }
        }

        private void buttonFlowNormal_Click(object sender, EventArgs e)
        {
            if (flowSpeed != "Normal")
            {
                buttonFlowPause.BackColor = Color.LightGray;
                buttonFlowFastest.BackColor = Color.LightGray;
                buttonFlowFast.BackColor = Color.LightGray;
                buttonFlowNormal.BackColor = Color.Gray;
                flowSpeed = "Normal";
                logs.Text += "Time speed set to " + flowSpeed + "\n";
                buttonTick.Enabled = false;
                buttonTick.BackColor = Color.LightGray;
                timer.Interval = 1000;

                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GameTick();
        }

        private void buttonTick_Click(object sender, EventArgs e)
        {
            GameTick();
        }

        public void GameTick()
        {
            // GAMESTEP event
            // cells: 0 - water, 1 - forest, 2 - fire;

            // Clear neighbours
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    cellsFire[i, j] = 0;
                    cellsWater[i, j] = 0;
                    cellsWood[i, j] = 0;
                    cellsWilderness[i, j] = 0;
                }

            // Get neighbours
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++) // Clockwise
                {
                    if (row == 0 && col == 0) // Left-upper corner
                    {

                        if (cells[row, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row == 0 && col != 0 && col != columns - 1) // Upper border
                    {
                        if (cells[row, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col - 1] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row == 0 && col == columns - 1) // Right-upper corner
                    {
                        if (cells[row + 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col - 1] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row != 0 && row != rows - 1 && col == columns - 1) // Right border
                    {
                        if (cells[row + 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row == rows - 1 && col == columns - 1) // Right-lower corner
                    {
                        if (cells[row, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row == rows - 1 && col != columns - 1 && col != 0) // Lower-border
                    {
                        if (cells[row, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col + 1] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row == rows - 1 && col == 0) // Left-lower corner
                    {
                        if (cells[row - 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col + 1] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row != rows - 1 && row != 0 && col == 0) // Left border
                    {
                        if (cells[row - 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col] == 3) cellsWilderness[row, col]++;
                        //
                    }
                    else if (row != 0 && col != 0 && row != rows - 1 && col != columns - 1)
                    {
                        if (cells[row - 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col + 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col + 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col + 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col + 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col] == 3) cellsWilderness[row, col]++;

                        if (cells[row + 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row + 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row + 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row + 1, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row, col - 1] == 3) cellsWilderness[row, col]++;

                        if (cells[row - 1, col - 1] == 0) cellsWater[row, col]++;
                        else if (cells[row - 1, col - 1] == 1) cellsWood[row, col]++;
                        else if (cells[row - 1, col - 1] == 2) cellsFire[row, col]++;
                        else if (cells[row - 1, col - 1] == 3) cellsWilderness[row, col]++;
                        //
                    }
                }
            }

            // Apply game rules

            int rng = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (cells[row, col] == 0) // Water
                    {
                        rng = random.Next(101) + 1;

                        if (cellsWood[row, col] >= 3)
                        {
                            if (rng <= cellsWood[row, col] + gameTreesDrainWater.Value - cellsWater[row, col])
                                cells[row, col] = 3;
                        }
                    }
                    else if (cells[row, col] == 1) // Woods
                    {
                        rng = random.Next(101) + 1; // 1 - 100

                        if (rng <= cellsFire[row, col] * 15) // [0.. 8] 
                            cells[row, col] = 2;                     // Firecatch (more priority)
                        else
                        {
                            rng = random.Next(101) + 1;
                            if (rng <= cellsWood[row, col] * 20 - 100 - gameForestSurvivability.Value) //
                                cells[row, col] = 3;                 // Exhaustion (20,40,60)%
                            else
                            {
                                rng = random.Next(101) + 1;
                                if (rng <= cellsWater[row, col] * 15 - 100)
                                {
                                    cells[row, col] = 0;             // Drown (5%, 20%) 7,8
                                    //logs.Text += "Drown event (" + row + ", " + col + ")\n";
                                }
                            }
                        }

                    }
                    else if (cells[row, col] == 2) // Fire
                    {
                        rng = random.Next(101) + 1;

                        if (rng <= gameFireFades.Value + cellsFire[row, col] * 4 + cellsWater[row, col] * 3 - cellsWood[row, col])
                            cells[row, col] = 3;                     // Fade
                    }
                    else if (cells[row, col] == 3) // Wilderness
                    {
                        rng = random.Next(101) + 1;

                        if (rng <= cellsWood[row, col])
                            cells[row, col] = 1;                     // Sprout  (priority: Sprout > Flood > Birth)
                        else
                        {
                            rng = random.Next(101) + 1;

                            if (cellsWater[row, col] != 0)
                            {
                                if (rng <= gameFloodChance.Value + cellsWater[row, col] - 1)
                                    cells[row, col] = 0;             // Flood
                                else if (rng <= cellsWater[row, col] * 3 + gameWaterLife.Value)
                                    cells[row, col] = 1;             // Birth
                            }
                        }

                    }
                }
            }

            generateField = true;
            canvas.Invalidate();

            // NEXT STEP
            // RULES OF MY GAME:
            // 
            //  If water has n forest neighbours it dries out with n% chance ("drought" scenario)
            //  If forest has n fire nearby - it starts burning with (n*10)% chance ("firecatch" scenario)
            //  
            //  V2.0 Wilderness ADDED
            //
            //  if wilderness has n forest near it - it has n% chance to turn into forest ("sprout" scenario)
            //  if wilderness has n water near it - it has n*5% chance to turn int0 forest ("birth" scenario)
            //  if forest has 8 forest near it - it dies from the lack of minerals ("exhaustion" scenario)

            //  Fire has (fireN*5 + waterN*4 - woodN)% chance to go out ("fade" scenario)
            //  If wilderness has water neighbour and little trees it can turn into water ("flood" scenario)
            //  Forest can drown if too much water around ("flood scenario")

            //  Number of rules"
            //  Forest: 3 (exhaustion, firecatch, drown)    // DONE
            //  Water: 1  (drought)                         // DONE
            //  Fire: 1   (fade)                            // DONE
            //  Wilderness: 2 (sprout-birth, flood)         // DONE

            //  V3.0 Black soil - in progress...
            //  Water flows into valleys?
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (massDrawOnMouseDown && e.X < canvas.Width && e.Y < canvas.Height)
            {
                mousex = e.X;
                mousey = e.Y;
                userDraw = true;
                drawGrid = false;       // Иначе крендец производительности
                generateField = false; // Рисуем только поверх, иначе читать выше
                toRedraw = false;
                canvas.Invalidate();
            }
            else
            {
                drawGrid = true;
                canvas.Invalidate();
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            massDrawOnMouseDown = true;
            
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            massDrawOnMouseDown = false;
            
        }

        private void canvas_MouseLeave(object sender, EventArgs e)
        {
        }

       

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            mousex = e.X;
            mousey = e.Y;
            /*
            string cellElement = "";
            switch (userElement)
            {
                case 0: cellElement = "Water"; break;
                case 1: cellElement = "Forest"; break;
                case 2: cellElement = "Fire"; break;
                default: cellElement = "???"; break;
            }
            */
            userDraw = true;
            //logs.Text += "Cords(x,y): " + mousex + ", " + mousey + "   ";

            //logs.Text += "User makes a draw call (" + cellElement +")\n";
            canvas.Invalidate();

        }
    }
}
