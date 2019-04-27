using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                points[i].Y = (float)(radius * Math.Sin(radian) + centerCircle1.Y);
                points[i].Z = centerCircle1.Z;
                radian += deltaRadian;
            }

            //radian = 0;
            // Circle2

            for (int i = pointsLength / 2; i < pointsLength; i++)
            {
                points[i] = new Point3D();
                points[i].X = (float)(radius * Math.Cos(radian) + centerCircle2.X);
                points[i].Y = (float)(radius * Math.Sin(radian) + centerCircle2.Y);
                points[i].Z = centerCircle2.Z;
                radian += deltaRadian;
            }
        }

        public override void DrawXY(Brush Brush, PaintEventArgs e)
        {
            GraphicsPath CirclePath = new GraphicsPath();
            for (int i = 0; i < pointsLength / 2 - 1; i++)
            {
                CirclePath.AddLine(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            //CirclePath.AddLine(points[pointsLength / 2 - 1].X, points[pointsLength / 2 - 1].Y, points[pointsLength / 2].X, points[pointsLength / 2].Y);

            //e.Graphics.DrawPath(Pens.Black, CirclePath);
            //e.Graphics.FillPath(Brush, CirclePath);

            // CirclePath = new GraphicsPath();
            e.Graphics.DrawPath(Pens.Black, CirclePath);
            e.Graphics.FillPath(Brush, CirclePath);
            CirclePath.Reset();

            for (int i = pointsLength / 2; i < pointsLength - 1; i++)
            {
                CirclePath.AddLine(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            CirclePath.AddLine(points[pointsLength / 4].X, points[pointsLength / 4].Y, points[pointsLength * 3 / 4].X, points[pointsLength * 3 / 4].Y);

            e.Graphics.DrawPath(Pens.Black, CirclePath);
            e.Graphics.FillPath(Brush, CirclePath);
        }

        public override void DrawXZ(Brush Brush, PaintEventArgs e)
        {
            GraphicsPath CirclePath = new GraphicsPath();
            for (int i = 0; i < pointsLength / 2; i++)
            {
                CirclePath.AddLine(points[i].X, points[i].Z, points[i + 1].X, points[i + 1].Z);
            }

            e.Graphics.DrawPath(Pens.Black, CirclePath);
            e.Graphics.FillPath(Brush, CirclePath);

            CirclePath = new GraphicsPath();

            for (int i = pointsLength / 2; i < pointsLength - 1; i++)
            {
                CirclePath.AddLine(points[i].X, points[i].Z, points[i + 1].X, points[i + 1].Z);
            }
            CirclePath.AddLine(points[0].X, points[0].Z, points[pointsLength - 1].X, points[pointsLength - 1].Z);

            e.Graphics.DrawPath(Pens.Black, CirclePath);
            e.Graphics.FillPath(Brush, CirclePath);
        }

        public override void DrawYZ(Brush Brush, PaintEventArgs e)
        {
            GraphicsPath CirclePath = new GraphicsPath();
            for (int i = 0; i < pointsLength / 2; i++)
            {
                CirclePath.AddLine(points[i].Y, points[i].Z, points[i + 1].Y, points[i + 1].Z);
            }

            e.Graphics.DrawPath(Pens.Black, CirclePath);
            e.Graphics.FillPath(Brush, CirclePath);

            //CirclePath = new GraphicsPath();

            for (int i = pointsLength / 2; i < pointsLength - 1; i++)
            {
                CirclePath.AddLine(points[i].Y, points[i].Z, points[i + 1].Y, points[i + 1].Z);
            }
            CirclePath.AddLine(points[0].Y, points[0].Z, points[pointsLength - 1].Y, points[pointsLength - 1].Z);

            e.Graphics.DrawPath(Pens.Black, CirclePath);
            e.Graphics.FillPath(Brush, CirclePath);
        }

    }
}
