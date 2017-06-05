using System;
using System.Numerics;

class CalculateNFacturelDivide_KFacturelNK
{
    static void Main()
    {
   
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFacturelN = 1;
        BigInteger nFacturelK = 1;
        BigInteger sumFacturiel = 1;
        BigInteger div = 1;
        int counter = 1;

        while (counter <= n)
        {
            nFacturelN *= counter;
            if (counter <= k)
            {
                nFacturelK *= counter;
            }
            counter++;
        }

        counter = 1;
        while (counter <= (n - k))
        {
            sumFacturiel *= counter;
            counter++;
        }

        div = (nFacturelN / (nFacturelK * sumFacturiel));

        Console.WriteLine( div);
    }
}
