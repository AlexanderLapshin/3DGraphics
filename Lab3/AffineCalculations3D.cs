using System;

namespace Lab3
{
    class AffineCalculations3D
    {
        const int matrixSize = 4;

        public static Point3D[] Move(Point3D[] points, float x, float y, float z)
        {
            float[,] MoveMatrix = new float[matrixSize, matrixSize] { {1, 0, 0, x },
                                                                      {0, 1, 0, y },
                                                                      {0, 0, 1, z },
                                                                      {0, 0, 0, 1 }};

            // Move
            for (int i = 0; i < points.Length; i++)
            {
                float[] Vector = new float[matrixSize] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(MoveMatrix, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[2];
            }

            return points;
        }

        public static Point3D[] Scale(Point3D[] points, Point3D center, float x, float y, float z)
        {
            float[,] ScaleMatrix = new float[matrixSize, matrixSize] { {x, 0, 0, 0},
                                                                       {0, y, 0, 0},
                                                                       {0, 0, z, 0},
                                                                       {0, 0, 0, 1 } };

            // Move to (0, 0, 0)
            Move(points, -center.X, -center.Y, -center.Z);

            // Scale
            for (int i = 0; i < points.Length; i++)
            {
                float[] Vector = new float[matrixSize] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(ScaleMatrix, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[2];
            }

            // Move back
            Move(points, center.X, center.Y, center.Z);

            return points;
        }

        public static Point3D[] RotateX(Point3D[] points, Point3D center, float angle)
        {
            // Convert to Radians
            angle = (float)(angle * Math.PI) / 180;
            float Cos = (float)Math.Cos(angle);
            float Sin = (float)Math.Sin(angle);

            float[,] RotateMatrixX = new float[matrixSize, matrixSize] { {1, 0, 0, 0},
                                                                         {0, Cos, -Sin, 0},
                                                                         {0, Sin, Cos, 0},
                                                                         {0, 0, 0, 1 } };

            // Move to (0, 0, 0)
            Move(points, -center.X, -center.Y, -center.Z);


            // Rotate OX
            for (int i = 0; i < points.Length; i++)
            {
                float[] Vector = new float[matrixSize] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(RotateMatrixX, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[1];
            }

            // Move back
            Move(points, center.X, center.Y, center.Z);

            return points;
        }

        public static Point3D[] RotateY(Point3D[] points, Point3D center, float angle)
        {

            // Convert to Radians
            angle = (float)(angle * Math.PI) / 180;
            float Cos = (float)Math.Cos(angle);
            float Sin = (float)Math.Sin(angle);

            float[,] RotateMatrixY = new float[matrixSize, matrixSize] { {Cos, 0, -Sin, 0},
                                                                         {0, 1, 0, 0},
                                                                         {Sin, 0, Cos, 0},
                                                                         {0, 0, 0, 1 } };

            // Move to (0, 0, 0)
            Move(points, -center.X, -center.Y, -center.Z);


            // Rotate OY
            for (int i = 0; i < points.Length; i++)
            {
                float[] Vector = new float[matrixSize] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(RotateMatrixY, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[1];
            }

            // Move back
            Move(points, center.X, center.Y, center.Z);

            return points;
        }

        public static Point3D[] RotateZ(Point3D[] points, Point3D center, float angle)
        {
            // Convert to Radians
            angle = (float)(angle * Math.PI) / 180;
            float Cos = (float)Math.Cos(angle);
            float Sin = (float)Math.Sin(angle);

            float[,] RotateMatrixZ = new float[matrixSize, matrixSize] { {Cos, -Sin, 0, 0},
                                                                         {Sin, Cos, 0, 0},
                                                                         {0, 0, 1, 0},
                                                                         {0, 0, 0, 1 } };


            // Move to (0, 0, 0)
            Move(points, -center.X, -center.Y, -center.Z);


            // Rotate OZ
            for (int i = 0; i < points.Length; i++)
            {
                float[] Vector = new float[matrixSize] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(RotateMatrixZ, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[1];
            }

            // Move back
            Move(points, center.X, center.Y, center.Z);

            return points;
        }

        private static float[] MatrixOnVector(float[,] Matrix, float[] Vector)
        {
            float[] NewVector = new float[matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                float Sum = 0;
                for (int j = 0; j < matrixSize; j++)
                {
                    Sum += Vector[j] * Matrix[i, j];
                }
                NewVector[i] = Sum;
            }

            return NewVector;
        }
    }
}
