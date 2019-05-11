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
            pictureBoxFigure.BackColor = Color.AliceBlue;
            pictureBoxPlane.BackColor = Color.AliceBlue;
        }

        //###########
        // Figure Code
        //###########

        Cylinder cylinder = new Cylinder(new Point3D(300, 0, 260), new Point3D(300, 100, 260), 50);
        Pen MainPen = new Pen(Color.Red, 2);
        Pen SecondaryPen = new Pen(Color.Green, 2);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButtonFrontViewFigure.Checked)
            {
                cylinder.DrawXY(MainPen, SecondaryPen, e);
            }
            else if (radioButtonViewAboveFigure.Checked)
            {
                cylinder.DrawXZ(MainPen, SecondaryPen, e);
            }
            else if (radioButtonViewSideFigure.Checked)
            {
                cylinder.DrawYZ(MainPen, SecondaryPen, e);
            }
            else if (radioButtonViewIsometryFigure.Checked)
            {
                cylinder.DrawIsometry(MainPen, SecondaryPen, e);
            }
        }

        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxFigure.BackColor = colorDialog1.Color;
            }
        }

        private void radioButtonFrontView_CheckedChanged(object sender, EventArgs e)
        {
            trackBarRotateOXFigure.Value = 0;
            trackBarRotateOYFigure.Value = 0;
            trackBarRotateOZFigure.Value = 0;
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBoxFigure.Refresh();
        }

        private void radioButtonViewAbove_CheckedChanged(object sender, EventArgs e)
        {
            trackBarRotateOXFigure.Value = 0;
            trackBarRotateOYFigure.Value = 0;
            trackBarRotateOZFigure.Value = 0;
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBoxFigure.Refresh();
        }

        private void radioButtonViewSide_CheckedChanged(object sender, EventArgs e)
        {
            trackBarRotateOXFigure.Value = 0;
            trackBarRotateOYFigure.Value = 0;
            trackBarRotateOZFigure.Value = 0;
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBoxFigure.Refresh();
        }

        private void radioButtonViewIsometry_CheckedChanged(object sender, EventArgs e)
        {
            trackBarRotateOXFigure.Value = 0;
            trackBarRotateOYFigure.Value = 0;
            trackBarRotateOZFigure.Value = 0;
            cylinder = new Cylinder(new Point3D(200, 0, 150), new Point3D(200, 100, 150), 50);
            pictureBoxFigure.Refresh();
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
            else if (radioButtonViewIsometryFigure.Checked)
            {
                cylinder.Move(Constants.UP);
            }
            pictureBoxFigure.Refresh();
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
            else if (radioButtonViewIsometryFigure.Checked)
            {
                cylinder.Move(Constants.DOWN);
            }
            pictureBoxFigure.Refresh();
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
            else if (radioButtonViewIsometryFigure.Checked)
            {
                cylinder.Move(Constants.LEFT);
            }
            pictureBoxFigure.Refresh();
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
            else if (radioButtonViewIsometryFigure.Checked)
            {
                cylinder.Move(Constants.RIGHT);
            }
            pictureBoxFigure.Refresh();
        }

        private void buttonScaleIncrease_Click(object sender, EventArgs e)
        {
            cylinder.Increase();
            pictureBoxFigure.Refresh();
        }

        private void buttonScaleDecrease_Click(object sender, EventArgs e)
        {
            cylinder.Decrease();
            pictureBoxFigure.Refresh();
        }

        private void trackBarRotateOX_Scroll(object sender, EventArgs e)
        {
            cylinder.Rotate(Constants.OX, trackBarRotateOXFigure.Value);
            pictureBoxFigure.Refresh();
        }

        private void trackBarRotateOY_Scroll(object sender, EventArgs e)
        {
            cylinder.Rotate(Constants.OY, trackBarRotateOYFigure.Value);
            pictureBoxFigure.Refresh();
        }

        private void trackBarRotateOZ_Scroll(object sender, EventArgs e)
        {
            cylinder.Rotate(Constants.OZ, trackBarRotateOZFigure.Value);
            pictureBoxFigure.Refresh();
        }



        //###########
        // Plane Code
        //###########

        private void buttonBackgroundColorPlane_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxPlane.BackColor = colorDialog1.Color;
            }
        }

    }
}
