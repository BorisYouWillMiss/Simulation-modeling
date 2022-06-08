namespace MarkovChainWeatherStateLab12
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StepBtn = new System.Windows.Forms.Button();
            this.LabelPicture = new System.Windows.Forms.Label();
            this.edit1 = new System.Windows.Forms.NumericUpDown();
            this.edit2 = new System.Windows.Forms.NumericUpDown();
            this.edit3 = new System.Windows.Forms.NumericUpDown();
            this.edit4 = new System.Windows.Forms.NumericUpDown();
            this.edit5 = new System.Windows.Forms.NumericUpDown();
            this.edit6 = new System.Windows.Forms.NumericUpDown();
            this.edit7 = new System.Windows.Forms.NumericUpDown();
            this.edit8 = new System.Windows.Forms.NumericUpDown();
            this.edit9 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.editN = new System.Windows.Forms.NumericUpDown();
            this.editT = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelClear = new System.Windows.Forms.Label();
            this.labelCloudy = new System.Windows.Forms.Label();
            this.labelRain = new System.Windows.Forms.Label();
            this.buttonSimulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editT)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(297, 212);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(118, 53);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StepBtn
            // 
            this.StepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepBtn.Location = new System.Drawing.Point(421, 224);
            this.StepBtn.Name = "StepBtn";
            this.StepBtn.Size = new System.Drawing.Size(75, 33);
            this.StepBtn.TabIndex = 1;
            this.StepBtn.Text = "Step";
            this.StepBtn.UseVisualStyleBackColor = true;
            this.StepBtn.Click += new System.EventHandler(this.StepBtn_Click);
            // 
            // LabelPicture
            // 
            this.LabelPicture.AutoSize = true;
            this.LabelPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelPicture.Font = new System.Drawing.Font("Cascadia Code", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPicture.Location = new System.Drawing.Point(296, 9);
            this.LabelPicture.MaximumSize = new System.Drawing.Size(375, 406);
            this.LabelPicture.MinimumSize = new System.Drawing.Size(200, 200);
            this.LabelPicture.Name = "LabelPicture";
            this.LabelPicture.Size = new System.Drawing.Size(200, 200);
            this.LabelPicture.TabIndex = 2;
            this.LabelPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit1
            // 
            this.edit1.DecimalPlaces = 1;
            this.edit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit1.Location = new System.Drawing.Point(12, 44);
            this.edit1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edit1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(62, 30);
            this.edit1.TabIndex = 3;
            this.edit1.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147418112});
            // 
            // edit2
            // 
            this.edit2.DecimalPlaces = 1;
            this.edit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit2.Location = new System.Drawing.Point(80, 44);
            this.edit2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(62, 30);
            this.edit2.TabIndex = 4;
            this.edit2.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // edit3
            // 
            this.edit3.DecimalPlaces = 1;
            this.edit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit3.Location = new System.Drawing.Point(148, 44);
            this.edit3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(62, 30);
            this.edit3.TabIndex = 5;
            this.edit3.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edit4
            // 
            this.edit4.DecimalPlaces = 1;
            this.edit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit4.Location = new System.Drawing.Point(12, 80);
            this.edit4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit4.Name = "edit4";
            this.edit4.Size = new System.Drawing.Size(62, 30);
            this.edit4.TabIndex = 6;
            this.edit4.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // edit5
            // 
            this.edit5.DecimalPlaces = 1;
            this.edit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit5.Location = new System.Drawing.Point(80, 80);
            this.edit5.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edit5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.edit5.Name = "edit5";
            this.edit5.Size = new System.Drawing.Size(62, 30);
            this.edit5.TabIndex = 7;
            this.edit5.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147418112});
            // 
            // edit6
            // 
            this.edit6.DecimalPlaces = 1;
            this.edit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit6.Location = new System.Drawing.Point(148, 80);
            this.edit6.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit6.Name = "edit6";
            this.edit6.Size = new System.Drawing.Size(62, 30);
            this.edit6.TabIndex = 8;
            this.edit6.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // edit7
            // 
            this.edit7.DecimalPlaces = 1;
            this.edit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit7.Location = new System.Drawing.Point(12, 116);
            this.edit7.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit7.Name = "edit7";
            this.edit7.Size = new System.Drawing.Size(62, 30);
            this.edit7.TabIndex = 9;
            this.edit7.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edit8
            // 
            this.edit8.DecimalPlaces = 1;
            this.edit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit8.Location = new System.Drawing.Point(80, 116);
            this.edit8.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit8.Name = "edit8";
            this.edit8.Size = new System.Drawing.Size(62, 30);
            this.edit8.TabIndex = 10;
            this.edit8.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // edit9
            // 
            this.edit9.DecimalPlaces = 1;
            this.edit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit9.Location = new System.Drawing.Point(148, 116);
            this.edit9.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edit9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.edit9.Name = "edit9";
            this.edit9.Size = new System.Drawing.Size(62, 30);
            this.edit9.TabIndex = 11;
            this.edit9.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Transition matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(216, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cloudy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(216, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rain";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeather.Location = new System.Drawing.Point(216, 13);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(87, 25);
            this.labelWeather.TabIndex = 16;
            this.labelWeather.Text = "Weather";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Day.Location = new System.Drawing.Point(313, 184);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(58, 25);
            this.Day.TabIndex = 17;
            this.Day.Text = "Day: ";
            // 
            // editN
            // 
            this.editN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editN.Location = new System.Drawing.Point(35, 166);
            this.editN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editN.Name = "editN";
            this.editN.Size = new System.Drawing.Size(62, 30);
            this.editN.TabIndex = 18;
            this.editN.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // editT
            // 
            this.editT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editT.Location = new System.Drawing.Point(35, 212);
            this.editT.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editT.Name = "editT";
            this.editT.Size = new System.Drawing.Size(62, 30);
            this.editT.TabIndex = 19;
            this.editT.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "T";
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClear.Location = new System.Drawing.Point(109, 171);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(59, 25);
            this.labelClear.TabIndex = 22;
            this.labelClear.Text = "Clear";
            // 
            // labelCloudy
            // 
            this.labelCloudy.AutoSize = true;
            this.labelCloudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCloudy.Location = new System.Drawing.Point(109, 217);
            this.labelCloudy.Name = "labelCloudy";
            this.labelCloudy.Size = new System.Drawing.Size(74, 25);
            this.labelCloudy.TabIndex = 23;
            this.labelCloudy.Text = "Cloudy";
            // 
            // labelRain
            // 
            this.labelRain.AutoSize = true;
            this.labelRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRain.Location = new System.Drawing.Point(109, 255);
            this.labelRain.Name = "labelRain";
            this.labelRain.Size = new System.Drawing.Size(51, 25);
            this.labelRain.TabIndex = 24;
            this.labelRain.Text = "Rain";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSimulate.Location = new System.Drawing.Point(3, 248);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(94, 43);
            this.buttonSimulate.TabIndex = 25;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 303);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.labelRain);
            this.Controls.Add(this.labelCloudy);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editT);
            this.Controls.Add(this.editN);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit9);
            this.Controls.Add(this.edit8);
            this.Controls.Add(this.edit7);
            this.Controls.Add(this.edit6);
            this.Controls.Add(this.edit5);
            this.Controls.Add(this.edit4);
            this.Controls.Add(this.edit3);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.LabelPicture);
            this.Controls.Add(this.StepBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StepBtn;
        private System.Windows.Forms.Label LabelPicture;
        private System.Windows.Forms.NumericUpDown edit1;
        private System.Windows.Forms.NumericUpDown edit2;
        private System.Windows.Forms.NumericUpDown edit3;
        private System.Windows.Forms.NumericUpDown edit4;
        private System.Windows.Forms.NumericUpDown edit5;
        private System.Windows.Forms.NumericUpDown edit6;
        private System.Windows.Forms.NumericUpDown edit7;
        private System.Windows.Forms.NumericUpDown edit8;
        private System.Windows.Forms.NumericUpDown edit9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.NumericUpDown editN;
        private System.Windows.Forms.NumericUpDown editT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Label labelCloudy;
        private System.Windows.Forms.Label labelRain;
        private System.Windows.Forms.Button buttonSimulate;
    }
}

