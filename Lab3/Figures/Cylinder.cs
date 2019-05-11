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
            pointsToDraw = new PointF[pointsLength];
            points = new Point3D[pointsLength];

            double radian = 0;
            double deltaRadian = 4 * Math.PI / pointsLength;

            // Circle1
            for (int i = 0; i < pointsLength / 2; i++)
            {
                // Create objects
                pointsToDraw[i] = new PointF();
                points[i] = new Point3D();

                // Find points
                points[i].X = (float)(radius * Math.Cos(radian) + centerCircle1.X);
                points[i].Y = centerCircle1.Y;
                points[i].Z = (float)(radius * Math.Sin(radian) + centerCircle1.Z);
                radian += deltaRadian;
            }

            // Circle 2
            for (int i = pointsLength / 2; i < pointsLength; i++)
            {
                // Create objects
                pointsToDraw[i] = new PointF();
                points[i] = new Point3D();

                // Find points
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
            Projection.ToFrontView(points, pointsToDraw);
            Draw(pen1, pen2, e);
        }

        public override void DrawXZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            Projection.ToAboveView(points, pointsToDraw);
            Draw(pen1, pen2, e);
        }

        public override void DrawYZ(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            Projection.ToSideView(points, pointsToDraw);
            Draw(pen1, pen2, e);
        }

        public override void DrawIsometry(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            Projection.ToIsometryView(points, pointsToDraw);
            Draw(pen1, pen2, e);
        }


        private void Draw(Pen pen1, Pen pen2, PaintEventArgs e)
        {
            int j = pointsLength / 2;
            for (int i = 0; i < pointsLength / 2; i += lineStep)
            {

                e.Graphics.DrawLine(Pens.Green, pointsToDraw[i].X, pointsToDraw[i].Y, pointsToDraw[j].X, pointsToDraw[j].Y);
                j += lineStep;
            }

            for (int i = 0; i < pointsLength - 1; i++)
            {
                if (i == pointsLength / 2 - 1)
                {
                    continue;
                }
                e.Graphics.DrawLine(pen1, pointsToDraw[i].X, pointsToDraw[i].Y, pointsToDraw[i + 1].X, pointsToDraw[i + 1].Y);
            }

            e.Graphics.DrawLine(pen1, pointsToDraw[0].X, pointsToDraw[0].Y, pointsToDraw[pointsLength / 2 - 1].X, pointsToDraw[pointsLength / 2 - 1].Y);
            e.Graphics.DrawLine(pen1, pointsToDraw[pointsLength / 2].X, pointsToDraw[pointsLength / 2].Y, pointsToDraw[pointsLength - 1].X, pointsToDraw[pointsLength - 1].Y);
        }
    }
}
