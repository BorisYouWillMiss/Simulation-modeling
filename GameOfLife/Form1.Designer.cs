namespace GameOfLife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.wildGeneration = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.editRows = new System.Windows.Forms.NumericUpDown();
            this.editColumns = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firefieldGeneration = new System.Windows.Forms.RadioButton();
            this.forestGeneration = new System.Windows.Forms.RadioButton();
            this.oceanGeneration = new System.Windows.Forms.RadioButton();
            this.randomGeneration = new System.Windows.Forms.RadioButton();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.gameTreesDrainWater = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gameFloodChance = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.gameForestSurvivability = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.gameWaterLife = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gameFireFades = new System.Windows.Forms.NumericUpDown();
            this.buttonWild = new System.Windows.Forms.Button();
            this.buttonFlowPause = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFlowNormal = new System.Windows.Forms.Button();
            this.buttonFlowFast = new System.Windows.Forms.Button();
            this.buttonTick = new System.Windows.Forms.Button();
            this.buttonFlowFastest = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonWater = new System.Windows.Forms.Button();
            this.buttonForest = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelCustomize = new System.Windows.Forms.Panel();
            this.labelWildPercent = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.labelWild = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGridColor = new System.Windows.Forms.Button();
            this.checkBoxDrawGrid = new System.Windows.Forms.CheckBox();
            this.canvasPreview = new System.Windows.Forms.PictureBox();
            this.labelForestPercent = new System.Windows.Forms.Label();
            this.labelWaterPercent = new System.Windows.Forms.Label();
            this.labelFirePercent = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCustomSettings = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelForest = new System.Windows.Forms.Label();
            this.labelWater = new System.Windows.Forms.Label();
            this.labelFire = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.timerPreview = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panelEnd = new System.Windows.Forms.Panel();
            this.panelLogs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editColumns)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameTreesDrainWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameFloodChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameForestSurvivability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameWaterLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameFireFades)).BeginInit();
            this.panelCustomize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelCustomSettings.SuspendLayout();
            this.panelEnd.SuspendLayout();
            this.panelLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.canvas.Enabled = false;
            this.canvas.Location = new System.Drawing.Point(300, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(650, 600);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseLeave += new System.EventHandler(this.canvas_MouseLeave);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSettings.Controls.Add(this.wildGeneration);
            this.panelSettings.Controls.Add(this.panel2);
            this.panelSettings.Controls.Add(this.panel1);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.firefieldGeneration);
            this.panelSettings.Controls.Add(this.forestGeneration);
            this.panelSettings.Controls.Add(this.oceanGeneration);
            this.panelSettings.Controls.Add(this.randomGeneration);
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(300, 250);
            this.panelSettings.TabIndex = 1;
            // 
            // wildGeneration
            // 
            this.wildGeneration.AutoSize = true;
            this.wildGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wildGeneration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wildGeneration.Location = new System.Drawing.Point(12, 211);
            this.wildGeneration.Name = "wildGeneration";
            this.wildGeneration.Size = new System.Drawing.Size(70, 28);
            this.wildGeneration.TabIndex = 14;
            this.wildGeneration.TabStop = true;
            this.wildGeneration.Text = "Wild";
            this.wildGeneration.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.buttonSettings);
            this.panel2.Controls.Add(this.labelColumns);
            this.panel2.Controls.Add(this.labelRows);
            this.panel2.Controls.Add(this.editRows);
            this.panel2.Controls.Add(this.editColumns);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Location = new System.Drawing.Point(132, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 205);
            this.panel2.TabIndex = 13;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Gold;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(15, 88);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(147, 55);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Customize field";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumns.Location = new System.Drawing.Point(11, 20);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(83, 24);
            this.labelColumns.TabIndex = 4;
            this.labelColumns.Text = "Columns";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRows.Location = new System.Drawing.Point(40, 52);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(54, 24);
            this.labelRows.TabIndex = 3;
            this.labelRows.Text = "Rows";
            // 
            // editRows
            // 
            this.editRows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editRows.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRows.Location = new System.Drawing.Point(100, 50);
            this.editRows.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.editRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.editRows.Name = "editRows";
            this.editRows.Size = new System.Drawing.Size(62, 32);
            this.editRows.TabIndex = 2;
            this.editRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.editRows.ValueChanged += new System.EventHandler(this.editRows_ValueChanged);
            // 
            // editColumns
            // 
            this.editColumns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editColumns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editColumns.Location = new System.Drawing.Point(100, 20);
            this.editColumns.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.editColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.editColumns.Name = "editColumns";
            this.editColumns.Size = new System.Drawing.Size(62, 32);
            this.editColumns.TabIndex = 1;
            this.editColumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.editColumns.ValueChanged += new System.EventHandler(this.editColumns_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(15, 144);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(147, 55);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Generation";
            // 
            // firefieldGeneration
            // 
            this.firefieldGeneration.AutoSize = true;
            this.firefieldGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firefieldGeneration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firefieldGeneration.Location = new System.Drawing.Point(12, 180);
            this.firefieldGeneration.Name = "firefieldGeneration";
            this.firefieldGeneration.Size = new System.Drawing.Size(99, 28);
            this.firefieldGeneration.TabIndex = 9;
            this.firefieldGeneration.TabStop = true;
            this.firefieldGeneration.Text = "Firefield";
            this.firefieldGeneration.UseVisualStyleBackColor = true;
            // 
            // forestGeneration
            // 
            this.forestGeneration.AutoSize = true;
            this.forestGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forestGeneration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forestGeneration.Location = new System.Drawing.Point(12, 150);
            this.forestGeneration.Name = "forestGeneration";
            this.forestGeneration.Size = new System.Drawing.Size(83, 28);
            this.forestGeneration.TabIndex = 8;
            this.forestGeneration.TabStop = true;
            this.forestGeneration.Text = "Forest";
            this.forestGeneration.UseVisualStyleBackColor = true;
            // 
            // oceanGeneration
            // 
            this.oceanGeneration.AutoSize = true;
            this.oceanGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oceanGeneration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oceanGeneration.Location = new System.Drawing.Point(12, 120);
            this.oceanGeneration.Name = "oceanGeneration";
            this.oceanGeneration.Size = new System.Drawing.Size(83, 28);
            this.oceanGeneration.TabIndex = 7;
            this.oceanGeneration.TabStop = true;
            this.oceanGeneration.Text = "Ocean";
            this.oceanGeneration.UseVisualStyleBackColor = true;
            // 
            // randomGeneration
            // 
            this.randomGeneration.AutoSize = true;
            this.randomGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomGeneration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomGeneration.Location = new System.Drawing.Point(12, 90);
            this.randomGeneration.Name = "randomGeneration";
            this.randomGeneration.Size = new System.Drawing.Size(101, 28);
            this.randomGeneration.TabIndex = 6;
            this.randomGeneration.TabStop = true;
            this.randomGeneration.Text = "Random";
            this.randomGeneration.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(5, 0);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(290, 350);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPlay.Controls.Add(this.label13);
            this.panelPlay.Controls.Add(this.gameTreesDrainWater);
            this.panelPlay.Controls.Add(this.label12);
            this.panelPlay.Controls.Add(this.label11);
            this.panelPlay.Controls.Add(this.gameFloodChance);
            this.panelPlay.Controls.Add(this.label10);
            this.panelPlay.Controls.Add(this.gameForestSurvivability);
            this.panelPlay.Controls.Add(this.label9);
            this.panelPlay.Controls.Add(this.gameWaterLife);
            this.panelPlay.Controls.Add(this.label8);
            this.panelPlay.Controls.Add(this.gameFireFades);
            this.panelPlay.Controls.Add(this.buttonWild);
            this.panelPlay.Controls.Add(this.buttonFlowPause);
            this.panelPlay.Controls.Add(this.label7);
            this.panelPlay.Controls.Add(this.buttonFlowNormal);
            this.panelPlay.Controls.Add(this.buttonFlowFast);
            this.panelPlay.Controls.Add(this.buttonTick);
            this.panelPlay.Controls.Add(this.buttonFlowFastest);
            this.panelPlay.Controls.Add(this.buttonFire);
            this.panelPlay.Controls.Add(this.buttonWater);
            this.panelPlay.Controls.Add(this.buttonForest);
            this.panelPlay.Enabled = false;
            this.panelPlay.Location = new System.Drawing.Point(950, 0);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(285, 540);
            this.panelPlay.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(85, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 24);
            this.label13.TabIndex = 37;
            this.label13.Text = "Trees drain water +%";
            // 
            // gameTreesDrainWater
            // 
            this.gameTreesDrainWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameTreesDrainWater.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTreesDrainWater.Location = new System.Drawing.Point(141, 335);
            this.gameTreesDrainWater.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gameTreesDrainWater.Name = "gameTreesDrainWater";
            this.gameTreesDrainWater.Size = new System.Drawing.Size(62, 32);
            this.gameTreesDrainWater.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "Pause";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(99, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "Wild flood chance";
            // 
            // gameFloodChance
            // 
            this.gameFloodChance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameFloodChance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameFloodChance.Location = new System.Drawing.Point(141, 262);
            this.gameFloodChance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gameFloodChance.Name = "gameFloodChance";
            this.gameFloodChance.Size = new System.Drawing.Size(62, 32);
            this.gameFloodChance.TabIndex = 33;
            this.gameFloodChance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(82, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Forest survivability +%";
            // 
            // gameForestSurvivability
            // 
            this.gameForestSurvivability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameForestSurvivability.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameForestSurvivability.Location = new System.Drawing.Point(141, 44);
            this.gameForestSurvivability.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.gameForestSurvivability.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gameForestSurvivability.Name = "gameForestSurvivability";
            this.gameForestSurvivability.Size = new System.Drawing.Size(62, 32);
            this.gameForestSurvivability.TabIndex = 31;
            this.gameForestSurvivability.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(96, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Water life spread +%";
            // 
            // gameWaterLife
            // 
            this.gameWaterLife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameWaterLife.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameWaterLife.Location = new System.Drawing.Point(141, 116);
            this.gameWaterLife.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gameWaterLife.Name = "gameWaterLife";
            this.gameWaterLife.Size = new System.Drawing.Size(62, 32);
            this.gameWaterLife.TabIndex = 29;
            this.gameWaterLife.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(104, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fire base fade +%";
            // 
            // gameFireFades
            // 
            this.gameFireFades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameFireFades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameFireFades.Location = new System.Drawing.Point(141, 188);
            this.gameFireFades.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gameFireFades.Name = "gameFireFades";
            this.gameFireFades.Size = new System.Drawing.Size(62, 32);
            this.gameFireFades.TabIndex = 6;
            this.gameFireFades.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonWild
            // 
            this.buttonWild.BackColor = System.Drawing.Color.LightGray;
            this.buttonWild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWild.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonWild.FlatAppearance.BorderSize = 0;
            this.buttonWild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWild.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWild.Location = new System.Drawing.Point(6, 224);
            this.buttonWild.Name = "buttonWild";
            this.buttonWild.Size = new System.Drawing.Size(70, 70);
            this.buttonWild.TabIndex = 27;
            this.buttonWild.Text = "Wild";
            this.buttonWild.UseVisualStyleBackColor = false;
            this.buttonWild.Click += new System.EventHandler(this.buttonWild_Click);
            // 
            // buttonFlowPause
            // 
            this.buttonFlowPause.BackColor = System.Drawing.Color.LightGray;
            this.buttonFlowPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowPause.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonFlowPause.FlatAppearance.BorderSize = 0;
            this.buttonFlowPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowPause.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlowPause.Location = new System.Drawing.Point(77, 454);
            this.buttonFlowPause.Name = "buttonFlowPause";
            this.buttonFlowPause.Size = new System.Drawing.Size(70, 70);
            this.buttonFlowPause.TabIndex = 26;
            this.buttonFlowPause.Text = "||";
            this.buttonFlowPause.UseVisualStyleBackColor = false;
            this.buttonFlowPause.Click += new System.EventHandler(this.buttonFlowPause_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Auto";
            // 
            // buttonFlowNormal
            // 
            this.buttonFlowNormal.BackColor = System.Drawing.Color.LightGray;
            this.buttonFlowNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowNormal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonFlowNormal.FlatAppearance.BorderSize = 0;
            this.buttonFlowNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowNormal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlowNormal.Location = new System.Drawing.Point(77, 379);
            this.buttonFlowNormal.Name = "buttonFlowNormal";
            this.buttonFlowNormal.Size = new System.Drawing.Size(70, 70);
            this.buttonFlowNormal.TabIndex = 13;
            this.buttonFlowNormal.Text = ">";
            this.buttonFlowNormal.UseVisualStyleBackColor = false;
            this.buttonFlowNormal.Click += new System.EventHandler(this.buttonFlowNormal_Click);
            // 
            // buttonFlowFast
            // 
            this.buttonFlowFast.BackColor = System.Drawing.Color.LightGray;
            this.buttonFlowFast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowFast.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonFlowFast.FlatAppearance.BorderSize = 0;
            this.buttonFlowFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowFast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlowFast.Location = new System.Drawing.Point(153, 379);
            this.buttonFlowFast.Name = "buttonFlowFast";
            this.buttonFlowFast.Size = new System.Drawing.Size(70, 70);
            this.buttonFlowFast.TabIndex = 12;
            this.buttonFlowFast.Text = ">>";
            this.buttonFlowFast.UseVisualStyleBackColor = false;
            this.buttonFlowFast.Click += new System.EventHandler(this.buttonFlowFast_Click);
            // 
            // buttonTick
            // 
            this.buttonTick.BackColor = System.Drawing.Color.LightGray;
            this.buttonTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTick.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonTick.FlatAppearance.BorderSize = 0;
            this.buttonTick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTick.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTick.Location = new System.Drawing.Point(6, 300);
            this.buttonTick.Name = "buttonTick";
            this.buttonTick.Size = new System.Drawing.Size(70, 67);
            this.buttonTick.TabIndex = 11;
            this.buttonTick.Text = "Step --->";
            this.buttonTick.UseVisualStyleBackColor = false;
            this.buttonTick.Click += new System.EventHandler(this.buttonTick_Click);
            // 
            // buttonFlowFastest
            // 
            this.buttonFlowFastest.BackColor = System.Drawing.Color.LightGray;
            this.buttonFlowFastest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowFastest.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonFlowFastest.FlatAppearance.BorderSize = 0;
            this.buttonFlowFastest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowFastest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlowFastest.Location = new System.Drawing.Point(153, 454);
            this.buttonFlowFastest.Name = "buttonFlowFastest";
            this.buttonFlowFastest.Size = new System.Drawing.Size(70, 70);
            this.buttonFlowFastest.TabIndex = 10;
            this.buttonFlowFastest.Text = ">>>";
            this.buttonFlowFastest.UseVisualStyleBackColor = false;
            this.buttonFlowFastest.Click += new System.EventHandler(this.buttonFlowFastest_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.BackColor = System.Drawing.Color.LightGray;
            this.buttonFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFire.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFire.FlatAppearance.BorderSize = 0;
            this.buttonFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFire.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFire.Location = new System.Drawing.Point(6, 150);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(70, 70);
            this.buttonFire.TabIndex = 9;
            this.buttonFire.Text = "Fire";
            this.buttonFire.UseVisualStyleBackColor = false;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonWater
            // 
            this.buttonWater.BackColor = System.Drawing.Color.LightGray;
            this.buttonWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWater.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonWater.FlatAppearance.BorderSize = 0;
            this.buttonWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWater.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWater.Location = new System.Drawing.Point(6, 78);
            this.buttonWater.Name = "buttonWater";
            this.buttonWater.Size = new System.Drawing.Size(70, 70);
            this.buttonWater.TabIndex = 8;
            this.buttonWater.Text = "Water";
            this.buttonWater.UseVisualStyleBackColor = false;
            this.buttonWater.Click += new System.EventHandler(this.buttonWater_Click);
            // 
            // buttonForest
            // 
            this.buttonForest.BackColor = System.Drawing.Color.LightGray;
            this.buttonForest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonForest.FlatAppearance.BorderSize = 0;
            this.buttonForest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForest.Location = new System.Drawing.Point(6, 6);
            this.buttonForest.Name = "buttonForest";
            this.buttonForest.Size = new System.Drawing.Size(70, 70);
            this.buttonForest.TabIndex = 7;
            this.buttonForest.Text = "Forest";
            this.buttonForest.UseVisualStyleBackColor = false;
            this.buttonForest.Click += new System.EventHandler(this.buttonForest_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnd.Enabled = false;
            this.buttonEnd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnd.Location = new System.Drawing.Point(77, 3);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(147, 55);
            this.buttonEnd.TabIndex = 6;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Gold;
            this.progressBar.ForeColor = System.Drawing.Color.Gold;
            this.progressBar.Location = new System.Drawing.Point(300, 600);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(650, 50);
            this.progressBar.TabIndex = 3;
            // 
            // panelCustomize
            // 
            this.panelCustomize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelCustomize.Controls.Add(this.labelWildPercent);
            this.panelCustomize.Controls.Add(this.trackBar4);
            this.panelCustomize.Controls.Add(this.labelWild);
            this.panelCustomize.Controls.Add(this.label5);
            this.panelCustomize.Controls.Add(this.buttonGridColor);
            this.panelCustomize.Controls.Add(this.checkBoxDrawGrid);
            this.panelCustomize.Controls.Add(this.canvasPreview);
            this.panelCustomize.Controls.Add(this.labelForestPercent);
            this.panelCustomize.Controls.Add(this.labelWaterPercent);
            this.panelCustomize.Controls.Add(this.labelFirePercent);
            this.panelCustomize.Controls.Add(this.trackBar3);
            this.panelCustomize.Controls.Add(this.trackBar2);
            this.panelCustomize.Controls.Add(this.trackBar1);
            this.panelCustomize.Controls.Add(this.label4);
            this.panelCustomize.Controls.Add(this.panelCustomSettings);
            this.panelCustomize.Controls.Add(this.labelForest);
            this.panelCustomize.Controls.Add(this.labelWater);
            this.panelCustomize.Controls.Add(this.labelFire);
            this.panelCustomize.Controls.Add(this.buttonAccept);
            this.panelCustomize.Controls.Add(this.buttonBack);
            this.panelCustomize.Location = new System.Drawing.Point(450, 0);
            this.panelCustomize.Name = "panelCustomize";
            this.panelCustomize.Size = new System.Drawing.Size(300, 467);
            this.panelCustomize.TabIndex = 1;
            this.panelCustomize.Visible = false;
            // 
            // labelWildPercent
            // 
            this.labelWildPercent.AutoSize = true;
            this.labelWildPercent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWildPercent.Location = new System.Drawing.Point(246, 308);
            this.labelWildPercent.Name = "labelWildPercent";
            this.labelWildPercent.Size = new System.Drawing.Size(44, 24);
            this.labelWildPercent.TabIndex = 27;
            this.labelWildPercent.Text = "25%";
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trackBar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar4.Location = new System.Drawing.Point(70, 305);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(170, 56);
            this.trackBar4.TabIndex = 26;
            this.trackBar4.Value = 34;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            this.trackBar4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar4_MouseUp);
            // 
            // labelWild
            // 
            this.labelWild.AutoSize = true;
            this.labelWild.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWild.Location = new System.Drawing.Point(3, 305);
            this.labelWild.Name = "labelWild";
            this.labelWild.Size = new System.Drawing.Size(49, 24);
            this.labelWild.TabIndex = 25;
            this.labelWild.Text = "Wild";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(53, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Grid color";
            // 
            // buttonGridColor
            // 
            this.buttonGridColor.BackColor = System.Drawing.Color.Black;
            this.buttonGridColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGridColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonGridColor.FlatAppearance.BorderSize = 2;
            this.buttonGridColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGridColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGridColor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonGridColor.Location = new System.Drawing.Point(3, 366);
            this.buttonGridColor.Name = "buttonGridColor";
            this.buttonGridColor.Size = new System.Drawing.Size(44, 37);
            this.buttonGridColor.TabIndex = 6;
            this.buttonGridColor.UseVisualStyleBackColor = false;
            this.buttonGridColor.Click += new System.EventHandler(this.buttonGridColor_Click);
            // 
            // checkBoxDrawGrid
            // 
            this.checkBoxDrawGrid.AutoSize = true;
            this.checkBoxDrawGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDrawGrid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDrawGrid.Location = new System.Drawing.Point(172, 371);
            this.checkBoxDrawGrid.Name = "checkBoxDrawGrid";
            this.checkBoxDrawGrid.Size = new System.Drawing.Size(112, 28);
            this.checkBoxDrawGrid.TabIndex = 23;
            this.checkBoxDrawGrid.Text = "Draw grid";
            this.checkBoxDrawGrid.UseVisualStyleBackColor = true;
            // 
            // canvasPreview
            // 
            this.canvasPreview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.canvasPreview.Location = new System.Drawing.Point(88, 76);
            this.canvasPreview.Name = "canvasPreview";
            this.canvasPreview.Size = new System.Drawing.Size(120, 120);
            this.canvasPreview.TabIndex = 22;
            this.canvasPreview.TabStop = false;
            this.canvasPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPreview_Paint);
            // 
            // labelForestPercent
            // 
            this.labelForestPercent.AutoSize = true;
            this.labelForestPercent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForestPercent.Location = new System.Drawing.Point(246, 273);
            this.labelForestPercent.Name = "labelForestPercent";
            this.labelForestPercent.Size = new System.Drawing.Size(44, 24);
            this.labelForestPercent.TabIndex = 21;
            this.labelForestPercent.Text = "25%";
            // 
            // labelWaterPercent
            // 
            this.labelWaterPercent.AutoSize = true;
            this.labelWaterPercent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWaterPercent.Location = new System.Drawing.Point(246, 238);
            this.labelWaterPercent.Name = "labelWaterPercent";
            this.labelWaterPercent.Size = new System.Drawing.Size(44, 24);
            this.labelWaterPercent.TabIndex = 20;
            this.labelWaterPercent.Text = "25%";
            // 
            // labelFirePercent
            // 
            this.labelFirePercent.AutoSize = true;
            this.labelFirePercent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirePercent.Location = new System.Drawing.Point(246, 202);
            this.labelFirePercent.Name = "labelFirePercent";
            this.labelFirePercent.Size = new System.Drawing.Size(44, 24);
            this.labelFirePercent.TabIndex = 19;
            this.labelFirePercent.Text = "25%";
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trackBar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar3.Location = new System.Drawing.Point(70, 273);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(170, 56);
            this.trackBar3.TabIndex = 18;
            this.trackBar3.Value = 34;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            this.trackBar3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar3_MouseDown);
            this.trackBar3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar3_MouseUp);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(70, 238);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(170, 56);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Value = 33;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar2_MouseDown);
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar2_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(70, 203);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(170, 56);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 33;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(65, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Generation example:";
            // 
            // panelCustomSettings
            // 
            this.panelCustomSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCustomSettings.Controls.Add(this.label3);
            this.panelCustomSettings.Location = new System.Drawing.Point(0, 1);
            this.panelCustomSettings.Name = "panelCustomSettings";
            this.panelCustomSettings.Size = new System.Drawing.Size(300, 40);
            this.panelCustomSettings.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(70, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Custom Settings";
            // 
            // labelForest
            // 
            this.labelForest.AutoSize = true;
            this.labelForest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForest.Location = new System.Drawing.Point(3, 270);
            this.labelForest.Name = "labelForest";
            this.labelForest.Size = new System.Drawing.Size(62, 24);
            this.labelForest.TabIndex = 11;
            this.labelForest.Text = "Forest";
            // 
            // labelWater
            // 
            this.labelWater.AutoSize = true;
            this.labelWater.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWater.Location = new System.Drawing.Point(3, 238);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(61, 24);
            this.labelWater.TabIndex = 10;
            this.labelWater.Text = "Water";
            // 
            // labelFire
            // 
            this.labelFire.AutoSize = true;
            this.labelFire.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFire.Location = new System.Drawing.Point(3, 203);
            this.labelFire.Name = "labelFire";
            this.labelFire.Size = new System.Drawing.Size(41, 24);
            this.labelFire.TabIndex = 6;
            this.labelFire.Text = "Fire";
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccept.FlatAppearance.BorderSize = 0;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(184, 426);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(113, 37);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightCoral;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(3, 426);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 37);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // timerPreview
            // 
            this.timerPreview.Interval = 2000;
            this.timerPreview.Tick += new System.EventHandler(this.timerPreview_Tick);
            // 
            // panelEnd
            // 
            this.panelEnd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelEnd.Controls.Add(this.buttonEnd);
            this.panelEnd.Location = new System.Drawing.Point(950, 540);
            this.panelEnd.Name = "panelEnd";
            this.panelEnd.Size = new System.Drawing.Size(285, 110);
            this.panelEnd.TabIndex = 3;
            // 
            // panelLogs
            // 
            this.panelLogs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLogs.Controls.Add(this.logs);
            this.panelLogs.Location = new System.Drawing.Point(0, 256);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(300, 400);
            this.panelLogs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.panelCustomize);
            this.Controls.Add(this.panelLogs);
            this.Controls.Add(this.panelEnd);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 390);
            this.Name = "Form1";
            this.Text = "Game of life - Balanscopy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editColumns)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameTreesDrainWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameFloodChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameForestSurvivability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameWaterLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameFireFades)).EndInit();
            this.panelCustomize.ResumeLayout(false);
            this.panelCustomize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelCustomSettings.ResumeLayout(false);
            this.panelCustomSettings.PerformLayout();
            this.panelEnd.ResumeLayout(false);
            this.panelLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.NumericUpDown editRows;
        private System.Windows.Forms.NumericUpDown editColumns;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton firefieldGeneration;
        private System.Windows.Forms.RadioButton forestGeneration;
        private System.Windows.Forms.RadioButton oceanGeneration;
        private System.Windows.Forms.RadioButton randomGeneration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelCustomize;
        private System.Windows.Forms.Label labelForestPercent;
        private System.Windows.Forms.Label labelWaterPercent;
        private System.Windows.Forms.Label labelFirePercent;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCustomSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelForest;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label labelFire;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox canvasPreview;
        private System.Windows.Forms.Timer timerPreview;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.CheckBox checkBoxDrawGrid;
        private System.Windows.Forms.Button buttonGridColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelEnd;
        private System.Windows.Forms.Panel panelLogs;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonWater;
        private System.Windows.Forms.Button buttonForest;
        private System.Windows.Forms.Button buttonFlowPause;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFlowNormal;
        private System.Windows.Forms.Button buttonFlowFast;
        private System.Windows.Forms.Button buttonTick;
        private System.Windows.Forms.Button buttonFlowFastest;
        private System.Windows.Forms.Label labelWildPercent;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label labelWild;
        private System.Windows.Forms.RadioButton wildGeneration;
        private System.Windows.Forms.Button buttonWild;
        private System.Windows.Forms.NumericUpDown gameFireFades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown gameWaterLife;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown gameFloodChance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown gameForestSurvivability;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown gameTreesDrainWater;
    }
}

