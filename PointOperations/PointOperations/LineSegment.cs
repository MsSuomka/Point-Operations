using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOperations
{
    class LineSegment : Point

    {
        public Point pFirst { get; set; }
        public Point pSecond { get; set; }

        public LineSegment(Point first, Point second) : base(first.Point_x, first.Point_y)
        {
            pFirst = first;
            pSecond = second;
        }
        public void lineSegmentLenght()
        {
            double length = Math.Sqrt(Math.Pow((pSecond.Point_x - pFirst.Point_x), 2) + Math.Pow(pSecond.Point_y - pFirst.Point_y, 2));
            Console.WriteLine("The length of line segment is: " + length);
        }
    }
}
