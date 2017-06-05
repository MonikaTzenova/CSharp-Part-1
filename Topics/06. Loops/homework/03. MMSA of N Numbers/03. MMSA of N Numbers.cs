using System;
using System.Linq;

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] numArr = new double[n];
            for (int i = 0; i < n; i++)
            {
                numArr[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0:F2}", numArr.Min());
            Console.WriteLine("max={0:F2}", numArr.Max());
            Console.WriteLine("sum={0:F2}", numArr.Sum());
            Console.WriteLine("avg={0:F2}", numArr.Average());
        }
    }
}
