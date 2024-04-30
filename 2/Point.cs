using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class Point
    {
        public int x;
        public int y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Cout(int x, int y)
        {
            Console.Write("Координаты точки: " + x + ", " + y);
        }
        public double Distance(double x, double y)
        {
            double dist = Math.Sqrt(Math.Abs(x) * Math.Abs(x) + Math.Abs(y) * Math.Abs(y));
            return dist;
        }
        public void VectorTravel(ref int x, ref int y, int a, int b)
        {
            x = x + a;
            y = y + b;
        }
    }
}
