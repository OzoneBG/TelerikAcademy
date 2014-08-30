using System;

namespace _3.Company
{
    class Company
    {
        static void Main()
        {
            //Company
            string name;
            string address;
            int compPhoneNumber;
            int fax;

            //Manager
            string firstName;
            string lastName;
            string fullName;
            int age;
            int manPhoneNumber;


            //Read info about company
            Console.Write("Company name: ");
            name = Console.ReadLine();

            Console.Write("Company address: ");
            address = Console.ReadLine();

            Console.Write("Company phone number: ");
            compPhoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Company fax: ");
            fax = int.Parse(Console.ReadLine());

            //Read info about manager
            Console.Write("Manager's first name: ");
            firstName = Console.ReadLine();

            Console.Write("Manager's last name: ");
            lastName = Console.ReadLine();

            Console.Write("Manager's age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Manager's phone: ");
            manPhoneNumber = int.Parse(Console.ReadLine());

            //Print information about company
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Company and manager information:");
            Console.WriteLine("Company name: {0}", name);
            Console.WriteLine("Company address: {0}", address);
            Console.WriteLine("Company phone: {0}", compPhoneNumber);
            Console.WriteLine("Company fax: {0}", fax);

            //Make full name
            fullName = firstName + lastName;

            //Print info about manager
            Console.WriteLine("Manager's full name: {0}", fullName);
            Console.WriteLine("Manager's age: {0}", age);
            Console.WriteLine("Manager's phone: {0}", manPhoneNumber);
        }
    }
}
