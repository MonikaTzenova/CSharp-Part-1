using System;

namespace CompareArrays
{
    class CompareArrays
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            bool isSimetric = true;

            for (var i = 0; i < n; i++) {
               firstArray[i] = int.Parse(Console.ReadLine());

            }
            for (var j = 0; j < n; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isSimetric = false;
                 }
            }
            Console.WriteLine(isSimetric? "Equal" : "Not equal");

        }
    }
}
