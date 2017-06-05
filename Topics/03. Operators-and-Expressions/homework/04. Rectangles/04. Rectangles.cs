using System;

namespace Rectangle
{
    class Ractangle
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = weight * height;
            double perimeter = 2*weight + 2*height;
            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}
