using System;
using System.Drawing;

namespace Lab3
{
    static class Projection
    {
        const int matrixSize = 4;

        public static void ToIsometryView(Point3D[] points, PointF[] pointsToDraw)
        {

            float[,] IsometryMatrix = new float[matrixSize, matrixSize] { {0.707f, -0.408f, 0, 0 },
                                                                          {0, 0.816f, 0, 0 },
                                                                          {-0.707f,  -0.408f, 0, 0 },
                                                                          {0, 0, 0, 1 }};

            // Transform
            for (int i = 0; i < points.Length; i++)
            {
                float[] Vector = new float[matrixSize] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(IsometryMatrix, Vector);
                pointsToDraw[i].X = Vector[0] + 200;
                pointsToDraw[i].Y = Math.Abs(Vector[1]);
            }

            return;
        }

        public static void ToFrontView(Point3D[] points, PointF[] pointsToDraw)
        {

            // Transform
            for (int i = 0; i < points.Length; i++)
            {
                pointsToDraw[i].X = points[i].X;
                pointsToDraw[i].Y = points[i].Y;
            }

            return;
        }

        public static void ToSideView(Point3D[] points, PointF[] pointsToDraw)
        {

            // Transform
            for (int i = 0; i < points.Length; i++)
            {

                pointsToDraw[i].X = points[i].X;
                pointsToDraw[i].Y = points[i].Z;
            }

            return;
        }

        public static void ToAboveView(Point3D[] points, PointF[] pointsToDraw)
        {

            // Transform
            for (int i = 0; i < points.Length; i++)
            {

                pointsToDraw[i].X = points[i].Y;
                pointsToDraw[i].Y = points[i].Z;
            }

            return;
        }

        private static float[] MatrixOnVector(float[,] Matrix, float[] Vector)
        {
            float[] NewVector = new float[matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                float Sum = 0;
                for (int j = 0; j < matrixSize; j++)
                {
                    Sum += Vector[j] * Matrix[j, i];
                }
                NewVector[i] = Sum;
            }

            return NewVector;
        }

    }
}
