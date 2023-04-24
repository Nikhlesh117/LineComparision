using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class CalculateLine
    {
        double x_One, y_One, x_Two, y_Two;
        public CalculateLine(double x_One, double y_One, double x_Two, double y_Two)
        {
            this.x_One = x_One;
            this.y_One = y_One;
            this.x_Two = x_Two;
            this.y_Two = y_Two;
        }

        public double LengthLine()
        {
            double Line = Math.Sqrt(Math.Pow(x_Two - x_One, 2) + Math.Pow(y_Two - y_One, 2));
            Console.WriteLine("Line Length is {0}", Line);
            return Line;
        }

    }
}
