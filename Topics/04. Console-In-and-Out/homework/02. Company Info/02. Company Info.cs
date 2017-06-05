using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
   
            string companyName = Console.ReadLine();

            string address = Console.ReadLine();

            string phoneNumber = Console.ReadLine();

            string faxNumber = Console.ReadLine();

            string webSite = Console.ReadLine();

            string managerFirstName = Console.ReadLine();

            string managerLastName = Console.ReadLine();
            string managerFullName = managerFirstName + " " + managerLastName;

            byte age = byte.Parse(Console.ReadLine());

            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Tel. {0}", phoneNumber);

            if (faxNumber != null && faxNumber != "")
            {
                Console.WriteLine("Fax: {0}", faxNumber);
            }
            else
            {
                Console.WriteLine("Fax: {0}", "(no fax)");

            }
            
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerFullName, age, managerPhoneNumber);
        }
    }
}
