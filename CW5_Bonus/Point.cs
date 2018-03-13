using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Bonus
{
    class Point
    {
        public double[] Coord = new double[2];
        public double Distance(Point target)
        {
            return Math.Sqrt((this.Coord[0] - target.Coord[0]) * (this.Coord[0] - target.Coord[0]) + (this.Coord[1] - target.Coord[1]) * (this.Coord[1] - target.Coord[1]));
        }
    }
}
