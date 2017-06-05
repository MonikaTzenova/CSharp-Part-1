using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            string birthDate = Console.ReadLine();
            DateTime userDate = DateTime.Parse(birthDate);
            DateTime curTime = DateTime.Now;
            var myAge = curTime.Year - userDate.Year;

            if (curTime.Month < userDate.Month)
            {
                myAge = myAge - 1;
            }
            else if (curTime.Month == userDate.Month)
            {
                if (curTime.Day < userDate.Day)
                {
                    myAge = myAge - 1;
                }
            }
            Console.WriteLine(myAge);
            Console.WriteLine(myAge + 10);

        }
    }
}
