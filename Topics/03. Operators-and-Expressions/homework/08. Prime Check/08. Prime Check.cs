using System;


namespace _08.Prime_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = int.Parse(Console.ReadLine());

            if ( prime > 0 && prime <= 100 )
            {
                if (prime == 0 || prime == 1)
                {
                    Console.WriteLine("false");
                    return;
                }
                else
                {
                    for (int a = 2; a <= prime / 2; a++)
                    {
                        if ( prime % a == 0)
                        {
                            Console.WriteLine("false");
                            return;
                        }

                    }
                    Console.WriteLine("true");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
