using System;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int positionN = int.Parse(Console.ReadLine());
            byte valueN = byte.Parse(Console.ReadLine());
            ulong valueLastBit;
            ulong mask = 1;

            valueLastBit = number >> positionN;
            valueLastBit = valueLastBit & 1;


            if (valueLastBit == 1 && valueN == 1)
            {
                Console.WriteLine(Convert.ToString(number));
            }

            if (valueLastBit == 1 && valueN == 0)
            {
                mask = ~(mask << positionN);
                Console.WriteLine(Convert.ToString(number & mask));
            }

            if (valueLastBit == 0 && valueN == 1)
            {
                mask = mask << positionN;
                Console.WriteLine(Convert.ToString(number | mask));
            }
            if (valueLastBit == 0 && valueN == 0)
            {
                Console.WriteLine(Convert.ToString(number));
            }


        }
    }
}
