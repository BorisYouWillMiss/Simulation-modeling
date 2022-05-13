namespace RandomEventsLab8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TestBtn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editTest1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTest1Text = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TestBtn2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2answer = new System.Windows.Forms.Label();
            this.TestBtn3 = new System.Windows.Forms.Button();
            this.edit3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editTest1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestBtn1
            // 
            this.TestBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestBtn1.Location = new System.Drawing.Point(25, 47);
            this.TestBtn1.Name = "TestBtn1";
            this.TestBtn1.Size = new System.Drawing.Size(162, 43);
            this.TestBtn1.TabIndex = 0;
            this.TestBtn1.Text = "Generate";
            this.TestBtn1.UseVisualStyleBackColor = true;
            this.TestBtn1.Click += new System.EventHandler(this.TestBtn1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labelTest1Text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editTest1);
            this.panel1.Controls.Add(this.TestBtn1);
            this.panel1.Location = new System.Drawing.Point(15, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 268);
            this.panel1.TabIndex = 1;
            // 
            // editTest1
            // 
            this.editTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTest1.Location = new System.Drawing.Point(84, 7);
            this.editTest1.Name = "editTest1";
            this.editTest1.Size = new System.Drawing.Size(73, 34);
            this.editTest1.TabIndex = 1;
            this.editTest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.editTest1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // labelTest1Text
            // 
            this.labelTest1Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTest1Text.AutoSize = true;
            this.labelTest1Text.Font = new System.Drawing.Font("Cascadia Code", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTest1Text.Location = new System.Drawing.Point(-1, 107);
            this.labelTest1Text.MaximumSize = new System.Drawing.Size(500, 500);
            this.labelTest1Text.Name = "labelTest1Text";
            this.labelTest1Text.Size = new System.Drawing.Size(163, 160);
            this.labelTest1Text.TabIndex = 4;
            this.labelTest1Text.Text = resources.GetString("labelTest1Text.Text");
            this.labelTest1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label2answer);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TestBtn2);
            this.panel2.Location = new System.Drawing.Point(231, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 268);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.buttonRun);
            this.panel3.Controls.Add(this.textBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.edit3);
            this.panel3.Controls.Add(this.TestBtn3);
            this.panel3.Location = new System.Drawing.Point(463, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 268);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(93, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "8.1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(15, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 50);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(301, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "8.2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(593, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "8.3";
            // 
            // TestBtn2
            // 
            this.TestBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestBtn2.Location = new System.Drawing.Point(32, 47);
            this.TestBtn2.Name = "TestBtn2";
            this.TestBtn2.Size = new System.Drawing.Size(162, 43);
            this.TestBtn2.TabIndex = 5;
            this.TestBtn2.Text = "Generate";
            this.TestBtn2.UseVisualStyleBackColor = true;
            this.TestBtn2.Click += new System.EventHandler(this.TestBtn2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(27, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Event generator";
            // 
            // label2answer
            // 
            this.label2answer.AutoSize = true;
            this.label2answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2answer.Location = new System.Drawing.Point(13, 96);
            this.label2answer.MaximumSize = new System.Drawing.Size(220, 200);
            this.label2answer.Name = "label2answer";
            this.label2answer.Size = new System.Drawing.Size(17, 25);
            this.label2answer.TabIndex = 6;
            this.label2answer.Text = " ";
            this.label2answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestBtn3
            // 
            this.TestBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestBtn3.Location = new System.Drawing.Point(16, 47);
            this.TestBtn3.Name = "TestBtn3";
            this.TestBtn3.Size = new System.Drawing.Size(200, 43);
            this.TestBtn3.TabIndex = 7;
            this.TestBtn3.Text = "Generate events";
            this.TestBtn3.UseVisualStyleBackColor = true;
            this.TestBtn3.Click += new System.EventHandler(this.TestBtn3_Click);
            // 
            // edit3
            // 
            this.edit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit3.Location = new System.Drawing.Point(219, 9);
            this.edit3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(99, 34);
            this.edit3.TabIndex = 5;
            this.edit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edit3.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Iterations number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(219, 96);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 34);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Number of events";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(16, 136);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(302, 126);
            this.textBox.TabIndex = 10;
            this.textBox.Text = "";
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled = false;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.Location = new System.Drawing.Point(219, 47);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(99, 43);
            this.buttonRun.TabIndex = 11;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // chart1
            // 
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.BorderWidth = 0;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 0);
            this.chart1.Name = "chart1";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.Name = "Procs";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(339, 317);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Location = new System.Drawing.Point(787, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 317);
            this.panel5.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 327);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editTest1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestBtn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown editTest1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTest1Text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TestBtn2;
        private System.Windows.Forms.Label label2answer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TestBtn3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edit3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel5;
    }
}

