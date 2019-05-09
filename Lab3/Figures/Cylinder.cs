using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3.Figures
{
    class Cylinder : IFigure
    {
        private float radius;
        private int lineStep = 5;

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
            int j = pointsLength / 2;
            for (int i = 0; i < pointsLength / 2; i += lineStep)
            {

                e.Graphics.DrawLine(Pens.Green, points[i].X, points[i].Y, points[j].X, points[j].Y);
                j += lineStep;
            }

            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }

            e.Graphics.DrawLine(pen1, points[0].X, points[0].Y, points[pointsLength / 2 - 1].X, points[pointsLength / 2 - 1].Y);
            e.Graphics.DrawLine(pen1, points[pointsLength / 2].X, points[pointsLength / 2].Y, points[pointsLength - 1].X, points[pointsLength - 1].Y);
        }

        public override void DrawXZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            int j = pointsLength / 2;
            for (int i = 0; i < pointsLength / 2; i += lineStep)
            {

                e.Graphics.DrawLine(Pens.Green, points[i].X, points[i].Z, points[j].X, points[j].Z);
                j += lineStep;
            }

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
        }

        public override void DrawYZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            int j = pointsLength / 2;
            for (int i = 0; i < pointsLength / 2; i += lineStep)
            {

                e.Graphics.DrawLine(Pens.Green, points[i].X, points[i].Z, points[j].X, points[j].Z);
                j += lineStep;
            }

            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, points[i].Y, points[i].Z, points[i + 1].Y, points[i + 1].Z);
            }

            e.Graphics.DrawLine(pen1, points[0].Y, points[0].Z, points[pointsLength / 2 - 1].Y, points[pointsLength / 2 - 1].Z);
            e.Graphics.DrawLine(pen1, points[pointsLength / 2].Y, points[pointsLength / 2].Z, points[pointsLength - 1].Y, points[pointsLength - 1].Z);
        }

        public override void DrawIsometry(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            if (!isometry)
            {
                points = AffineCalculations3D.ToIsometry(points, center);
                isometry = true;
            }

            int j = pointsLength / 2;
            for (int i = 0; i < pointsLength / 2; i += lineStep)
            {

                e.Graphics.DrawLine(Pens.Green, points[i].X, points[i].Y, points[j].X, points[j].Y);
                j += lineStep;
            }

            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }

            e.Graphics.DrawLine(pen1, points[0].X, points[0].Y, points[pointsLength / 2 - 1].X, points[pointsLength / 2 - 1].Y);
            e.Graphics.DrawLine(pen1, points[pointsLength / 2].X, points[pointsLength / 2].Y, points[pointsLength - 1].X, points[pointsLength - 1].Y);
        }

    }
}
