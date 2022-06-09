namespace AgentModelingLab14
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.editN = new System.Windows.Forms.NumericUpDown();
            this.lbAllClients = new System.Windows.Forms.Label();
            this.lbLastClientTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCurrentHour = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(13, 85);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 39);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(9, 7);
            this.labelN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(20, 20);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "N";
            // 
            // editN
            // 
            this.editN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editN.Location = new System.Drawing.Point(33, 6);
            this.editN.Margin = new System.Windows.Forms.Padding(2);
            this.editN.Name = "editN";
            this.editN.Size = new System.Drawing.Size(76, 26);
            this.editN.TabIndex = 4;
            // 
            // lbAllClients
            // 
            this.lbAllClients.AutoSize = true;
            this.lbAllClients.Location = new System.Drawing.Point(3, 13);
            this.lbAllClients.Name = "lbAllClients";
            this.lbAllClients.Size = new System.Drawing.Size(131, 13);
            this.lbAllClients.TabIndex = 5;
            this.lbAllClients.Text = "Всего клиентов пришло:";
            // 
            // lbLastClientTime
            // 
            this.lbLastClientTime.AutoSize = true;
            this.lbLastClientTime.Location = new System.Drawing.Point(3, 26);
            this.lbLastClientTime.Name = "lbLastClientTime";
            this.lbLastClientTime.Size = new System.Drawing.Size(226, 13);
            this.lbLastClientTime.TabIndex = 6;
            this.lbLastClientTime.Text = "Время прихода последнего клиента (день):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbCurrentHour);
            this.panel1.Controls.Add(this.lbAllClients);
            this.panel1.Controls.Add(this.lbLastClientTime);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 67);
            this.panel1.TabIndex = 7;
            // 
            // lbCurrentHour
            // 
            this.lbCurrentHour.AutoSize = true;
            this.lbCurrentHour.Location = new System.Drawing.Point(3, 39);
            this.lbCurrentHour.Name = "lbCurrentHour";
            this.lbCurrentHour.Size = new System.Drawing.Size(116, 13);
            this.lbCurrentHour.TabIndex = 7;
            this.lbCurrentHour.Text = "Текущее время (час):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.editN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown editN;
        private System.Windows.Forms.Label lbAllClients;
        private System.Windows.Forms.Label lbLastClientTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCurrentHour;
    }
}

