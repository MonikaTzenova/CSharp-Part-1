using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 7 == 0 && number % 5 == 0)
            {
                Console.WriteLine("true" + " " + number);
            }
            else
            {
                Console.WriteLine("false" + " " + number);
            }
        }
    }
}
