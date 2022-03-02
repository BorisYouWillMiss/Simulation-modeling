namespace ElementaryCellularAutomaton
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
            this.panelCells = new System.Windows.Forms.Panel();
            this.panelStart = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editRows = new System.Windows.Forms.NumericUpDown();
            this.editColumns = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editRule = new System.Windows.Forms.NumericUpDown();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelStop = new System.Windows.Forms.Panel();
            this.buttonFF = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRule)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCells
            // 
            this.panelCells.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCells.Location = new System.Drawing.Point(277, 12);
            this.panelCells.Name = "panelCells";
            this.panelCells.Size = new System.Drawing.Size(700, 700);
            this.panelCells.TabIndex = 0;
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.label4);
            this.panelStart.Controls.Add(this.label3);
            this.panelStart.Controls.Add(this.label2);
            this.panelStart.Controls.Add(this.editRows);
            this.panelStart.Controls.Add(this.editColumns);
            this.panelStart.Controls.Add(this.buttonStart);
            this.panelStart.Controls.Add(this.label1);
            this.panelStart.Controls.Add(this.editRule);
            this.panelStart.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStart.Location = new System.Drawing.Point(9, 13);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(262, 212);
            this.panelStart.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columns";
            // 
            // editRows
            // 
            this.editRows.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRows.Location = new System.Drawing.Point(118, 122);
            this.editRows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.editRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.editRows.Name = "editRows";
            this.editRows.Size = new System.Drawing.Size(141, 32);
            this.editRows.TabIndex = 4;
            this.editRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // editColumns
            // 
            this.editColumns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editColumns.Location = new System.Drawing.Point(118, 84);
            this.editColumns.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.editColumns.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.editColumns.Name = "editColumns";
            this.editColumns.Size = new System.Drawing.Size(141, 32);
            this.editColumns.TabIndex = 3;
            this.editColumns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(3, 160);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(256, 45);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Given rule";
            // 
            // editRule
            // 
            this.editRule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRule.Location = new System.Drawing.Point(118, 46);
            this.editRule.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.editRule.Name = "editRule";
            this.editRule.Size = new System.Drawing.Size(141, 32);
            this.editRule.TabIndex = 0;
            this.editRule.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.progressBar);
            this.panelBottom.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBottom.Location = new System.Drawing.Point(9, 655);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(262, 57);
            this.panelBottom.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(256, 49);
            this.progressBar.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelStop
            // 
            this.panelStop.Controls.Add(this.buttonFF);
            this.panelStop.Controls.Add(this.buttonStep);
            this.panelStop.Controls.Add(this.logs);
            this.panelStop.Controls.Add(this.buttonStop);
            this.panelStop.Location = new System.Drawing.Point(9, 231);
            this.panelStop.Name = "panelStop";
            this.panelStop.Size = new System.Drawing.Size(262, 421);
            this.panelStop.TabIndex = 4;
            // 
            // buttonFF
            // 
            this.buttonFF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFF.Location = new System.Drawing.Point(3, 54);
            this.buttonFF.Name = "buttonFF";
            this.buttonFF.Size = new System.Drawing.Size(256, 45);
            this.buttonFF.TabIndex = 9;
            this.buttonFF.Text = "Fast Forward";
            this.buttonFF.UseVisualStyleBackColor = true;
            this.buttonFF.Click += new System.EventHandler(this.buttonFF_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStep.Location = new System.Drawing.Point(3, 3);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(256, 45);
            this.buttonStep.TabIndex = 8;
            this.buttonStep.Text = "Step Forward";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(3, 107);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(256, 260);
            this.logs.TabIndex = 8;
            this.logs.Text = "";
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(3, 373);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(259, 45);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 716);
            this.Controls.Add(this.panelStop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panelCells);
            this.MaximumSize = new System.Drawing.Size(1002, 763);
            this.MinimumSize = new System.Drawing.Size(1002, 763);
            this.Name = "Form1";
            this.Text = "ECA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRule)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelStop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCells;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown editRule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown editRows;
        private System.Windows.Forms.NumericUpDown editColumns;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelStop;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFF;
        private System.Windows.Forms.Button buttonStep;
    }
}

