using System;
using System.Collections.Generic;
using System.Drawing;

namespace Week14B_Summary_Collections
{
    public class LengthComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point x, Point y)
        {
            return (Math.Abs(x.X) + Math.Abs(x.Y)) == (Math.Abs(y.X) + Math.Abs(y.Y));
        }
        public int GetHashCode(Point obj)
        {
            return Math.Abs(obj.X) + Math.Abs(obj.Y);
        }
    }
}
