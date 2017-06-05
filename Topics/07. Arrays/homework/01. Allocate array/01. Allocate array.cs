using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (var i = 0; i < array.Length; i ++ ) {
                Console.WriteLine(array[i] = i*5);
            }
        }
    }
}
