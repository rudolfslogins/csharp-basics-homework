namespace Exercise9
{
    public class Point
    {
        private int _point1;
        private int _point2;

        public Point(int point1, int point2)
        {
            _point1 = point1;
            _point2 = point2;
        }

        public int Point1
        {
            get { return _point1; }
            set { _point1 = value; }
        }

        public int Point2
        {
            get { return _point2; }
            set { _point2 = value; }
        }

    }
}