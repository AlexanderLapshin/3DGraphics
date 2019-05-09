using System.Drawing;
using System.Windows.Forms;

namespace Lab3.Figures
{
    abstract class IFigure
    {
        protected Point3D[] points;
        protected int pointsLength;
        protected Point3D center = new Point3D();
        protected int angleX = 0;
        protected int angleY = 0;
        protected int angleZ = 0;
        protected int moveStep = 10;

        public virtual void DrawXY(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            for (int i = 0; i < pointsLength - 1; i++)
            {
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            e.Graphics.DrawLine(pen1, points[0].X, points[0].Y, points[pointsLength - 1].X, points[pointsLength - 1].Y);
        }

        public virtual void DrawXZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            for (int i = 0; i < pointsLength - 1; i++)
            {
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Z, points[i + 1].X, points[i + 1].Z);
            }
            e.Graphics.DrawLine(pen1, points[0].X, points[0].Z, points[pointsLength - 1].X, points[pointsLength - 1].Z);
        }

        public virtual void DrawYZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            for (int i = 0; i < pointsLength - 1; i++)
            {
                e.Graphics.DrawLine(pen1, points[i].Y, points[i].Z, points[i + 1].Y, points[i + 1].Z);
            }
            e.Graphics.DrawLine(pen1, points[0].Y, points[0].Z, points[pointsLength - 1].Y, points[pointsLength - 1].Z);
        }

        public virtual void DrawIsometry(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            points = AffineCalculations3D.ToIsometry(points);

            for (int i = 0; i < pointsLength - 1; i++)
            {
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            e.Graphics.DrawLine(pen1, points[0].X, points[0].Y, points[pointsLength - 1].X, points[pointsLength - 1].Y);
        }

        public virtual void Rotate(string direction, int angle)
        {
            switch (direction)
            {
                case Constants.OX:
                    AffineCalculations3D.RotateX(points, center, angle - angleX);
                    angleX = angle;
                    break;
                case Constants.OY:
                    AffineCalculations3D.RotateY(points, center, angle - angleY);
                    angleY = angle;
                    break;
                case Constants.OZ:
                    AffineCalculations3D.RotateZ(points, center, angle - angleZ);
                    angleZ = angle;
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
        public virtual void Increase()
        {
            AffineCalculations3D.Scale(points, center, (float)1.1, (float)1.1, (float)1.1);
        }
        public virtual void Decrease()
        {
            AffineCalculations3D.Scale(points, center, (float)0.9, (float)0.9, (float)0.9);
        }
    }
}
