﻿namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxRotateFigure = new System.Windows.Forms.GroupBox();
            this.labelRotateOZFigure = new System.Windows.Forms.Label();
            this.labelRotateOYFigure = new System.Windows.Forms.Label();
            this.labelRotateOXFigure = new System.Windows.Forms.Label();
            this.trackBarRotateOZFigure = new System.Windows.Forms.TrackBar();
            this.trackBarRotateOYFigure = new System.Windows.Forms.TrackBar();
            this.trackBarRotateOXFigure = new System.Windows.Forms.TrackBar();
            this.groupBoxScaleFigure = new System.Windows.Forms.GroupBox();
            this.buttonScaleDecreaseFigure = new System.Windows.Forms.Button();
            this.buttonScaleIncreaseFigure = new System.Windows.Forms.Button();
            this.groupBoxMoveFigure = new System.Windows.Forms.GroupBox();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.groupBoxViewFigure = new System.Windows.Forms.GroupBox();
            this.radioButtonViewIsometryFigure = new System.Windows.Forms.RadioButton();
            this.radioButtonViewSideFigure = new System.Windows.Forms.RadioButton();
            this.radioButtonViewAboveFigure = new System.Windows.Forms.RadioButton();
            this.radioButtonFrontViewFigure = new System.Windows.Forms.RadioButton();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxScalePlane = new System.Windows.Forms.GroupBox();
            this.groupBoxMovePlane = new System.Windows.Forms.GroupBox();
            this.buttonMoveRightPlane = new System.Windows.Forms.Button();
            this.buttonMoveDownPlane = new System.Windows.Forms.Button();
            this.buttonMoveLeftPlane = new System.Windows.Forms.Button();
            this.buttonMoveUpPlane = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxRotateFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOZFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOYFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOXFigure)).BeginInit();
            this.groupBoxScaleFigure.SuspendLayout();
            this.groupBoxMoveFigure.SuspendLayout();
            this.groupBoxViewFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxMovePlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Figure";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxRotateFigure);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxScaleFigure);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMoveFigure);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxViewFigure);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackground);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(874, 521);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxRotateFigure
            // 
            this.groupBoxRotateFigure.Controls.Add(this.labelRotateOZFigure);
            this.groupBoxRotateFigure.Controls.Add(this.labelRotateOYFigure);
            this.groupBoxRotateFigure.Controls.Add(this.labelRotateOXFigure);
            this.groupBoxRotateFigure.Controls.Add(this.trackBarRotateOZFigure);
            this.groupBoxRotateFigure.Controls.Add(this.trackBarRotateOYFigure);
            this.groupBoxRotateFigure.Controls.Add(this.trackBarRotateOXFigure);
            this.groupBoxRotateFigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRotateFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRotateFigure.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxRotateFigure.Location = new System.Drawing.Point(0, 283);
            this.groupBoxRotateFigure.Name = "groupBoxRotateFigure";
            this.groupBoxRotateFigure.Size = new System.Drawing.Size(279, 213);
            this.groupBoxRotateFigure.TabIndex = 4;
            this.groupBoxRotateFigure.TabStop = false;
            this.groupBoxRotateFigure.Text = "Rotate";
            // 
            // labelRotateOZFigure
            // 
            this.labelRotateOZFigure.AutoSize = true;
            this.labelRotateOZFigure.Location = new System.Drawing.Point(15, 164);
            this.labelRotateOZFigure.Name = "labelRotateOZFigure";
            this.labelRotateOZFigure.Size = new System.Drawing.Size(82, 16);
            this.labelRotateOZFigure.TabIndex = 5;
            this.labelRotateOZFigure.Text = "Rotate OZ:";
            // 
            // labelRotateOYFigure
            // 
            this.labelRotateOYFigure.AutoSize = true;
            this.labelRotateOYFigure.Location = new System.Drawing.Point(16, 103);
            this.labelRotateOYFigure.Name = "labelRotateOYFigure";
            this.labelRotateOYFigure.Size = new System.Drawing.Size(83, 16);
            this.labelRotateOYFigure.TabIndex = 4;
            this.labelRotateOYFigure.Text = "Rotate OY:";
            // 
            // labelRotateOXFigure
            // 
            this.labelRotateOXFigure.AutoSize = true;
            this.labelRotateOXFigure.Location = new System.Drawing.Point(16, 43);
            this.labelRotateOXFigure.Name = "labelRotateOXFigure";
            this.labelRotateOXFigure.Size = new System.Drawing.Size(82, 16);
            this.labelRotateOXFigure.TabIndex = 3;
            this.labelRotateOXFigure.Text = "Rotate OX:";
            // 
            // trackBarRotateOZFigure
            // 
            this.trackBarRotateOZFigure.BackColor = System.Drawing.Color.White;
            this.trackBarRotateOZFigure.Location = new System.Drawing.Point(129, 152);
            this.trackBarRotateOZFigure.Maximum = 360;
            this.trackBarRotateOZFigure.Name = "trackBarRotateOZFigure";
            this.trackBarRotateOZFigure.Size = new System.Drawing.Size(142, 45);
            this.trackBarRotateOZFigure.TabIndex = 2;
            this.trackBarRotateOZFigure.TickFrequency = 30;
            this.trackBarRotateOZFigure.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRotateOZFigure.Scroll += new System.EventHandler(this.trackBarRotateOZ_Scroll);
            // 
            // trackBarRotateOYFigure
            // 
            this.trackBarRotateOYFigure.BackColor = System.Drawing.Color.White;
            this.trackBarRotateOYFigure.Location = new System.Drawing.Point(129, 90);
            this.trackBarRotateOYFigure.Maximum = 360;
            this.trackBarRotateOYFigure.Name = "trackBarRotateOYFigure";
            this.trackBarRotateOYFigure.Size = new System.Drawing.Size(142, 45);
            this.trackBarRotateOYFigure.TabIndex = 1;
            this.trackBarRotateOYFigure.TickFrequency = 30;
            this.trackBarRotateOYFigure.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRotateOYFigure.Scroll += new System.EventHandler(this.trackBarRotateOY_Scroll);
            // 
            // trackBarRotateOXFigure
            // 
            this.trackBarRotateOXFigure.BackColor = System.Drawing.Color.White;
            this.trackBarRotateOXFigure.Location = new System.Drawing.Point(129, 28);
            this.trackBarRotateOXFigure.Maximum = 360;
            this.trackBarRotateOXFigure.Name = "trackBarRotateOXFigure";
            this.trackBarRotateOXFigure.Size = new System.Drawing.Size(142, 45);
            this.trackBarRotateOXFigure.TabIndex = 0;
            this.trackBarRotateOXFigure.TickFrequency = 30;
            this.trackBarRotateOXFigure.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRotateOXFigure.Scroll += new System.EventHandler(this.trackBarRotateOX_Scroll);
            // 
            // groupBoxScaleFigure
            // 
            this.groupBoxScaleFigure.Controls.Add(this.buttonScaleDecreaseFigure);
            this.groupBoxScaleFigure.Controls.Add(this.buttonScaleIncreaseFigure);
            this.groupBoxScaleFigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxScaleFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxScaleFigure.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxScaleFigure.Location = new System.Drawing.Point(0, 200);
            this.groupBoxScaleFigure.Name = "groupBoxScaleFigure";
            this.groupBoxScaleFigure.Size = new System.Drawing.Size(279, 83);
            this.groupBoxScaleFigure.TabIndex = 3;
            this.groupBoxScaleFigure.TabStop = false;
            this.groupBoxScaleFigure.Text = "Scale";
            // 
            // buttonScaleDecreaseFigure
            // 
            this.buttonScaleDecreaseFigure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonScaleDecreaseFigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScaleDecreaseFigure.Location = new System.Drawing.Point(155, 42);
            this.buttonScaleDecreaseFigure.Name = "buttonScaleDecreaseFigure";
            this.buttonScaleDecreaseFigure.Size = new System.Drawing.Size(85, 28);
            this.buttonScaleDecreaseFigure.TabIndex = 1;
            this.buttonScaleDecreaseFigure.Text = "Decrease";
            this.buttonScaleDecreaseFigure.UseVisualStyleBackColor = true;
            this.buttonScaleDecreaseFigure.Click += new System.EventHandler(this.buttonScaleDecrease_Click);
            // 
            // buttonScaleIncreaseFigure
            // 
            this.buttonScaleIncreaseFigure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonScaleIncreaseFigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScaleIncreaseFigure.Location = new System.Drawing.Point(29, 42);
            this.buttonScaleIncreaseFigure.Name = "buttonScaleIncreaseFigure";
            this.buttonScaleIncreaseFigure.Size = new System.Drawing.Size(85, 28);
            this.buttonScaleIncreaseFigure.TabIndex = 0;
            this.buttonScaleIncreaseFigure.Text = "Increase";
            this.buttonScaleIncreaseFigure.UseVisualStyleBackColor = true;
            this.buttonScaleIncreaseFigure.Click += new System.EventHandler(this.buttonScaleIncrease_Click);
            // 
            // groupBoxMoveFigure
            // 
            this.groupBoxMoveFigure.Controls.Add(this.buttonMoveDown);
            this.groupBoxMoveFigure.Controls.Add(this.buttonMoveLeft);
            this.groupBoxMoveFigure.Controls.Add(this.buttonMoveRight);
            this.groupBoxMoveFigure.Controls.Add(this.buttonMoveUp);
            this.groupBoxMoveFigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMoveFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMoveFigure.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxMoveFigure.Location = new System.Drawing.Point(0, 100);
            this.groupBoxMoveFigure.Name = "groupBoxMoveFigure";
            this.groupBoxMoveFigure.Size = new System.Drawing.Size(279, 100);
            this.groupBoxMoveFigure.TabIndex = 2;
            this.groupBoxMoveFigure.TabStop = false;
            this.groupBoxMoveFigure.Text = "Move";
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveDown.Location = new System.Drawing.Point(103, 62);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveDown.TabIndex = 3;
            this.buttonMoveDown.Text = "Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveLeft.Location = new System.Drawing.Point(18, 62);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveLeft.TabIndex = 2;
            this.buttonMoveLeft.Text = "Left";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveRight.Location = new System.Drawing.Point(195, 62);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveRight.TabIndex = 1;
            this.buttonMoveRight.Text = "Right";
            this.buttonMoveRight.UseVisualStyleBackColor = false;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveUp.Location = new System.Drawing.Point(103, 21);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveUp.TabIndex = 0;
            this.buttonMoveUp.Text = "Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // groupBoxViewFigure
            // 
            this.groupBoxViewFigure.Controls.Add(this.radioButtonViewIsometryFigure);
            this.groupBoxViewFigure.Controls.Add(this.radioButtonViewSideFigure);
            this.groupBoxViewFigure.Controls.Add(this.radioButtonViewAboveFigure);
            this.groupBoxViewFigure.Controls.Add(this.radioButtonFrontViewFigure);
            this.groupBoxViewFigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxViewFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxViewFigure.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxViewFigure.Location = new System.Drawing.Point(0, 0);
            this.groupBoxViewFigure.Name = "groupBoxViewFigure";
            this.groupBoxViewFigure.Size = new System.Drawing.Size(279, 100);
            this.groupBoxViewFigure.TabIndex = 1;
            this.groupBoxViewFigure.TabStop = false;
            this.groupBoxViewFigure.Text = "View";
            // 
            // radioButtonViewIsometryFigure
            // 
            this.radioButtonViewIsometryFigure.AutoSize = true;
            this.radioButtonViewIsometryFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonViewIsometryFigure.Location = new System.Drawing.Point(140, 60);
            this.radioButtonViewIsometryFigure.Name = "radioButtonViewIsometryFigure";
            this.radioButtonViewIsometryFigure.Size = new System.Drawing.Size(79, 19);
            this.radioButtonViewIsometryFigure.TabIndex = 3;
            this.radioButtonViewIsometryFigure.Text = "Isometry";
            this.radioButtonViewIsometryFigure.UseVisualStyleBackColor = true;
            this.radioButtonViewIsometryFigure.CheckedChanged += new System.EventHandler(this.radioButtonViewIsometry_CheckedChanged);
            // 
            // radioButtonViewSideFigure
            // 
            this.radioButtonViewSideFigure.AutoSize = true;
            this.radioButtonViewSideFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonViewSideFigure.Location = new System.Drawing.Point(40, 60);
            this.radioButtonViewSideFigure.Name = "radioButtonViewSideFigure";
            this.radioButtonViewSideFigure.Size = new System.Drawing.Size(54, 19);
            this.radioButtonViewSideFigure.TabIndex = 2;
            this.radioButtonViewSideFigure.Text = "Side";
            this.radioButtonViewSideFigure.UseVisualStyleBackColor = true;
            this.radioButtonViewSideFigure.CheckedChanged += new System.EventHandler(this.radioButtonViewSide_CheckedChanged);
            // 
            // radioButtonViewAboveFigure
            // 
            this.radioButtonViewAboveFigure.AutoSize = true;
            this.radioButtonViewAboveFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonViewAboveFigure.Location = new System.Drawing.Point(140, 25);
            this.radioButtonViewAboveFigure.Name = "radioButtonViewAboveFigure";
            this.radioButtonViewAboveFigure.Size = new System.Drawing.Size(100, 19);
            this.radioButtonViewAboveFigure.TabIndex = 1;
            this.radioButtonViewAboveFigure.Text = "From Above";
            this.radioButtonViewAboveFigure.UseVisualStyleBackColor = true;
            this.radioButtonViewAboveFigure.CheckedChanged += new System.EventHandler(this.radioButtonViewAbove_CheckedChanged);
            // 
            // radioButtonFrontViewFigure
            // 
            this.radioButtonFrontViewFigure.AutoSize = true;
            this.radioButtonFrontViewFigure.Checked = true;
            this.radioButtonFrontViewFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFrontViewFigure.Location = new System.Drawing.Point(40, 25);
            this.radioButtonFrontViewFigure.Name = "radioButtonFrontViewFigure";
            this.radioButtonFrontViewFigure.Size = new System.Drawing.Size(58, 19);
            this.radioButtonFrontViewFigure.TabIndex = 0;
            this.radioButtonFrontViewFigure.TabStop = true;
            this.radioButtonFrontViewFigure.Text = "Front";
            this.radioButtonFrontViewFigure.UseVisualStyleBackColor = true;
            this.radioButtonFrontViewFigure.CheckedChanged += new System.EventHandler(this.radioButtonFrontView_CheckedChanged);
            // 
            // buttonBackground
            // 
            this.buttonBackground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackground.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonBackground.Location = new System.Drawing.Point(0, 496);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(279, 25);
            this.buttonBackground.TabIndex = 0;
            this.buttonBackground.Text = "Background Color";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackgroundColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plane";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxScalePlane);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxMovePlane);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Size = new System.Drawing.Size(874, 521);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.TabIndex = 3;
            // 
            // groupBoxScalePlane
            // 
            this.groupBoxScalePlane.Location = new System.Drawing.Point(18, 121);
            this.groupBoxScalePlane.Name = "groupBoxScalePlane";
            this.groupBoxScalePlane.Size = new System.Drawing.Size(200, 100);
            this.groupBoxScalePlane.TabIndex = 0;
            this.groupBoxScalePlane.TabStop = false;
            // 
            // groupBoxMovePlane
            // 
            this.groupBoxMovePlane.Controls.Add(this.buttonMoveRightPlane);
            this.groupBoxMovePlane.Controls.Add(this.buttonMoveDownPlane);
            this.groupBoxMovePlane.Controls.Add(this.buttonMoveLeftPlane);
            this.groupBoxMovePlane.Controls.Add(this.buttonMoveUpPlane);
            this.groupBoxMovePlane.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMovePlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMovePlane.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxMovePlane.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMovePlane.Name = "groupBoxMovePlane";
            this.groupBoxMovePlane.Size = new System.Drawing.Size(291, 115);
            this.groupBoxMovePlane.TabIndex = 2;
            this.groupBoxMovePlane.TabStop = false;
            this.groupBoxMovePlane.Text = "Move";
            // 
            // buttonMoveRightPlane
            // 
            this.buttonMoveRightPlane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveRightPlane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveRightPlane.Location = new System.Drawing.Point(195, 62);
            this.buttonMoveRightPlane.Name = "buttonMoveRightPlane";
            this.buttonMoveRightPlane.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveRightPlane.TabIndex = 1;
            this.buttonMoveRightPlane.Text = "Right";
            this.buttonMoveRightPlane.UseVisualStyleBackColor = false;
            // 
            // buttonMoveDownPlane
            // 
            this.buttonMoveDownPlane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveDownPlane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveDownPlane.Location = new System.Drawing.Point(103, 62);
            this.buttonMoveDownPlane.Name = "buttonMoveDownPlane";
            this.buttonMoveDownPlane.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveDownPlane.TabIndex = 3;
            this.buttonMoveDownPlane.Text = "Down";
            this.buttonMoveDownPlane.UseVisualStyleBackColor = true;
            // 
            // buttonMoveLeftPlane
            // 
            this.buttonMoveLeftPlane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveLeftPlane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveLeftPlane.Location = new System.Drawing.Point(18, 62);
            this.buttonMoveLeftPlane.Name = "buttonMoveLeftPlane";
            this.buttonMoveLeftPlane.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveLeftPlane.TabIndex = 2;
            this.buttonMoveLeftPlane.Text = "Left";
            this.buttonMoveLeftPlane.UseVisualStyleBackColor = true;
            // 
            // buttonMoveUpPlane
            // 
            this.buttonMoveUpPlane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMoveUpPlane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveUpPlane.Location = new System.Drawing.Point(103, 21);
            this.buttonMoveUpPlane.Name = "buttonMoveUpPlane";
            this.buttonMoveUpPlane.Size = new System.Drawing.Size(75, 28);
            this.buttonMoveUpPlane.TabIndex = 0;
            this.buttonMoveUpPlane.Text = "Up";
            this.buttonMoveUpPlane.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(579, 374);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 553);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(904, 592);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(904, 592);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxRotateFigure.ResumeLayout(false);
            this.groupBoxRotateFigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOZFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOYFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOXFigure)).EndInit();
            this.groupBoxScaleFigure.ResumeLayout(false);
            this.groupBoxMoveFigure.ResumeLayout(false);
            this.groupBoxViewFigure.ResumeLayout(false);
            this.groupBoxViewFigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxMovePlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.GroupBox groupBoxViewFigure;
        private System.Windows.Forms.RadioButton radioButtonViewIsometryFigure;
        private System.Windows.Forms.RadioButton radioButtonViewSideFigure;
        private System.Windows.Forms.RadioButton radioButtonViewAboveFigure;
        private System.Windows.Forms.RadioButton radioButtonFrontViewFigure;
        private System.Windows.Forms.GroupBox groupBoxRotateFigure;
        private System.Windows.Forms.Label labelRotateOZFigure;
        private System.Windows.Forms.Label labelRotateOYFigure;
        private System.Windows.Forms.Label labelRotateOXFigure;
        private System.Windows.Forms.TrackBar trackBarRotateOZFigure;
        private System.Windows.Forms.TrackBar trackBarRotateOYFigure;
        private System.Windows.Forms.TrackBar trackBarRotateOXFigure;
        private System.Windows.Forms.GroupBox groupBoxScaleFigure;
        private System.Windows.Forms.Button buttonScaleDecreaseFigure;
        private System.Windows.Forms.Button buttonScaleIncreaseFigure;
        private System.Windows.Forms.GroupBox groupBoxMoveFigure;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxMovePlane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxScalePlane;
        private System.Windows.Forms.Button buttonMoveRightPlane;
        private System.Windows.Forms.Button buttonMoveDownPlane;
        private System.Windows.Forms.Button buttonMoveLeftPlane;
        private System.Windows.Forms.Button buttonMoveUpPlane;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
