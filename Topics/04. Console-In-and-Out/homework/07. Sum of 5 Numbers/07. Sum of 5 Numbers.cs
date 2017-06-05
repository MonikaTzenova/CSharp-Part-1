using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c= int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int sumOfNumbers = a+b + c + d + e;
        Console.WriteLine("{0}", sumOfNumbers);
    }
}
