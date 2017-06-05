using System;

namespace Quadratic_Equation
{
    class Quadratic_Equation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant > 0)
            {
                double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("{0:0.00}",x1);
                Console.WriteLine("{0:0.00}",x2);
            }
            else if (discriminant == 0)
            {
                double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("{0:0.00}",x1Andx2);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
