using Lab3.Figures;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        // Figure data
        Cylinder cylinder = new Cylinder(new Point3D(300, 0, 260), new Point3D(300, 100, 260), 50);
        Pen MainPen = new Pen(Color.Red, 2);
        Pen SecondaryPen = new Pen(Color.Green, 2);

        // Plane data
        Bezier bezier;
        Point3D[,] bezierPoints;
        int size = 4;
        bool updatingData = true;

        public Form1()
        {
            InitializeComponent();
            pictureBoxFigure.BackColor = Color.AliceBlue;
            pictureBoxPlane.BackColor = Color.AliceBlue;


            int height = 200;
            int width = 200;
            int z = 50;

            dataGridViewPlane.RowTemplate.Height = 29;
            dataGridViewPlane.ColumnCount = size;
            dataGridViewPlane.RowCount = size;

            numericUpDownXPlane.Value = height;
            numericUpDownYPlane.Value = width;
            numericUpDownZPlane.Value = 0;

            bezierPoints = new Point3D[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    dataGridViewPlane.Rows[i].Cells[j].Value = string.Format("({0};{1};{2})", width, z, height);
                    bezierPoints[i, j] = new Point3D(width, z, height);
                    width += 50;
                }
                width = 200;
                height += 50;
            }

            bezier = new Bezier(bezierPoints);
            updatingData = false;
        }

        //###########
        // Figure Code
        //###########

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButtonFrontViewFigure.Checked)
            {
                cylinder.DrawXY(MainPen, SecondaryPen, e);
            }
            else if (radioButtonViewAboveFigure.Checked)
            {
                cylinder.DrawYZ(MainPen, SecondaryPen, e);
            }
            else if (radioButtonViewSideFigure.Checked)
            {
                cylinder.DrawXZ(MainPen, SecondaryPen, e);
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
            resetPositionFigure();
        }

        private void radioButtonViewAbove_CheckedChanged(object sender, EventArgs e)
        {
            resetPositionFigure();
        }

        private void radioButtonViewSide_CheckedChanged(object sender, EventArgs e)
        {
            resetPositionFigure();
        }

        private void radioButtonViewIsometry_CheckedChanged(object sender, EventArgs e)
        {
            resetPositionFigure();
        }

        private void resetPositionFigure()
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
                cylinder.Move(Constants.BACK);
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
                cylinder.Move(Constants.FORWARD);
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

        private void trackBarAllAxisFigure_Scroll(object sender, EventArgs e)
        {
            if (checkBoxRotateOXFigure.Checked)
            {
                cylinder.Rotate(Constants.OX, trackBarAllAxisFigure.Value);
            }
            if (checkBoxRotateOYFigure.Checked)
            {
                cylinder.Rotate(Constants.OY, trackBarAllAxisFigure.Value);
            }
            if (checkBoxRotateOZFigure.Checked)
            {
                cylinder.Rotate(Constants.OZ, trackBarAllAxisFigure.Value);
            }
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

        private void pictureBoxPlane_Paint(object sender, PaintEventArgs e)
        {
            if (radioButtonFrontViewPlane.Checked)
            {
                bezier.DrawXY(Pens.Red, Pens.Blue, e);
            }
            else if (radioButtonAboveViewPlane.Checked)
            {
                bezier.DrawYZ(Pens.Red, Pens.Blue, e);
            }
            else if (radioButtonSideViewPlane.Checked)
            {
                bezier.DrawXZ(Pens.Red, Pens.Blue, e);
            }
            else if (radioButtonIsometryViewPlane.Checked)
            {
                bezier.DrawIsometry(Pens.Red, Pens.Blue, e);
            }
        }

        private void radioButtonFrontViewPlane_CheckedChanged(object sender, EventArgs e)
        {
            resetPositionPlane();
        }

        private void radioButtonAboveViewPlane_CheckedChanged(object sender, EventArgs e)
        {
            resetPositionPlane();
        }

        private void radioButtonSideViewPlane_CheckedChanged(object sender, EventArgs e)
        {
            resetPositionPlane();
        }

        private void radioButtonIsometryViewPlane_CheckedChanged(object sender, EventArgs e)
        {
            resetPositionPlane();
        }

        private void resetPositionPlane()
        {
            trackBarRotateOXPlane.Value = 0;
            trackBarRotateOYPlane.Value = 0;
            trackBarRotateOZPlane.Value = 0;
            bezier = new Bezier(bezierPoints);
            pictureBoxPlane.Refresh();
        }

        private void resetPlanePoints()
        {
            int height = 200;
            int width = 200;
            int z = 50;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    dataGridViewPlane.Rows[i].Cells[j].Value = string.Format("({0};{1};{2})", width, height, z);
                    bezierPoints[i, j] = new Point3D(width, height, z);
                    width += 50;
                }
                width = 200;
                height += 50;
            }
        }

        private void buttonMoveUpPlane_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewPlane.Checked)
            {
                bezier.Move(Constants.UP);
            }
            else if (radioButtonAboveViewPlane.Checked)
            {
                bezier.Move(Constants.BACK);
            }
            else if (radioButtonSideViewPlane.Checked)
            {
                bezier.Move(Constants.BACK);
            }
            else if (radioButtonIsometryViewPlane.Checked)
            {
                bezier.Move(Constants.BACK);
            }
            pictureBoxPlane.Refresh();
        }

        private void buttonMoveDownPlane_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewPlane.Checked)
            {
                bezier.Move(Constants.DOWN);
            }
            else if (radioButtonAboveViewPlane.Checked)
            {
                bezier.Move(Constants.FORWARD);
            }
            else if (radioButtonSideViewPlane.Checked)
            {
                bezier.Move(Constants.FORWARD);
            }
            else if (radioButtonIsometryViewPlane.Checked)
            {
                bezier.Move(Constants.FORWARD);
            }
            pictureBoxPlane.Refresh();
        }

        private void buttonMoveRightPlane_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewPlane.Checked)
            {
                bezier.Move(Constants.RIGHT);
            }
            else if (radioButtonAboveViewPlane.Checked)
            {
                bezier.Move(Constants.RIGHT);
            }
            else if (radioButtonSideViewPlane.Checked)
            {
                bezier.Move(Constants.DOWN);
            }
            else if (radioButtonIsometryViewPlane.Checked)
            {
                bezier.Move(Constants.RIGHT);
            }
            pictureBoxPlane.Refresh();
        }

        private void buttonMoveLeftPlane_Click(object sender, EventArgs e)
        {
            if (radioButtonFrontViewPlane.Checked)
            {
                bezier.Move(Constants.LEFT);
            }
            else if (radioButtonAboveViewPlane.Checked)
            {
                bezier.Move(Constants.LEFT);
            }
            else if (radioButtonSideViewPlane.Checked)
            {
                bezier.Move(Constants.UP);
            }
            else if (radioButtonIsometryViewPlane.Checked)
            {
                bezier.Move(Constants.LEFT);
            }
            pictureBoxPlane.Refresh();
        }

        private void dataGridViewPlane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Point3D point = GetPointFromCurrentCell(e);

            updatingData = true;
            numericUpDownXPlane.Value = (decimal)point.X;
            numericUpDownYPlane.Value = (decimal)point.Y;
            numericUpDownZPlane.Value = (decimal)point.Z;
            updatingData = false;
        }

        private void numericUpDownXPlane_ValueChanged(object sender, EventArgs e)
        {
            if (!updatingData)
            {
                UpdateCurrentCellValue();
                UpdateBezier();
                pictureBoxPlane.Refresh();
            }

        }

        private void numericUpDownYPlane_ValueChanged(object sender, EventArgs e)
        {
            if (!updatingData)
            {
                UpdateCurrentCellValue();
                UpdateBezier();
                pictureBoxPlane.Refresh();
            }
        }

        private void numericUpDownZPlane_ValueChanged(object sender, EventArgs e)
        {
            if (!updatingData)
            {
                UpdateCurrentCellValue();
                UpdateBezier();
                pictureBoxPlane.Refresh();
            }
        }

        private Point3D GetPointFromCurrentCell(DataGridViewCellEventArgs e)
        {
            string cellValue = dataGridViewPlane.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Regex regexNumber = new Regex(@"\d+");
            MatchCollection matches = regexNumber.Matches(cellValue);

            if (matches.Count == 3)
            {
                int X = int.Parse(matches[0].Value);
                int Y = int.Parse(matches[1].Value);
                int Z = int.Parse(matches[2].Value);
                Point3D point = new Point3D(X, Y, Z);

                return point;
            }

            throw new ArgumentException("Cell don't have (X,Y,Z)!");
        }

        private Point3D GetPointFromCurrentCell(int i, int j)
        {
            string cellValue = dataGridViewPlane.Rows[i].Cells[j].Value.ToString();
            Regex regexNumber = new Regex(@"\d+");
            MatchCollection matches = regexNumber.Matches(cellValue);

            if (matches.Count == 3)
            {
                int X = int.Parse(matches[0].Value);
                int Y = int.Parse(matches[1].Value);
                int Z = int.Parse(matches[2].Value);
                Point3D point = new Point3D(X, Y, Z);

                return point;
            }

            throw new ArgumentException("Cell don't have (X,Y,Z)!");
        }

        private void UpdateCurrentCellValue()
        {
            int x = (int)numericUpDownXPlane.Value;
            int y = (int)numericUpDownYPlane.Value;
            int z = (int)numericUpDownZPlane.Value;

            if (dataGridViewPlane.CurrentCell != null)
            {
                dataGridViewPlane.CurrentCell.Value = string.Format("({0};{1};{2})", x, y, z);
            }
        }

        private void UpdateBezier()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bezierPoints[i, j] = GetPointFromCurrentCell(i, j);
                }
            }

            bezier = new Bezier(bezierPoints);
        }

        private void buttonScaleIncreasePlane_Click(object sender, EventArgs e)
        {
            bezier.Increase();
            pictureBoxPlane.Refresh();
        }

        private void buttonScaleDecreasePlane_Click(object sender, EventArgs e)
        {
            bezier.Decrease();
            pictureBoxPlane.Refresh();
        }

        private void trackBarRotateOXPlane_Scroll(object sender, EventArgs e)
        {
            bezier.Rotate(Constants.OX, trackBarRotateOXPlane.Value);
            pictureBoxPlane.Refresh();
        }

        private void trackBarRotateOYPlane_Scroll(object sender, EventArgs e)
        {
            bezier.Rotate(Constants.OY, trackBarRotateOYPlane.Value);
            pictureBoxPlane.Refresh();
        }

        private void trackBarRotateOZPlane_Scroll(object sender, EventArgs e)
        {
            bezier.Rotate(Constants.OZ, trackBarRotateOZPlane.Value);
            pictureBoxPlane.Refresh();
        }

        private void trackBarAllAxisPlane_Scroll(object sender, EventArgs e)
        {
            if (checkBoxRotateOXPlane.Checked)
            {
                bezier.Rotate(Constants.OX, trackBarAllAxisPlane.Value);
            }
            if (checkBoxRotateOYPlane.Checked)
            {
                bezier.Rotate(Constants.OY, trackBarAllAxisPlane.Value);
            }
            if (checkBoxRotateOZPlane.Checked)
            {
                bezier.Rotate(Constants.OZ, trackBarAllAxisPlane.Value);
            }
            pictureBoxPlane.Refresh();
        }
    }
}
