using System;

namespace Week13B
{
    public abstract class Polygon : IComparable
    {
        private int _points;

        protected Polygon(int points)
        {
            _points = points;
        }

        protected Polygon()
        {
            
        }

        public abstract double Range();
        public abstract double Area();
        public int CompareTo(object obj)
        {
            var otherArea = ((Polygon)obj).Area();
            return Area().CompareTo(otherArea);
        }
    }

    public class Rectangle : Polygon
    {
        private int _a, _b;

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int B
        {
            get { return _b; }
            set { _b = value; }
        }

        public Rectangle(int a, int b) : base()
        {
            this._a = a;
            this._b = b;
        }

        public override double Area()
        {
            return _a * _b;
        }

        public override double Range()
        {
            return 2 * (_a + _b);
        }
    }

    public class Cube : Rectangle
    {
        public Cube(int a) : base(a, a)
        {
        }
    }
}