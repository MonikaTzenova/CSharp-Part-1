using System;

namespace BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int moveRight = number >> 3;
            int mask = 1;
            int result = moveRight & mask;

            Console.WriteLine("{0}", result);
        }
    }
    }
