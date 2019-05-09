using Lab3.Figures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.AliceBlue;
        }

        Cylinder cylinder = new Cylinder(new Point3D(300, 0, 260), new Point3D(300, 100, 260), 50);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButtonFrontViewFigure.Checked)
            {
                cylinder.DrawXY(Pens.Red, Pens.Green, e);
            }
            else if (radioButtonViewAboveFigure.Checked)
            {
                cylinder.DrawXZ(Pens.Red, Pens.Green, e);
            }
            else if (radioButtonViewSideFigure.Checked)
            {
                cylinder.DrawYZ(Pens.Red, Pens.Green, e);
            }
            else if (radioButtonViewIsometryFigure.Checked)
            {
                cylinder.DrawIsometry(Pens.Red, Pens.Green, e);
            }
        }

        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }

        }

        private void radioButtonFrontView_CheckedChanged(object sender, EventArgs e)
        {
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBox1.Refresh();
        }

        private void radioButtonViewAbove_CheckedChanged(object sender, EventArgs e)
        {
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBox1.Refresh();
        }

        private void radioButtonViewSide_CheckedChanged(object sender, EventArgs e)
        {
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBox1.Refresh();
        }

        private void radioButtonViewIsometry_CheckedChanged(object sender, EventArgs e)
        {
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBox1.Refresh();
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewFigure.Checked)
            {
                cylinder.Move(Constants.UP);
            }
            else if (radioButtonViewAboveFigure.Checked)
            {
                cylinder.Move(Constants.BACK);
            }
            else if (radioButtonViewSideFigure.Checked)
            {
                cylinder.Move(Constants.BACK);
            }
            pictureBox1.Refresh();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewFigure.Checked)
            {
                cylinder.Move(Constants.DOWN);
            }
            else if (radioButtonViewAboveFigure.Checked)
            {
                cylinder.Move(Constants.FORWARD);
            }
            else if (radioButtonViewSideFigure.Checked)
            {
                cylinder.Move(Constants.FORWARD);
            }
            pictureBox1.Refresh();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewFigure.Checked)
            {
                cylinder.Move(Constants.LEFT);
            }
            else if (radioButtonViewAboveFigure.Checked)
            {
                cylinder.Move(Constants.LEFT);
            }
            else if (radioButtonViewSideFigure.Checked)
            {
                cylinder.Move(Constants.UP);
            }
            pictureBox1.Refresh();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewFigure.Checked)
            {
                cylinder.Move(Constants.RIGHT);
            }
            else if (radioButtonViewAboveFigure.Checked)
            {
                cylinder.Move(Constants.RIGHT);
            }
            else if (radioButtonViewSideFigure.Checked)
            {
                cylinder.Move(Constants.DOWN);
            }
            pictureBox1.Refresh();
        }

        private void buttonScaleIncrease_Click(object sender, EventArgs e)
        {
            cylinder.Increase();
            pictureBox1.Refresh();
        }

        private void buttonScaleDecrease_Click(object sender, EventArgs e)
        {
            cylinder.Decrease();
            pictureBox1.Refresh();
        }

        private void trackBarRotateOX_Scroll(object sender, EventArgs e)
        {
            cylinder.Rotate(Constants.OX, trackBarRotateOXFigure.Value);
            pictureBox1.Refresh();
        }

        private void trackBarRotateOY_Scroll(object sender, EventArgs e)
        {
            cylinder.Rotate(Constants.OY, trackBarRotateOYFigure.Value);
            pictureBox1.Refresh();
        }

        private void trackBarRotateOZ_Scroll(object sender, EventArgs e)
        {
            cylinder.Rotate(Constants.OZ, trackBarRotateOZFigure.Value);
            pictureBox1.Refresh();
        }
    }
}
