using System;

namespace ConsoleApp1
{
    class Program
    {
        static void NegNumFind()
        {
            int Attempts = 0;
            List<int> Numbers = new List<int>();
            bool Loop = true;
            while (Loop == true)
            {
                Console.WriteLine("Please input a number");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number > -1)
                {
                    Numbers.Add(Number);
                    Attempts = Attempts + 1;
                }
                else
                {
                    Console.WriteLine(Attempts + " Attempts");
                    Console.WriteLine(Numbers.Max());
                    Console.WriteLine(Numbers.Sum());
                    Console.WriteLine(Numbers.Average());
                    Loop = false;
                }
            }
        }
        static void Main(string[] args)
        {
            NegNumFind();
        }
    }
}
