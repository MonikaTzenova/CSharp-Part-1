using System;

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            Console.WriteLine("{0}", i % 2 == 0? i: -i);
        }
    }
}
