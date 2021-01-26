using System;

namespace Valuta_1._01
{
    class Program
    {
        static double outputCurrency;
        static double outputCurrency1;
        static double outputCurrency2;
        static double outputCurrency3;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. \nTo convert Danish Crowns please press\n 1 for Us Dollars\n 2 for British Pounds\n 3 for Euro\n 4 for Swedish Crowns\n Press 5 for all");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    Console.WriteLine("How much do you want to convert?");
                    double InputInUS = double.Parse(Console.ReadLine());
                    outputCurrency = InputInUS * 0.16;
                    Console.WriteLine($"{outputCurrency} USD");
                    break;
                case 2:
                    Console.WriteLine("How much do you want to convert?");
                    double InputInGBP = double.Parse(Console.ReadLine());
                    outputCurrency = InputInGBP * 0.12;
                    Console.WriteLine($"{outputCurrency} GBP");
                    break;
                case 3:
                    Console.WriteLine("How much do you want to convert?");
                    double InputInEU = double.Parse(Console.ReadLine());
                    outputCurrency = InputInEU * 0.13;
                    Console.WriteLine($"{outputCurrency} EUR");
                    break;
                case 4:
                    Console.WriteLine("How much do you want to convert?");
                    double InputInSEK = double.Parse(Console.ReadLine());
                    outputCurrency = InputInSEK * 1.38;
                    Console.WriteLine($"{outputCurrency} SEK");
                    break;
                case 5:
                    Console.WriteLine("How much do you want to convert?");
                    double InputInAll = double.Parse(Console.ReadLine());
                    outputCurrency = InputInAll * 0.16;
                    outputCurrency1 = InputInAll * 0.12;
                    outputCurrency2 = InputInAll * 0.13;
                    outputCurrency3 = InputInAll * 1.38;
                    Console.WriteLine($"{outputCurrency} USD");
                    Console.WriteLine($"{outputCurrency1} GBP");
                    Console.WriteLine($"{outputCurrency2} EUR");
                    Console.WriteLine($"{outputCurrency3} SEK");
                    break;
            }
            Console.ReadLine();
        }
    }
}
