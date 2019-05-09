namespace Lab3
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRotateOZ = new System.Windows.Forms.TrackBar();
            this.trackBarRotateOY = new System.Windows.Forms.TrackBar();
            this.trackBarRotateOX = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonScaleDecrease = new System.Windows.Forms.Button();
            this.buttonScaleIncrease = new System.Windows.Forms.Button();
            this.groupBoxMove = new System.Windows.Forms.GroupBox();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.radioButtonViewIsometry = new System.Windows.Forms.RadioButton();
            this.radioButtonViewSide = new System.Windows.Forms.RadioButton();
            this.radioButtonViewAbove = new System.Windows.Forms.RadioButton();
            this.radioButtonFrontView = new System.Windows.Forms.RadioButton();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxMove.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMove);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxView);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackground);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(874, 521);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.trackBarRotateOZ);
            this.groupBox3.Controls.Add(this.trackBarRotateOY);
            this.groupBox3.Controls.Add(this.trackBarRotateOX);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(0, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 213);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rotate OZ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rotate OY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rotate OX:";
            // 
            // trackBarRotateOZ
            // 
            this.trackBarRotateOZ.Location = new System.Drawing.Point(129, 152);
            this.trackBarRotateOZ.Maximum = 360;
            this.trackBarRotateOZ.Name = "trackBarRotateOZ";
            this.trackBarRotateOZ.Size = new System.Drawing.Size(142, 45);
            this.trackBarRotateOZ.TabIndex = 2;
            this.trackBarRotateOZ.TickFrequency = 30;
            this.trackBarRotateOZ.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBarRotateOY
            // 
            this.trackBarRotateOY.Location = new System.Drawing.Point(129, 90);
            this.trackBarRotateOY.Maximum = 360;
            this.trackBarRotateOY.Name = "trackBarRotateOY";
            this.trackBarRotateOY.Size = new System.Drawing.Size(142, 45);
            this.trackBarRotateOY.TabIndex = 1;
            this.trackBarRotateOY.TickFrequency = 30;
            this.trackBarRotateOY.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBarRotateOX
            // 
            this.trackBarRotateOX.Location = new System.Drawing.Point(129, 28);
            this.trackBarRotateOX.Maximum = 360;
            this.trackBarRotateOX.Name = "trackBarRotateOX";
            this.trackBarRotateOX.Size = new System.Drawing.Size(142, 45);
            this.trackBarRotateOX.TabIndex = 0;
            this.trackBarRotateOX.TickFrequency = 30;
            this.trackBarRotateOX.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRotateOX.Scroll += new System.EventHandler(this.trackBarRotateOX_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonScaleDecrease);
            this.groupBox2.Controls.Add(this.buttonScaleIncrease);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scale";
            // 
            // buttonScaleDecrease
            // 
            this.buttonScaleDecrease.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonScaleDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScaleDecrease.Location = new System.Drawing.Point(155, 42);
            this.buttonScaleDecrease.Name = "buttonScaleDecrease";
            this.buttonScaleDecrease.Size = new System.Drawing.Size(85, 28);
            this.buttonScaleDecrease.TabIndex = 1;
            this.buttonScaleDecrease.Text = "Decrease";
            this.buttonScaleDecrease.UseVisualStyleBackColor = true;
            this.buttonScaleDecrease.Click += new System.EventHandler(this.buttonScaleDecrease_Click);
            // 
            // buttonScaleIncrease
            // 
            this.buttonScaleIncrease.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonScaleIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScaleIncrease.Location = new System.Drawing.Point(29, 42);
            this.buttonScaleIncrease.Name = "buttonScaleIncrease";
            this.buttonScaleIncrease.Size = new System.Drawing.Size(85, 28);
            this.buttonScaleIncrease.TabIndex = 0;
            this.buttonScaleIncrease.Text = "Increase";
            this.buttonScaleIncrease.UseVisualStyleBackColor = true;
            this.buttonScaleIncrease.Click += new System.EventHandler(this.buttonScaleIncrease_Click);
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.Controls.Add(this.buttonMoveDown);
            this.groupBoxMove.Controls.Add(this.buttonMoveLeft);
            this.groupBoxMove.Controls.Add(this.buttonMoveRight);
            this.groupBoxMove.Controls.Add(this.buttonMoveUp);
            this.groupBoxMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMove.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxMove.Location = new System.Drawing.Point(0, 100);
            this.groupBoxMove.Name = "groupBoxMove";
            this.groupBoxMove.Size = new System.Drawing.Size(279, 100);
            this.groupBoxMove.TabIndex = 2;
            this.groupBoxMove.TabStop = false;
            this.groupBoxMove.Text = "Move";
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
            // groupBoxView
            // 
            this.groupBoxView.Controls.Add(this.radioButtonViewIsometry);
            this.groupBoxView.Controls.Add(this.radioButtonViewSide);
            this.groupBoxView.Controls.Add(this.radioButtonViewAbove);
            this.groupBoxView.Controls.Add(this.radioButtonFrontView);
            this.groupBoxView.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxView.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxView.Location = new System.Drawing.Point(0, 0);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(279, 100);
            this.groupBoxView.TabIndex = 1;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "View";
            // 
            // radioButtonViewIsometry
            // 
            this.radioButtonViewIsometry.AutoSize = true;
            this.radioButtonViewIsometry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonViewIsometry.Location = new System.Drawing.Point(140, 60);
            this.radioButtonViewIsometry.Name = "radioButtonViewIsometry";
            this.radioButtonViewIsometry.Size = new System.Drawing.Size(79, 19);
            this.radioButtonViewIsometry.TabIndex = 3;
            this.radioButtonViewIsometry.Text = "Isometry";
            this.radioButtonViewIsometry.UseVisualStyleBackColor = true;
            this.radioButtonViewIsometry.CheckedChanged += new System.EventHandler(this.radioButtonViewIsometry_CheckedChanged);
            // 
            // radioButtonViewSide
            // 
            this.radioButtonViewSide.AutoSize = true;
            this.radioButtonViewSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonViewSide.Location = new System.Drawing.Point(40, 60);
            this.radioButtonViewSide.Name = "radioButtonViewSide";
            this.radioButtonViewSide.Size = new System.Drawing.Size(54, 19);
            this.radioButtonViewSide.TabIndex = 2;
            this.radioButtonViewSide.Text = "Side";
            this.radioButtonViewSide.UseVisualStyleBackColor = true;
            this.radioButtonViewSide.CheckedChanged += new System.EventHandler(this.radioButtonViewSide_CheckedChanged);
            // 
            // radioButtonViewAbove
            // 
            this.radioButtonViewAbove.AutoSize = true;
            this.radioButtonViewAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonViewAbove.Location = new System.Drawing.Point(140, 25);
            this.radioButtonViewAbove.Name = "radioButtonViewAbove";
            this.radioButtonViewAbove.Size = new System.Drawing.Size(100, 19);
            this.radioButtonViewAbove.TabIndex = 1;
            this.radioButtonViewAbove.Text = "From Above";
            this.radioButtonViewAbove.UseVisualStyleBackColor = true;
            this.radioButtonViewAbove.CheckedChanged += new System.EventHandler(this.radioButtonViewAbove_CheckedChanged);
            // 
            // radioButtonFrontView
            // 
            this.radioButtonFrontView.AutoSize = true;
            this.radioButtonFrontView.Checked = true;
            this.radioButtonFrontView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFrontView.Location = new System.Drawing.Point(40, 25);
            this.radioButtonFrontView.Name = "radioButtonFrontView";
            this.radioButtonFrontView.Size = new System.Drawing.Size(58, 19);
            this.radioButtonFrontView.TabIndex = 0;
            this.radioButtonFrontView.TabStop = true;
            this.radioButtonFrontView.Text = "Front";
            this.radioButtonFrontView.UseVisualStyleBackColor = true;
            this.radioButtonFrontView.CheckedChanged += new System.EventHandler(this.radioButtonFrontView_CheckedChanged);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateOX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxMove.ResumeLayout(false);
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.RadioButton radioButtonViewIsometry;
        private System.Windows.Forms.RadioButton radioButtonViewSide;
        private System.Windows.Forms.RadioButton radioButtonViewAbove;
        private System.Windows.Forms.RadioButton radioButtonFrontView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarRotateOZ;
        private System.Windows.Forms.TrackBar trackBarRotateOY;
        private System.Windows.Forms.TrackBar trackBarRotateOX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonScaleDecrease;
        private System.Windows.Forms.Button buttonScaleIncrease;
        private System.Windows.Forms.GroupBox groupBoxMove;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveUp;
    }
}
