namespace AutomaticParkingSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Start = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.inputBank = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLC = new System.Windows.Forms.Label();
            this.trackBarLC = new System.Windows.Forms.TrackBar();
            this.inputFeeSize = new System.Windows.Forms.NumericUpDown();
            this.inputAvgPrice = new System.Windows.Forms.NumericUpDown();
            this.labelVP = new System.Windows.Forms.Label();
            this.trackBarVP = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelParkingPlaces = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Init = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.labelPrice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
=======
            this.labelExpenses = new System.Windows.Forms.Label();
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.panelParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputFeeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAvgPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVP)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(3, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 50);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Step
            // 
            this.Step.BackColor = System.Drawing.Color.Khaki;
            this.Step.FlatAppearance.BorderSize = 0;
            this.Step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step.Location = new System.Drawing.Point(109, 3);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(100, 50);
            this.Step.TabIndex = 2;
            this.Step.Text = "Step";
            this.Step.UseVisualStyleBackColor = false;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // panelParameters
            // 
            this.panelParameters.Controls.Add(this.inputBank);
            this.panelParameters.Controls.Add(this.label5);
            this.panelParameters.Controls.Add(this.labelLC);
            this.panelParameters.Controls.Add(this.trackBarLC);
            this.panelParameters.Controls.Add(this.inputFeeSize);
            this.panelParameters.Controls.Add(this.inputAvgPrice);
            this.panelParameters.Controls.Add(this.labelVP);
            this.panelParameters.Controls.Add(this.trackBarVP);
            this.panelParameters.Controls.Add(this.label4);
            this.panelParameters.Controls.Add(this.label3);
            this.panelParameters.Controls.Add(this.label2);
            this.panelParameters.Controls.Add(this.label1);
            this.panelParameters.Location = new System.Drawing.Point(12, 67);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(212, 409);
            this.panelParameters.TabIndex = 3;
            // 
            // inputBank
            // 
            this.inputBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBank.Location = new System.Drawing.Point(3, 367);
            this.inputBank.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.inputBank.Name = "inputBank";
            this.inputBank.Size = new System.Drawing.Size(206, 26);
            this.inputBank.TabIndex = 16;
            this.inputBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBank.Value = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(78, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bank";
            // 
            // labelLC
            // 
            this.labelLC.AutoSize = true;
            this.labelLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLC.Location = new System.Drawing.Point(93, 133);
            this.labelLC.Name = "labelLC";
            this.labelLC.Size = new System.Drawing.Size(32, 20);
            this.labelLC.TabIndex = 14;
            this.labelLC.Text = "2%";
            this.labelLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarLC
            // 
            this.trackBarLC.Location = new System.Drawing.Point(6, 102);
            this.trackBarLC.Maximum = 100;
            this.trackBarLC.Name = "trackBarLC";
            this.trackBarLC.Size = new System.Drawing.Size(206, 45);
            this.trackBarLC.TabIndex = 13;
            this.trackBarLC.Value = 2;
            this.trackBarLC.Scroll += new System.EventHandler(this.trackBarLC_Scroll);
            // 
            // inputFeeSize
            // 
            this.inputFeeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFeeSize.Location = new System.Drawing.Point(3, 195);
            this.inputFeeSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputFeeSize.Name = "inputFeeSize";
            this.inputFeeSize.Size = new System.Drawing.Size(206, 26);
            this.inputFeeSize.TabIndex = 12;
            this.inputFeeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputFeeSize.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // inputAvgPrice
            // 
            this.inputAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAvgPrice.Location = new System.Drawing.Point(3, 30);
            this.inputAvgPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputAvgPrice.Name = "inputAvgPrice";
            this.inputAvgPrice.Size = new System.Drawing.Size(206, 26);
            this.inputAvgPrice.TabIndex = 10;
            this.inputAvgPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputAvgPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelVP
            // 
            this.labelVP.AutoSize = true;
            this.labelVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVP.Location = new System.Drawing.Point(94, 302);
            this.labelVP.Name = "labelVP";
            this.labelVP.Size = new System.Drawing.Size(32, 20);
            this.labelVP.TabIndex = 9;
            this.labelVP.Text = "3%";
            this.labelVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarVP
            // 
            this.trackBarVP.Location = new System.Drawing.Point(3, 271);
            this.trackBarVP.Maximum = 100;
            this.trackBarVP.Name = "trackBarVP";
            this.trackBarVP.Size = new System.Drawing.Size(206, 45);
            this.trackBarVP.TabIndex = 8;
            this.trackBarVP.Value = 3;
            this.trackBarVP.Scroll += new System.EventHandler(this.trackBarVP_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Violation percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fee size per hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Worker leave chance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average price in city";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.Start);
            this.panelControl.Controls.Add(this.Step);
            this.panelControl.Location = new System.Drawing.Point(12, 8);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(212, 58);
            this.panelControl.TabIndex = 4;
            this.panelControl.Visible = false;
            // 
            // panelInfo
            // 
<<<<<<< HEAD
            this.panelInfo.Controls.Add(this.labelPrice);
=======
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.panelInfo.Controls.Add(this.labelExpenses);
            this.panelInfo.Controls.Add(this.labelClients);
            this.panelInfo.Controls.Add(this.labelIncome);
            this.panelInfo.Controls.Add(this.labelVFee);
            this.panelInfo.Controls.Add(this.labelViolations);
            this.panelInfo.Controls.Add(this.labelIntersect);
            this.panelInfo.Controls.Add(this.labelWorkers);
            this.panelInfo.Controls.Add(this.labelMoney);
            this.panelInfo.Controls.Add(this.labelSalary);
            this.panelInfo.Controls.Add(this.labelParkingPlaces);
            this.panelInfo.Controls.Add(this.EndButton);
            this.panelInfo.Location = new System.Drawing.Point(227, 8);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(701, 58);
            this.panelInfo.TabIndex = 4;
            this.panelInfo.Visible = false;
            // 
<<<<<<< HEAD
            // labelExpenses
            // 
            this.labelExpenses.AutoSize = true;
            this.labelExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpenses.Location = new System.Drawing.Point(195, 39);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(77, 18);
            this.labelExpenses.TabIndex = 24;
            this.labelExpenses.Text = "Expenses:";
            // 
=======
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClients.Location = new System.Drawing.Point(533, 3);
            this.labelClients.Name = "labelClients";
<<<<<<< HEAD
            this.labelClients.Size = new System.Drawing.Size(61, 18);
=======
            this.labelClients.Size = new System.Drawing.Size(50, 15);
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.labelClients.TabIndex = 23;
            this.labelClients.Text = "Clients: ";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIncome.Location = new System.Drawing.Point(388, 21);
            this.labelIncome.Name = "labelIncome";
<<<<<<< HEAD
            this.labelIncome.Size = new System.Drawing.Size(65, 18);
=======
            this.labelIncome.Size = new System.Drawing.Size(54, 15);
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.labelIncome.TabIndex = 22;
            this.labelIncome.Text = "Income: ";
            // 
            // labelVFee
            // 
            this.labelVFee.AutoSize = true;
            this.labelVFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVFee.Location = new System.Drawing.Point(388, 39);
            this.labelVFee.Name = "labelVFee";
<<<<<<< HEAD
            this.labelVFee.Size = new System.Drawing.Size(103, 18);
=======
            this.labelVFee.Size = new System.Drawing.Size(84, 15);
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.labelVFee.TabIndex = 21;
            this.labelVFee.Text = "Violators Fee: ";
            // 
            // labelViolations
            // 
            this.labelViolations.AutoSize = true;
            this.labelViolations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViolations.Location = new System.Drawing.Point(533, 39);
            this.labelViolations.Name = "labelViolations";
<<<<<<< HEAD
            this.labelViolations.Size = new System.Drawing.Size(74, 18);
=======
            this.labelViolations.Size = new System.Drawing.Size(60, 15);
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.labelViolations.TabIndex = 20;
            this.labelViolations.Text = "Violators: ";
            // 
            // labelIntersect
            // 
            this.labelIntersect.AutoSize = true;
            this.labelIntersect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntersect.Location = new System.Drawing.Point(533, 21);
            this.labelIntersect.Name = "labelIntersect";
<<<<<<< HEAD
            this.labelIntersect.Size = new System.Drawing.Size(72, 18);
=======
            this.labelIntersect.Size = new System.Drawing.Size(59, 15);
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.labelIntersect.TabIndex = 19;
            this.labelIntersect.Text = "Intersect: ";
            // 
            // labelWorkers
            // 
            this.labelWorkers.AutoSize = true;
            this.labelWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkers.Location = new System.Drawing.Point(195, 21);
            this.labelWorkers.Name = "labelWorkers";
<<<<<<< HEAD
            this.labelWorkers.Size = new System.Drawing.Size(70, 18);
=======
            this.labelWorkers.Size = new System.Drawing.Size(55, 15);
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.labelWorkers.TabIndex = 18;
            this.labelWorkers.Text = "Workers:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(388, 3);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(41, 15);
            this.labelMoney.TabIndex = 17;
            this.labelMoney.Text = "Bank: ";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalary.Location = new System.Drawing.Point(195, 3);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(47, 15);
            this.labelSalary.TabIndex = 16;
            this.labelSalary.Text = "Salary: ";
            // 
            // labelParkingPlaces
            // 
            this.labelParkingPlaces.AutoSize = true;
            this.labelParkingPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParkingPlaces.Location = new System.Drawing.Point(3, 3);
            this.labelParkingPlaces.Name = "labelParkingPlaces";
            this.labelParkingPlaces.Size = new System.Drawing.Size(95, 15);
            this.labelParkingPlaces.TabIndex = 15;
            this.labelParkingPlaces.Text = "Parking Places: ";
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EndButton.FlatAppearance.BorderSize = 0;
            this.EndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndButton.Location = new System.Drawing.Point(648, 3);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(55, 50);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // chart1
            // 
<<<<<<< HEAD
            chartArea11.AxisX.Minimum = 0D;
            chartArea11.BorderWidth = 3;
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
=======
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            this.chart1.Location = new System.Drawing.Point(230, 72);
            this.chart1.Name = "chart1";
            series21.BorderWidth = 3;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Workers";
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "Income";
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Size = new System.Drawing.Size(698, 404);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Init
            // 
            this.Init.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Init.FlatAppearance.BorderSize = 0;
            this.Init.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Init.Location = new System.Drawing.Point(15, 11);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(206, 50);
            this.Init.TabIndex = 3;
            this.Init.Text = "All set";
            this.Init.UseVisualStyleBackColor = false;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
<<<<<<< HEAD
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(3, 21);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(104, 18);
            this.labelPrice.TabIndex = 25;
            this.labelPrice.Text = "Price an hour: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
=======
            // labelExpenses
            // 
            this.labelExpenses.AutoSize = true;
            this.labelExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpenses.Location = new System.Drawing.Point(195, 39);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(64, 15);
            this.labelExpenses.TabIndex = 24;
            this.labelExpenses.Text = "Expenses:";
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 488);
            this.Controls.Add(this.Init);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelParameters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputFeeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAvgPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVP)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label labelVP;
        private System.Windows.Forms.TrackBar trackBarVP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputFeeSize;
        private System.Windows.Forms.NumericUpDown inputAvgPrice;
        private System.Windows.Forms.Label labelLC;
        private System.Windows.Forms.TrackBar trackBarLC;
        private System.Windows.Forms.Label labelParkingPlaces;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.NumericUpDown inputBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWorkers;
        private System.Windows.Forms.Label labelViolations;
        private System.Windows.Forms.Label labelIntersect;
        private System.Windows.Forms.Label labelVFee;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelExpenses;
<<<<<<< HEAD
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Timer timer1;
=======
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
    }
}

