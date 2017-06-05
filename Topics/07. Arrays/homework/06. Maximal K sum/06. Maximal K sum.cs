using System;

namespace MaxSumWithFixedLength
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int L = arr.Length - 1;
            int temp;
            int sum = 0;
            int counter = 0;

            for (int i = 0; i <= L; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int m = 0; m <= L; m++)
            {
                for (int j = 1; j <= L; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            for (int p = K; K > 0; K--)
            {
                sum = sum + arr[L - counter];
                counter++;
            }
            Console.WriteLine(sum);
        }
    }
}
