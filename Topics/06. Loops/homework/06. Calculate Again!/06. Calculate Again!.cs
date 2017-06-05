using System;
using System.Numerics;

class CalculateAgain
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFact = nFact * i;

            }
            for (int j = 1; j <= k; j++)
            {
                kFact = kFact * j;

            }
            Console.WriteLine(nFact / kFact);
        }
    }
}
