using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAssignment._4_1_25_
{
    class Circle
    {
        public Point center;
        public double radius { get; set; }

        public Circle(Point p1, double r)
        {
            p1  = center;
            r   = radius;
        }

        public Circle(double _x = 0, double _y = 0, double _radius = 0)
        {
            center.x = _x;
            center.y = _y;
            radius = _radius;
        }// end constructor
    }
}
