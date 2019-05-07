using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOperations
{
    class Point
    {
        public int Point_x { get; set; }
        public int Point_y { get; set; }

        public Point(int p_x, int p_y)
        {
            Point_x = p_x;
            Point_y = p_y;
        }

        public void move(int vec_x, int vec_y)
        {
            Point_x = Point_x + vec_x;
            Point_y = Point_y + vec_y;
        }

        public void show()
        {
            Console.WriteLine("The coordinates of the point are: " + Point_x + ", " + Point_y);
        }

        public static void CheckCollinearity(Point[] pTab)
        {
            if ((pTab[2].Point_y - pTab[1].Point_y) * (pTab[1].Point_x - pTab[0].Point_x) == (pTab[1].Point_y - pTab[0].Point_y) * (pTab[2].Point_x - pTab[1].Point_x))
            {
                Console.WriteLine("Points are collinear.");
            }
            else { Console.WriteLine("Points are not collinear."); }
        }
    }
}
