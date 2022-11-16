using System;

namespace ConsoleApp1
{
    class Program
    {
        static void UsernameGenerator(string FirstName, string Surname, string DOB)
        {
            Console.WriteLine(FirstName.ToLower() + Surname.ToLower() + DOB.Substring(6));
            Console.WriteLine(FirstName.ToLower() + Surname.ToLower() + "_ 1");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            string Surname = Console.ReadLine();
            Console.WriteLine("Please enter your DOB DD/MM/YYYY");
            string DOB = Console.ReadLine();
            UsernameGenerator(FirstName, Surname, DOB);
        }
    }
}
