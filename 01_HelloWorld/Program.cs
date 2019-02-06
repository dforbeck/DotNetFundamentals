using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        //Hello world to console
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();

            string hello = "Hello World";
            Console.WriteLine(hello);
            Console.ReadKey();

            string firstName = "Debbie";
            string lastName = "Forbeck";
            Console.WriteLine($"Good Morning, {firstName} {lastName}");
            Console.ReadLine();

            Console.WriteLine("Please enter your firt name.");
            string firstNameTwo = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastNameTwo = Console.ReadLine();

            Console.WriteLine("Hello" + firstNameTwo +" "+ lastNameTwo);
        }
    }
}
