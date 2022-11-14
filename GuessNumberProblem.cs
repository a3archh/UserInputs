using System;

namespace ConsoleApp1
{
    class Program
    {
        static void GetInput()
        {
            int GuessCounter = 0;
            bool ValidInput = false;
            Random rnd = new Random();
            int Number = rnd.Next(1,101);
            while (!ValidInput)
            {
                Console.WriteLine("Please input your guess");
                int Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess == Number)
                {
                    ValidInput = true;
                    GuessCounter = GuessCounter + 1;
                    Console.WriteLine("Correct! It took you " + GuessCounter + " Guesses!");
                }
                else
                {
                    if (Guess > Number)
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (Guess < Number)
                    {
                        Console.WriteLine("Too Low");
                    }
                    GuessCounter = GuessCounter + 1;
                }
            }
        }
        static void Main(string[] args)
        {
            GetInput();
        }
    }
}
