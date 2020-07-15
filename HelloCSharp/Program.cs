using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your first name: \n");
            var firstName = Console.ReadLine(); // lazy, data type is given based on content
            Console.Write("Enter your last name: \n");
            string lastName = Console.ReadLine(); // eager, data type is explicit prior to content

            //Console.WriteLine(firstName + " " + lastName);
            //Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine($"{firstName} {lastName}");

            Console.ReadLine();
        }
    }
}
