using System;

namespace N_th_Bit
{
    class N_th_Bit
    {
        static void Main()
        {
            long p = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long moveBit = p >> n;
            int mask = 1;
            long result = moveBit & mask;

            Console.WriteLine("{0}", result);
        }
    }
}
