using System;

namespace PointInaCircle
{
    class PointInaCircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((x * x) + (y * y)) <= (2 * 2))
            {
                Console.WriteLine("yes {0:0.00}", Math.Sqrt(x*x + y*y));
            }
            else
            {
                Console.WriteLine("no {0:0.00}", Math.Sqrt(x*x + y*y));
            }
        }
    }
}
