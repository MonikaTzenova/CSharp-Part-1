using System;

class SieveOfEratosthenes
{
    static void Main()
    {
 int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            bool[] bigArr = new bool[n];
            for (int i = 0; i < bigArr.Length; i++)
            {
                bigArr[i] = true;
                
            }
            for (int i = 2; i < Math.Sqrt(bigArr.Length); i++)
            {
                if (bigArr[i])
                {
                    for (int j = i * i; j < bigArr.Length; j = j + i)
                    {
                        bigArr[j] = false;
                      
                    }
                }
            }

        for (int i = bigArr.Length-1; i >= 2; i--)
        {
            if (bigArr[i] == true)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
