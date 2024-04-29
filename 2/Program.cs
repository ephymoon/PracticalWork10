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
            x=x+a; 
            y=y+b;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Point point = new Point();
            Console.Write("Введите x: ");
            point.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y: ");
            point.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 - для вывода координат точки на экран;\n2 - для того, чтобы расчитать расстояние от начала координат до точки;");
            Console.Write("3 - для того, чтобы переместить точку на вектор (a,b).\n0 - чтобы выйти из программы.");
        test:
            Console.Write("\nВыберите действие: ");

            switch (Console.ReadLine())
            {
                case ("1"):
                    point.Cout(point.x, point.y);
                    goto test;
                case ("2"):
                    Console.Write(point.Distance(point.x, point.y));
                    goto test;
                case ("3"):
                    Console.Write("Введите а: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    point.VectorTravel(ref point.x, ref point.y, a, b);
                    goto test;
                case ("0"):
                    break;
                default:
                    Console.WriteLine("Несуществующий вариант, повторите попытку.");
                    goto test;
            }
            Console.Write("Нажмите любую клавишу, чтобы завершить работу программы...");
            Console.ReadKey();
        }
    }
}
