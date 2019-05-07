using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(4, 5);
            p.show();
            p.move(1, 2);

            p.show();

            Point[] pointsTable = { new Point(1,3),
                                    new Point(3,2),
                                    new Point(1,5) };

            Point.CheckCollinearity(pointsTable);

            Point p1 = new Point(2, 3);
            Point p2 = new Point(3, 5);

            LineSegment lineSeg = new LineSegment(p1, p2);

            lineSeg.lineSegmentLenght();

            Console.ReadKey();
        }
    }
}
