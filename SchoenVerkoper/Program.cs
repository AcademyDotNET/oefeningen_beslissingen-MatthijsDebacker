using System;

namespace SchoenVerkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vanaf hoeveel schoenen krijg ik korting?");
            int kortingDrempel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel schoenen wenst u te kopen?");
            int aantal = Convert.ToInt32(Console.ReadLine());

            if (aantal < 0)
            {
                Console.WriteLine("Incorrect aantal schoenen.");
            }
            else if (aantal >= 0 && aantal < kortingDrempel)
            {
                Console.WriteLine($"De totale prijs is: {(aantal * 20.0):C}");
            }
            else if (aantal >= kortingDrempel)
            {
                Console.WriteLine($"De total prijs met korting is: {((kortingDrempel * 20.0) + (aantal - kortingDrempel) * 10.0):C}");
            }
        }
    }
}
