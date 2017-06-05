using System;

namespace CompareArrays
{
    class CompareArrays
    {

        static void Main()
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();



            char[] firstCharArray = firstStr.ToCharArray();
            char[] secondCharArray = secondStr.ToCharArray();


            int firstCharArrLength = firstCharArray.Length;
            int secondCharArrLength = secondCharArray.Length;

            if ((1 <= firstCharArrLength && firstCharArrLength <= 128) && (1 <= secondCharArrLength && secondCharArrLength <= 128))
            {

                if (firstCharArrLength == secondCharArrLength)
                {

                    Console.WriteLine("=");
                }
                else
                {
                    if (firstCharArrLength < secondCharArrLength)
                    {
                        Console.WriteLine("<");
                    }
                    else
                    {
                        Console.WriteLine(">");
                    }
                }
            }
        }
    }
    }
