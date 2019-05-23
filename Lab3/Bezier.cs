using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    class Bezier
    {
        private const int pointsLength = 16;
        private const int size = 4;
        private double period = 0.02;
        private const int pointsDrawLength = 50;
        public Point3D[] points = new Point3D[pointsLength];
        private Point3D[] tmpPoints = new Point3D[2500];
        private PointF[] pointsToDraw = new PointF[2500];
        private PointF[] mainPointsToDraw = new PointF[pointsLength];
        private Point3D center;
        protected int angleX = 0;
        protected int angleY = 0;
        protected int angleZ = 0;
        protected int moveStep = 10;

        private float[,] Mb = new float[4, 4] { {-1, 3, -3, 1},
                                                      {3, -6, 3, 0},
                                                      {-3, 3, 0, 0},
                                                      {1, 0, 0, 0 } };

        public Bezier(Point3D[] points)
        {
            for (int i = 0; i < pointsLength; i++)
            {
                this.points[i] = new Point3D();
                this.points[i].X = points[i].X;
                this.points[i].Y = points[i].Y;
                this.points[i].Z = points[i].Z;
                mainPointsToDraw[i] = new PointF();
            }

            center = new Point3D((points[3].X + points[0].X) / 2, points[0].Y, (points[12].Z + points[0].Z) / 2);
        }

        private void ToBezier()
        {
            float[,] Px = new float[size, size];
            float[,] Py = new float[size, size];
            float[,] Pz = new float[size, size];

            float[,] S;
            float[,] T;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Px[i, j] = points[i * 4 + j].X;
                    Py[i, j] = points[i * 4 + j].Y;
                    Pz[i, j] = points[i * 4 + j].Z;
                }
            }

            int k = 0;
            for (double t = 0; t < 1; t += period)
            {
                for (double s = 0; s < 1; s += period)
                {
                    S = new float[,] { { (float)Math.Pow(s, 3), (float)Math.Pow(s, 2), (float)s, 1 } };
                    T = new float[,] { { (float)Math.Pow(t, 3) }, { (float)Math.Pow(t, 2) }, { (float)t }, { 1 } };

                    float x = Mul(Mul(Mul(Mul(S, Mb), Px), Mb), T)[0, 0];
                    float y = Mul(Mul(Mul(Mul(S, Mb), Py), Mb), T)[0, 0];
                    float z = Mul(Mul(Mul(Mul(S, Mb), Pz), Mb), T)[0, 0];
                    tmpPoints[k] = new Point3D(x, y, z);
                    k++;
                }
            }
        }
        public void DrawXY(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            ToBezier();
            Projection.ToFrontView(points, mainPointsToDraw);
            Projection.ToFrontView(tmpPoints, pointsToDraw);
            Draw(pen1, pen2, e);
        }

        public void DrawXZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            ToBezier();
            Projection.ToAboveView(points, mainPointsToDraw);
            Projection.ToAboveView(tmpPoints, pointsToDraw);
            Draw(pen1, pen2, e);
        }

        public void DrawYZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            ToBezier();
            Projection.ToSideView(points, mainPointsToDraw);
            Projection.ToSideView(tmpPoints, pointsToDraw);
            Draw(pen1, pen2, e);
        }

        public void DrawIsometry(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            ToBezier();
            Projection.ToIsometryView(points, mainPointsToDraw);
            Projection.ToIsometryView(tmpPoints, pointsToDraw);
            Draw(pen1, pen2, e);
        }

        private void Draw(Pen pen1, Pen pen2, PaintEventArgs e)
        {

            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                e.Graphics.DrawEllipse(pen2, pointsToDraw[i].X, pointsToDraw[i].Y, 2, 2);
            }
            for (int i = 0; i < mainPointsToDraw.Length; i++)
            {
                e.Graphics.DrawEllipse(pen1, mainPointsToDraw[i].X, mainPointsToDraw[i].Y, 3, 3);
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

        public void Rotate(string direction, int angle)
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

        public void Increase()
        {
            AffineCalculations3D.Scale(points, center, (float)1.1, (float)1.1, (float)1.1);
        }
        public void Decrease()
        {
            AffineCalculations3D.Scale(points, center, (float)0.9, (float)0.9, (float)0.9);
        }

        private float[,] Mul(float[,] m1, float[,] m2)
        {
            float[,] r = new float[m1.GetLength(0), m2.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    r[i, j] = 0;
                    for (int k = 0; k < m2.GetLength(0); k++)
                    {
                        r[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return r;
        }
    }
}
