using System;
using System.Numerics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            if (A == B)
            {
                Console.WriteLine("=");
            }
            else
            {
                for (int i = 0; i < Math.Min(A.Length, B.Length); i++)
                {
                    if (A[i] > B[i])
                    {
                        Console.WriteLine(">");
                        break;
                    }
                    else if (A[i] < B[i])
                    {
                        Console.WriteLine("<");
                        break;
                    }
                    else if(i == Math.Min(A.Length, B.Length) - 1)
                    {
                        if (A.Length > B.Length)
                        {
                            Console.WriteLine(">");
                        }
                        else
                        {
                            Console.WriteLine("<");
                        }
                    }
                }
            }
        }
    }
}
