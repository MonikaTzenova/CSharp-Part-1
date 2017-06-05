using System;

namespace Number_Comparer
{
    class Number_Comparer
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine(a>b ? a : b);
        }
    }
}
