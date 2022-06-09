namespace GeometricBrownianMotionLab13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editDollar = new System.Windows.Forms.NumericUpDown();
            this.editEuro = new System.Windows.Forms.NumericUpDown();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(651, 17);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 36);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start/Stop";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial price";
            // 
            // editDollar
            // 
            this.editDollar.DecimalPlaces = 2;
            this.editDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDollar.Location = new System.Drawing.Point(131, 21);
            this.editDollar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.editDollar.Name = "editDollar";
            this.editDollar.Size = new System.Drawing.Size(131, 30);
            this.editDollar.TabIndex = 2;
            this.editDollar.Value = new decimal(new int[] {
            5901,
            0,
            0,
            131072});
            // 
            // editEuro
            // 
            this.editEuro.DecimalPlaces = 2;
            this.editEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEuro.Location = new System.Drawing.Point(287, 21);
            this.editEuro.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.editEuro.Name = "editEuro";
            this.editEuro.Size = new System.Drawing.Size(131, 30);
            this.editEuro.TabIndex = 3;
            this.editEuro.Value = new decimal(new int[] {
            7306,
            0,
            0,
            131072});
            // 
            // chart
            // 
            chartArea7.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart.Legends.Add(legend7);
            this.chart.Location = new System.Drawing.Point(17, 57);
            this.chart.Name = "chart";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.IsValueShownAsLabel = true;
            series13.Legend = "Legend1";
            series13.Name = "Euro";
            series14.BorderColor = System.Drawing.Color.Red;
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Red;
            series14.CustomProperties = "IsXAxisQuantitative=False";
            series14.IsValueShownAsLabel = true;
            series14.Legend = "Legend1";
            series14.MarkerColor = System.Drawing.Color.Red;
            series14.Name = "$";
            this.chart.Series.Add(series13);
            this.chart.Series.Add(series14);
            this.chart.Size = new System.Drawing.Size(749, 508);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 577);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.editEuro);
            this.Controls.Add(this.editDollar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown editDollar;
        private System.Windows.Forms.NumericUpDown editEuro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timer1;
    }
}

