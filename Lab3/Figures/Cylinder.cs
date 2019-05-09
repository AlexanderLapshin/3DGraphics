using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3.Figures
{
    class Cylinder : IFigure
    {
        protected float radius;

        public Cylinder(Point3D centerCircle1, Point3D centerCircle2, float radius)
        {
            this.radius = radius;
            pointsLength = 100;
            points = new Point3D[pointsLength];

            double radian = 0;
            double deltaRadian = 4 * Math.PI / pointsLength;
            // Circle1
            for (int i = 0; i < pointsLength / 2; i++)
            {
                points[i] = new Point3D();
                points[i].X = (float)(radius * Math.Cos(radian) + centerCircle1.X);
                points[i].Y = centerCircle1.Y;
                points[i].Z = (float)(radius * Math.Sin(radian) + centerCircle1.Z);
                radian += deltaRadian;
            }

            for (int i = pointsLength / 2; i < pointsLength; i++)
            {
                points[i] = new Point3D();
                points[i].X = (float)(radius * Math.Cos(radian) + centerCircle2.X);
                points[i].Y = centerCircle2.Y;
                points[i].Z = (float)(radius * Math.Sin(radian) + centerCircle2.Z);
                radian += deltaRadian;
            }

            center.X = centerCircle1.X;
            center.Y = (centerCircle1.Y + centerCircle2.Y) / 2;
            center.Z = (centerCircle1.Z + centerCircle2.Z) / 2;
        }

        public override void DrawXY(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }

            e.Graphics.DrawLine(pen1, points[0].X, points[0].Y, points[49].X, points[49].Y);
            e.Graphics.DrawLine(pen1, points[50].X, points[50].Y, points[99].X, points[99].Y);

            int j = 50;
            for (int i = 0; i < pointsLength / 2; i += 5)
            {

                e.Graphics.DrawLine(pen2, points[i].X, points[i].Y, points[j].X, points[j].Y);
                j += 5;
            }
        }

        public override void DrawXZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Z, points[i + 1].X, points[i + 1].Z);
            }

            e.Graphics.DrawLine(pen1, points[0].X, points[0].Z, points[pointsLength / 2 - 1].X, points[pointsLength / 2 - 1].Z);
            e.Graphics.DrawLine(pen1, points[pointsLength / 2].X, points[pointsLength / 2].Z, points[pointsLength - 1].X, points[pointsLength - 1].Z);

            int j = 50;
            for (int i = 0; i < pointsLength / 2; i += 5)
            {

                e.Graphics.DrawLine(Pens.Green, points[i].X, points[i].Z, points[j].X, points[j].Z);
                j += 5;
            }
        }

        public override void DrawYZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, points[i].Y, points[i].Z, points[i + 1].Y, points[i + 1].Z);
            }

            e.Graphics.DrawLine(pen1, points[0].Y, points[0].Z, points[49].Y, points[49].Z);
            e.Graphics.DrawLine(pen1, points[50].Y, points[50].Z, points[99].Y, points[99].Z);

            int j = 50;
            for (int i = 0; i < pointsLength / 2; i += 5)
            {

                e.Graphics.DrawLine(pen2, points[i].Y, points[i].Z, points[j].Y, points[j].Z);
                j += 5;
            }
        }

        public override void DrawIsometry(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            points = AffineCalculations3D.ToIsometry(points);

            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }

            e.Graphics.DrawLine(pen1, points[0].X, points[0].Y, points[49].X, points[49].Y);
            e.Graphics.DrawLine(pen1, points[50].X, points[50].Y, points[99].X, points[99].Y);

            int j = 50;
            for (int i = 0; i < pointsLength / 2; i += 5)
            {

                e.Graphics.DrawLine(pen2, points[i].X, points[i].Y, points[j].X, points[j].Y);
                j += 5;
            }
        }

    }
}
