using System;

namespace odd_or_even
{
    class OddOrEven
    {
        static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even" + " " + number);
            }
            else {
                Console.WriteLine("odd" + " " + number);
            }
        }
    }
}
