using System;

namespace KleurcodeWeerstandNaarOhm
{
    class Program
    {
        enum Colors
        {
            black,
            brown,
            red,
            orange,
            yellow,
            green,
            blue,
            magenta,
            gray,
            white
        }

        static void Main(string[] args)
        {
            string ring1 = AskForString("What color is the first ring?").ToLower();
            string ring2 = AskForString("What color is the second ring?").ToLower();
            string ring3 = AskForString("What color is the third ring?").ToLower();

            if(ring3 == "gray" || ring3 == "white")
            {
                Console.WriteLine("Invalid color for the third ring!");
            }
            else
            {
                bool b1 = Enum.TryParse(ring1, out Colors ring1C);
                bool b2 = Enum.TryParse(ring2, out Colors ring2C);
                bool b3 = Enum.TryParse(ring3, out Colors ring3C);
                if(b1 && b2 && b3)
                {
                    Console.WriteLine($"The resistance is {((10 * (int)ring1C) + (int)ring2C) * Math.Pow(10, (int)ring3C)} Ohm");
                }
                else
                {
                    Console.WriteLine("Could not parse the given colors.");
                }
            }
        }

        static string AskForString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
