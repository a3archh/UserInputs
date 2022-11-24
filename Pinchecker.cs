using System;

namespace ConsoleApp1
{
    class Program
    {
        static void PinChecker()
        {
            int Pin = 3542;
            int X = 1;
            while (X < 4)
            {
                Console.WriteLine("Please input your pin");
                int Userinput = Convert.ToInt32(Console.ReadLine());
                if (Userinput == Pin)
                {
                    Console.WriteLine("Hello");
                    X = 5;
                }
                else
                {
                    Console.WriteLine("Wrong you have " + (3-X) + " tries left");
                    X++;
                }
            }
        }
        static void Main(String[] args)
        {
            PinChecker();
        }
    }
}
