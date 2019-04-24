using System;

namespace Lab3
{
    class AffineCalculations3D
    {
        const int Size = 4;

        public static Point3D[] Move(Point3D[] points, double x, double y, double z)
        {
            double[,] MoveMatrix = new double[Size, Size] { {1, 0, 0, x },
                                                          {0, 1, 0, y },
                                                          {0, 0, 1, z },
                                                          {0, 0, 0, 1 }};

            // Move
            for (int i = 0; i < points.Length; i++)
            {
                double[] Vector = new double[Size] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(MoveMatrix, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[2];
            }

            return points;
        }

        public static Point3D[] Scale(Point3D[] points, double centerX, double centerY, double centerZ, double x, double y, double z)
        {
            double[,] ScaleMatrix = new double[Size, Size] { {x, 0, 0, 0},
                                                           {0, y, 0, 0},
                                                           {0, 0, z, 0},
                                                           {0, 0, 0, 1 } };

            // Move to (0, 0)
            Move(points, -centerX, -centerY, -centerZ);

            // Scale
            for (int i = 0; i < points.Length; i++)
            {
                double[] Vector = new double[Size] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(ScaleMatrix, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[2];
            }

            // Move back
            Move(points, centerX, centerY, centerZ);

            return points;
        }

        public static Point3D[] RotateX(Point3D[] points, double centerX, double centerY, double centerZ, double angle)
        {
            double[,] RotateMatrixX = new double[Size, Size] { {1, 0, 0, 0},
                                                             {0, Math.Cos(angle), -Math.Sin(angle), 0},
                                                             {0, Math.Sin(angle), Math.Cos(angle), 0},
                                                             {0, 0, 0, 1 } };

            // Convert to Radians
            angle = (angle * Math.PI) / 180;

            // Move to (0, 0)
            Move(points, -centerX, -centerY, -centerZ);


            // Rotate
            for (int i = 0; i < points.Length; i++)
            {
                double[] Vector = new double[Size] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(RotateMatrixX, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[1];
            }

            // Move back
            Move(points, centerX, centerY, centerZ);

            return points;
        }

        public static Point3D[] RotateY(Point3D[] points, double centerX, double centerY, double centerZ, double angle)
        {
            double[,] RotateMatrixX = new double[Size, Size] { {Math.Cos(angle), 0, -Math.Sin(angle), 0},
                                                               {0, 1, 0, 0},
                                                               {Math.Sin(angle), 0, Math.Cos(angle), 0},
                                                               {0, 0, 0, 1 } };

            // Convert to Radians
            angle = (angle * Math.PI) / 180;

            // Move to (0, 0)
            Move(points, -centerX, -centerY, -centerZ);


            // Rotate
            for (int i = 0; i < points.Length; i++)
            {
                double[] Vector = new double[Size] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(RotateMatrixX, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[1];
            }

            // Move back
            Move(points, centerX, centerY, centerZ);

            return points;
        }

        public static Point3D[] RotateZ(Point3D[] points, double centerX, double centerY, double centerZ, double angle)
        {
            double[,] RotateMatrixX = new double[Size, Size] { {Math.Cos(angle), -Math.Sin(angle), 0, 0},
                                                               {Math.Sin(angle), Math.Cos(angle), 0, 0},
                                                               {0, 0, 1, 0},
                                                               {0, 0, 0, 1 } };

            // Convert to Radians
            angle = (angle * Math.PI) / 180;

            // Move to (0, 0)
            Move(points, -centerX, -centerY, -centerZ);


            // Rotate
            for (int i = 0; i < points.Length; i++)
            {
                double[] Vector = new double[Size] { points[i].X, points[i].Y, points[i].Z, 1 };
                Vector = MatrixOnVector(RotateMatrixX, Vector);
                points[i].X = Vector[0];
                points[i].Y = Vector[1];
                points[i].Z = Vector[1];
            }

            // Move back
            Move(points, centerX, centerY, centerZ);

            return points;
        }

        private static double[] MatrixOnVector(double[,] Matrix, double[] Vector)
        {
            double[] NewVector = new double[Size];

            for (int i = 0; i < Size; i++)
            {
                double Sum = 0;
                for (int j = 0; j < Size; j++)
                {
                    Sum += Vector[j] * Matrix[i, j];
                }
                NewVector[i] = Sum;
            }

            return NewVector;
        }
    }
}
