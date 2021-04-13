using System;

namespace BMIMetIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = Math.Round(weight / (height * height), 2, MidpointRounding.AwayFromZero);
            if(bmi <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (bmi > 18.5 && bmi < 25.0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (bmi >= 30.0 && bmi < 40.0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (bmi >= 40.0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine($"Your BMI: {bmi}");
            Console.ResetColor();
        }
    }
}
