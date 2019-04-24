namespace Lab3
{
    class AffineCalculations3D
    {
        const int Size = 4;

        public static Point3D[] Move(Point3D[] points, float x, float y, float z)
        {
            float[,] MoveMatrix = new float[Size, Size] { {1,0,0,x },
                                                          {0,1,0,y },
                                                          {0,0,1,z },
                                                          {0,0,0,1 }};

            // Move
            for (int i = 0; i < points.Length; i++)
            {
                fl
            }
        }
    }
}
