using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if ((number / 100) % 10 == 7) {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", (number / 100) % 10);
            }
        }
    }
}
