using System;

class Interval
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int counter = 0;

        if (n >= 0 && n <= m && m <= 2000)
        {
            for (int i = n + 1; i < m; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
