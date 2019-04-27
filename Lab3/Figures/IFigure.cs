using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab3.Figures
{
    abstract class IFigure
    {
        protected Point3D[] points;
        protected int pointsLength;
        protected Point3D center;
        protected int angleX = 0;
        protected int angleY = 0;
        protected int angleZ = 0;
        protected int moveStep = 5;

        public virtual void DrawXY(Brush Brush, PaintEventArgs e)
        {
            GraphicsPath RectanglePath = new GraphicsPath();
            for (int i = 0; i < pointsLength - 1; i++)
            {
                RectanglePath.AddLine(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            RectanglePath.AddLine(points[0].X, points[0].Y, points[pointsLength - 1].X, points[pointsLength - 1].Y);

            e.Graphics.DrawPath(Pens.Black, RectanglePath);
            e.Graphics.FillPath(Brush, RectanglePath);
        }

        public virtual void DrawXZ(Brush Brush, PaintEventArgs e)
        {
            GraphicsPath RectanglePath = new GraphicsPath();
            for (int i = 0; i < pointsLength - 1; i++)
            {
                RectanglePath.AddLine(points[i].X, points[i].Z, points[i + 1].X, points[i + 1].Z);
            }
            RectanglePath.AddLine(points[0].X, points[0].Z, points[pointsLength - 1].X, points[pointsLength - 1].Z);

            e.Graphics.DrawPath(Pens.Black, RectanglePath);
            e.Graphics.FillPath(Brush, RectanglePath);
        }

        public virtual void DrawYZ(Brush Brush, PaintEventArgs e)
        {
            GraphicsPath RectanglePath = new GraphicsPath();
            for (int i = 0; i < pointsLength - 1; i++)
            {
                RectanglePath.AddLine(points[i].Y, points[i].Z, points[i + 1].Y, points[i + 1].Z);
            }
            RectanglePath.AddLine(points[0].Y, points[0].Z, points[pointsLength - 1].Y, points[pointsLength - 1].Z);

            e.Graphics.DrawPath(Pens.Black, RectanglePath);
            e.Graphics.FillPath(Brush, RectanglePath);
        }

        public virtual void Rotate(string direction)
        {
            switch (direction)
            {
                case Constants.OXLEFT:
                    angleX++;
                    AffineCalculations3D.RotateX(points, center, 1);
                    break;
                case Constants.OXRIGHT:
                    angleX--;
                    AffineCalculations3D.RotateX(points, center, -1);
                    break;
                case Constants.OYLEFT:
                    angleY++;
                    AffineCalculations3D.RotateY(points, center, 1);
                    break;
                case Constants.OYRIGHT:
                    angleY--;
                    AffineCalculations3D.RotateY(points, center, -1);
                    break;
                case Constants.OZLEFT:
                    angleZ++;
                    AffineCalculations3D.RotateZ(points, center, 1);
                    break;
                case Constants.OZRIGHT:
                    angleZ--;
                    AffineCalculations3D.RotateZ(points, center, -1);
                    break;
            }
        }

        public virtual void Move(string direction)
        {
            switch (direction)
            {
                case Constants.UP:
                    AffineCalculations3D.Move(points, 0, -moveStep, 0);
                    center.Y -= moveStep;
                    break;
                case Constants.DOWN:
                    AffineCalculations3D.Move(points, 0, moveStep, 0);
                    center.Y += moveStep;
                    break;
                case Constants.LEFT:
                    AffineCalculations3D.Move(points, -moveStep, 0, 0);
                    center.X -= moveStep;
                    break;
                case Constants.RIGHT:
                    AffineCalculations3D.Move(points, moveStep, 0, 0);
                    center.X += moveStep;
                    break;
                case Constants.BACK:
                    AffineCalculations3D.Move(points, 0, 0, -moveStep);
                    center.Z -= moveStep;
                    break;
                case Constants.FORWARD:
                    AffineCalculations3D.Move(points, 0, 0, moveStep);
                    center.Z += moveStep;
                    break;
            };
        }
        public virtual void Increase(string Axis)
        {
            switch (Axis)
            {
                case Constants.XYZ:
                    AffineCalculations3D.Scale(points, center, (float)1.1, (float)1.1, (float)1.1);
                    break;
            }
        }
        public virtual void Decrease(string Axis)
        {
            switch (Axis)
            {
                case Constants.XYZ:
                    AffineCalculations3D.Scale(points, center, (float)0.9, (float)0.9, (float)0.9);
                    break;
            }
        }
    }
}
