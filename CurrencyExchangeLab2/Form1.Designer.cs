namespace CurrencyExchangeLab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editExRateDollar = new System.Windows.Forms.NumericUpDown();
            this.labelDollar = new System.Windows.Forms.Label();
            this.buttonPredict = new System.Windows.Forms.Button();
            this.editDays = new System.Windows.Forms.NumericUpDown();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.editExRateEuro = new System.Windows.Forms.NumericUpDown();
            this.chartLines = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editExRateDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editExRateEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLines)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editExRateDollar);
            this.panel1.Controls.Add(this.labelDollar);
            this.panel1.Controls.Add(this.buttonPredict);
            this.panel1.Controls.Add(this.editDays);
            this.panel1.Controls.Add(this.labelDays);
            this.panel1.Controls.Add(this.labelIP);
            this.panel1.Controls.Add(this.editExRateEuro);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 102);
            this.panel1.TabIndex = 0;
            // 
            // editExRateDollar
            // 
            this.editExRateDollar.DecimalPlaces = 2;
            this.editExRateDollar.Location = new System.Drawing.Point(160, 39);
            this.editExRateDollar.Name = "editExRateDollar";
            this.editExRateDollar.Size = new System.Drawing.Size(120, 22);
            this.editExRateDollar.TabIndex = 6;
            this.editExRateDollar.Value = new decimal(new int[] {
            7744,
            0,
            0,
            131072});
            // 
            // labelDollar
            // 
            this.labelDollar.AutoSize = true;
            this.labelDollar.Location = new System.Drawing.Point(52, 41);
            this.labelDollar.Name = "labelDollar";
            this.labelDollar.Size = new System.Drawing.Size(110, 16);
            this.labelDollar.TabIndex = 5;
            this.labelDollar.Text = "Dollar Initial Price";
            // 
            // buttonPredict
            // 
            this.buttonPredict.Location = new System.Drawing.Point(299, 9);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(92, 79);
            this.buttonPredict.TabIndex = 4;
            this.buttonPredict.Text = "Predict";
            this.buttonPredict.UseVisualStyleBackColor = true;
            this.buttonPredict.Click += new System.EventHandler(this.buttonPredict_Click);
            // 
            // editDays
            // 
            this.editDays.Location = new System.Drawing.Point(160, 66);
            this.editDays.Name = "editDays";
            this.editDays.Size = new System.Drawing.Size(120, 22);
            this.editDays.TabIndex = 3;
            this.editDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.editDays.Visible = false;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(115, 68);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(39, 16);
            this.labelDays.TabIndex = 2;
            this.labelDays.Text = "Days";
            this.labelDays.Visible = false;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(52, 11);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(102, 16);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "Euro Initial Price";
            // 
            // editExRateEuro
            // 
            this.editExRateEuro.DecimalPlaces = 2;
            this.editExRateEuro.Location = new System.Drawing.Point(160, 9);
            this.editExRateEuro.Name = "editExRateEuro";
            this.editExRateEuro.Size = new System.Drawing.Size(120, 22);
            this.editExRateEuro.TabIndex = 0;
            this.editExRateEuro.Value = new decimal(new int[] {
            8763,
            0,
            0,
            131072});
            // 
            // chartLines
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Minimum = 60D;
            chartArea3.Name = "ChartArea1";
            this.chartLines.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartLines.Legends.Add(legend3);
            this.chartLines.Location = new System.Drawing.Point(4, 111);
            this.chartLines.Name = "chartLines";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.IsValueShownAsLabel = true;
            series5.LabelFormat = "C";
            series5.Legend = "Legend1";
            series5.Name = "Euro";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.IsValueShownAsLabel = true;
            series6.LabelFormat = "C";
            series6.Legend = "Legend1";
            series6.Name = "Dollar";
            this.chartLines.Series.Add(series5);
            this.chartLines.Series.Add(series6);
            this.chartLines.Size = new System.Drawing.Size(792, 336);
            this.chartLines.TabIndex = 1;
            this.chartLines.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartLines);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editExRateDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editExRateEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLines;
        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.NumericUpDown editDays;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.NumericUpDown editExRateEuro;
        private System.Windows.Forms.NumericUpDown editExRateDollar;
        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.Timer timer1;
    }
}

