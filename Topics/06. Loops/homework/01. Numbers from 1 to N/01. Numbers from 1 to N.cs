using System;

class NumbersFrom1ToN
    {
        public static void Main()
        {
          int n = int.Parse(Console.ReadLine());
          int i = 1;
          while (i <= n) {
          	Console.Write(i + " ");
            i++;
          }
        }
}
