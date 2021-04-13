using System;

namespace EnumBijBMI
{
    class Program
    {
        enum Gewichten
        {
            Ondergewicht,
            Normaal,
            Overgewicht,
            Obesitas,
            ExtreemObesitas
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Height (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = Math.Round(weight / (height * height), 2);
            Gewichten gewicht = new Gewichten();
            if (bmi <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                gewicht = Gewichten.Ondergewicht;
            }
            else if (bmi > 18.5 && bmi < 25.0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                gewicht = Gewichten.Normaal;
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                gewicht = Gewichten.Overgewicht;
            }
            else if (bmi >= 30.0 && bmi < 40.0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                gewicht = Gewichten.Obesitas;
            }
            else if (bmi >= 40.0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                gewicht = Gewichten.ExtreemObesitas;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                gewicht = Gewichten.Normaal;
            }

            Console.WriteLine($"Your BMI: {bmi} ({gewicht})");
            Console.ResetColor();
        }
    }
}
