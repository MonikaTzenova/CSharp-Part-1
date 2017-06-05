using System;

class IntDoubleAndString
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    {
                        int result = Convert.ToInt32(value);
                        Console.WriteLine(++result); 
                        break;
                    }
                case "real":
                    {
                        double result = Convert.ToDouble(value);
                        Console.WriteLine("{0:F2}", ++result); 
                        break;
                    }
                case "text":
                    {
                        Console.WriteLine("{0}*", value); 
                        break;
                    }
                default:
                    break;
            }
        }
    }
