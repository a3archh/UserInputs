using System;

namespace ConsoleApp1
{
    class Program
    {
        static double Converter(double UserNum, string Conversion)
        {
            if (Conversion == "FTM")
            {
                return UserNum / 3.281;
            }
            else if (Conversion == "STK")
            {
                return UserNum * 6.35;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to convert");
            double UserNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 = Feet to Metres 2 = Stone to Kilograms");
            int ConversionNum = Convert.ToInt32(Console.ReadLine());
            if (ConversionNum == 1)
            {
                Console.WriteLine(Converter(UserNum, "FTM"));
            }
            else if (ConversionNum == 2)
            {
                Console.WriteLine(Converter(UserNum, "STK"));
            }
        }
    }
}
