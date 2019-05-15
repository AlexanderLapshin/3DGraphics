using System.Drawing;

namespace Lab3
{
    class Bezier
    {
        private const int pointsLength = 4;
        private Point3D[,] points = new Point3D[pointsLength, pointsLength];
        private PointF[,] pointsToDraw = new PointF[pointsLength, pointsLength];


        private double S;
        private int[,] bezierMatrix = new int[4, 4] { {-1, 3, -3, 1},
                                                      {3, -6, 3, 0},
                                                      {-3, 3, 0, 0},
                                                      {1, 0, 0, 0 } };
        public Bezier(Point3D[,] points)
        {
            for (int i = 0; i < pointsLength; i++)
            {
                for (int j = 0; j < pointsLength; j++)
                {
                    this.points[i, j] = new Point3D();
                    this.points[i, j].X = points[i, j].X;
                    this.points[i, j].Y = points[i, j].Y;
                    this.points[i, j].Z = points[i, j].Z;
                }
            }
        }

        private void ToBezier()
        {
            float[] Px = new float[pointsLength];
            float[] Py = new float[pointsLength];
            float[] Pz = new float[pointsLength];

            float[] S = new float[pointsLength];
            float[] T = new float[pointsLength];
            float s = 0;
            float t = 0;

            for (int i = 0; i < pointsLength; i++)
            {
                for (int j = 0; j < pointsLength; j++)
                {
                    Px[j] = points[i, j].X;
                    Py[j] = points[i, j].Y;
                    Pz[j] = points[i, j].Z;
                }

            }
        }
    }
}
