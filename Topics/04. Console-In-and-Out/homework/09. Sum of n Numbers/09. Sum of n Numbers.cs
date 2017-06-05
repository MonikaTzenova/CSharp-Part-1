using System;

class NSum
{
    static void Main()
    {
      
        double sum = 0;
 
        double n = double.Parse(Console.ReadLine());
 
        for (int i = 0; i < n; i++)
        {
 
            double input = int.Parse(Console.ReadLine());
 
            sum += input;
           
 
        }
        Console.WriteLine(sum);
    }
}
