namespace Lab3
{
    class Bezier
    {
        private const int size = 4;
        private double S;

        private Point3D[,] points = new Point3D[size, size];
        private int[,] bezierMatrix = new int[size, size] { {-1, 3, -3, 1},
                                                            {3, -6, 3, 0},
                                                            {-3, 3, 0, 0},
                                                            {1, 0, 0, 0 } };
        public Bezier(Point3D[,] points)
        {
            this.points = points;
        }

        private void ToBezier()
        {

        }
    }
}
