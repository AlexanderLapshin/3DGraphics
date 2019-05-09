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
            if (radioButtonFrontView.Checked)
            {
                cylinder.DrawXY(Pens.Red, Pens.Green, e);
            }
            else if (radioButtonViewAbove.Checked)
            {
                cylinder.DrawXZ(Pens.Red, Pens.Green, e);
            }
            else if (radioButtonViewSide.Checked)
            {
                cylinder.DrawYZ(Pens.Red, Pens.Green, e);
            }
            else if (radioButtonViewIsometry.Checked)
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
            if (radioButtonFrontView.Checked)
            {
                cylinder.Move(Constants.UP);
            }
            else if (radioButtonViewAbove.Checked)
            {
                cylinder.Move(Constants.BACK);
            }
            else if (radioButtonViewSide.Checked)
            {
                cylinder.Move(Constants.BACK);
            }
            pictureBox1.Refresh();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontView.Checked)
            {
                cylinder.Move(Constants.DOWN);
            }
            else if (radioButtonViewAbove.Checked)
            {
                cylinder.Move(Constants.FORWARD);
            }
            else if (radioButtonViewSide.Checked)
            {
                cylinder.Move(Constants.FORWARD);
            }
            pictureBox1.Refresh();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontView.Checked)
            {
                cylinder.Move(Constants.LEFT);
            }
            else if (radioButtonViewAbove.Checked)
            {
                cylinder.Move(Constants.LEFT);
            }
            else if (radioButtonViewSide.Checked)
            {
                cylinder.Move(Constants.UP);
            }
            pictureBox1.Refresh();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontView.Checked)
            {
                cylinder.Move(Constants.RIGHT);
            }
            else if (radioButtonViewAbove.Checked)
            {
                cylinder.Move(Constants.RIGHT);
            }
            else if (radioButtonViewSide.Checked)
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
            cylinder.Rotate(Constants.OXLEFT);
        }
    }
}
