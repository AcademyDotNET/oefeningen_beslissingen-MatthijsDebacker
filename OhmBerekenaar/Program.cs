using System;

namespace OhmBerekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What wil u berekenen? Spanning, weerstand of stroomsterkte?");
            string vraag = Console.ReadLine().ToLower();
            double spanning = 0.0, stroom = 0.0, weerstand = 0.0;

            switch (vraag)
            {
                case "spanning":
                    {
                        weerstand = AskForDouble("Weerstand");
                        stroom = AskForDouble("Stroomsterkte");

                        Console.WriteLine($"Spanning = {(stroom * weerstand):F2}");
                    }
                    break;
                case "weerstand":
                    {
                        spanning = AskForDouble("Spanning");
                        stroom = AskForDouble("Stroomsterkte");

                        Console.WriteLine($"Weerstand = {(spanning / stroom):F2}");
                    }
                    break;
                case "stroomsterkte":
                    {
                        spanning = AskForDouble("Spanning");
                        weerstand = AskForDouble("Weerstand");

                        Console.WriteLine($"Stroomsterkte = {(spanning / weerstand):F2}");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Ik weet niet wat je wil berekenen.");
                    }
                    break;
            }
        }

        static double AskForDouble(string name)
        {
            Console.WriteLine($"{name}: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
