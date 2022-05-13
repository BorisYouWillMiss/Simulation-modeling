namespace RandomEventsLab9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.edit1 = new System.Windows.Forms.NumericUpDown();
            this.edit2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.edit3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.edit4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAuto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editTestsNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelSquared = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1";
            // 
            // edit1
            // 
            this.edit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit1.Location = new System.Drawing.Point(90, 11);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(59, 30);
            this.edit1.TabIndex = 1;
            this.edit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edit1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.edit1.ValueChanged += new System.EventHandler(this.edit1_ValueChanged_1);
            // 
            // edit2
            // 
            this.edit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit2.Location = new System.Drawing.Point(90, 53);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(59, 30);
            this.edit2.TabIndex = 3;
            this.edit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edit2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.edit2.ValueChanged += new System.EventHandler(this.edit2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prob 2";
            // 
            // edit3
            // 
            this.edit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit3.Location = new System.Drawing.Point(90, 97);
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(59, 30);
            this.edit3.TabIndex = 5;
            this.edit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edit3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.edit3.ValueChanged += new System.EventHandler(this.edit3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prob 3";
            // 
            // edit4
            // 
            this.edit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit4.Location = new System.Drawing.Point(90, 144);
            this.edit4.Name = "edit4";
            this.edit4.Size = new System.Drawing.Size(59, 30);
            this.edit4.TabIndex = 7;
            this.edit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edit4.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.edit4.ValueChanged += new System.EventHandler(this.edit4_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prob 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prob 5";
            // 
            // labelAuto
            // 
            this.labelAuto.AutoSize = true;
            this.labelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuto.Location = new System.Drawing.Point(87, 189);
            this.labelAuto.Name = "labelAuto";
            this.labelAuto.Size = new System.Drawing.Size(50, 25);
            this.labelAuto.TabIndex = 9;
            this.labelAuto.Text = "auto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of tests";
            // 
            // editTestsNumber
            // 
            this.editTestsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTestsNumber.Location = new System.Drawing.Point(180, 247);
            this.editTestsNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.editTestsNumber.Name = "editTestsNumber";
            this.editTestsNumber.Size = new System.Drawing.Size(75, 30);
            this.editTestsNumber.TabIndex = 11;
            this.editTestsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.editTestsNumber.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(20, 285);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(235, 64);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chart1
            // 
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(189, 11);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Label = "#VAL{N3}";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(506, 216);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(153, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(153, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(153, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(153, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "%";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverage.Location = new System.Drawing.Point(283, 247);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(97, 25);
            this.labelAverage.TabIndex = 18;
            this.labelAverage.Text = "Average: ";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariance.Location = new System.Drawing.Point(283, 285);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(96, 25);
            this.labelVariance.TabIndex = 19;
            this.labelVariance.Text = "Variance:";
            // 
            // labelSquared
            // 
            this.labelSquared.AutoSize = true;
            this.labelSquared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSquared.Location = new System.Drawing.Point(283, 324);
            this.labelSquared.Name = "labelSquared";
            this.labelSquared.Size = new System.Drawing.Size(126, 25);
            this.labelSquared.TabIndex = 20;
            this.labelSquared.Text = "Chi-squared:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 361);
            this.Controls.Add(this.labelSquared);
            this.Controls.Add(this.labelVariance);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.editTestsNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelAuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edit4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edit3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edit1;
        private System.Windows.Forms.NumericUpDown edit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edit3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edit4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown editTestsNumber;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label labelSquared;
    }
}

