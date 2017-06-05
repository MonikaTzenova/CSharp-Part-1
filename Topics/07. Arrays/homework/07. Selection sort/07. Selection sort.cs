using System;

class SortArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];     

        for (int i = 0; i < n; i++)
        {
           array[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int tmp = array[j];
                    array[j] = array[i];
                    array[i] = tmp;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
     }
}
