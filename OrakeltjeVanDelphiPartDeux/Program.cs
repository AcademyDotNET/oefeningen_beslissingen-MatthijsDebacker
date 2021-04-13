using System;

namespace OrakeltjeVanDelphiPartDeux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is jou naam?");
            Console.ReadLine();

            Console.WriteLine("Bent u een vrouw of een man? (m/v)");
            string mv = Console.ReadLine().ToLower();

            Console.WriteLine("Wat is u leeftijd?");
            int age = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int prediction = 0;

            if(mv == "v")
            {
                prediction = r.Next(5, 151 - age);
            }
            else if(mv == "m")
            {
                prediction = r.Next(5, 121 - age);
            }

            Console.Write($"Je zal nog {prediction} jaar leven!");
        }
    }
}
