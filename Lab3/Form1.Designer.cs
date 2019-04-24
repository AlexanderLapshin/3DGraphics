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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxCircle1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTrapeze1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTriangle1 = new System.Windows.Forms.CheckBox();
            this.checkBoxRectangle1 = new System.Windows.Forms.CheckBox();
            this.buttonBackgroundColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 652);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(339, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 673);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonBackgroundColor);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 673);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Use hotkeys to interact with figures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "I,J,K,L  --  Increase/Drcrease(X/Y) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "-,+  --  Decrease, Increase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Q,E  --  Rotate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "W,A,S,D  --  Move";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxCircle1);
            this.groupBox3.Controls.Add(this.checkBoxTrapeze1);
            this.groupBox3.Controls.Add(this.checkBoxTriangle1);
            this.groupBox3.Controls.Add(this.checkBoxRectangle1);
            this.groupBox3.Location = new System.Drawing.Point(27, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 106);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elements";
            // 
            // checkBoxCircle1
            // 
            this.checkBoxCircle1.AutoSize = true;
            this.checkBoxCircle1.Location = new System.Drawing.Point(144, 61);
            this.checkBoxCircle1.Name = "checkBoxCircle1";
            this.checkBoxCircle1.Size = new System.Drawing.Size(55, 21);
            this.checkBoxCircle1.TabIndex = 4;
            this.checkBoxCircle1.Text = "Sun";
            this.checkBoxCircle1.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrapeze1
            // 
            this.checkBoxTrapeze1.AutoSize = true;
            this.checkBoxTrapeze1.Location = new System.Drawing.Point(144, 21);
            this.checkBoxTrapeze1.Name = "checkBoxTrapeze1";
            this.checkBoxTrapeze1.Size = new System.Drawing.Size(71, 21);
            this.checkBoxTrapeze1.TabIndex = 3;
            this.checkBoxTrapeze1.Text = "Corma";
            this.checkBoxTrapeze1.UseVisualStyleBackColor = true;
            // 
            // checkBoxTriangle1
            // 
            this.checkBoxTriangle1.AutoSize = true;
            this.checkBoxTriangle1.Location = new System.Drawing.Point(19, 61);
            this.checkBoxTriangle1.Name = "checkBoxTriangle1";
            this.checkBoxTriangle1.Size = new System.Drawing.Size(77, 21);
            this.checkBoxTriangle1.TabIndex = 2;
            this.checkBoxTriangle1.Text = "Iceberg";
            this.checkBoxTriangle1.UseVisualStyleBackColor = true;
            // 
            // checkBoxRectangle1
            // 
            this.checkBoxRectangle1.AutoSize = true;
            this.checkBoxRectangle1.Location = new System.Drawing.Point(19, 21);
            this.checkBoxRectangle1.Name = "checkBoxRectangle1";
            this.checkBoxRectangle1.Size = new System.Drawing.Size(74, 21);
            this.checkBoxRectangle1.TabIndex = 0;
            this.checkBoxRectangle1.Text = "Paluba";
            this.checkBoxRectangle1.UseVisualStyleBackColor = true;
            // 
            // buttonBackgroundColor
            // 
            this.buttonBackgroundColor.Location = new System.Drawing.Point(90, 432);
            this.buttonBackgroundColor.Name = "buttonBackgroundColor";
            this.buttonBackgroundColor.Size = new System.Drawing.Size(152, 35);
            this.buttonBackgroundColor.TabIndex = 1;
            this.buttonBackgroundColor.Text = "Background Color";
            this.buttonBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonBackgroundColor.Click += new System.EventHandler(this.buttonBackgroundColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxRectangle1;
        private System.Windows.Forms.CheckBox checkBoxTriangle1;
        private System.Windows.Forms.CheckBox checkBoxTrapeze1;
        private System.Windows.Forms.CheckBox checkBoxCircle1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

