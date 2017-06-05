using System;

class PrinttheASCIITable
{
    static void Main()
    {


        for (byte counter = 33; counter < 127; counter++)
        {
            Console.Write((char)counter);
        }

    }
}
