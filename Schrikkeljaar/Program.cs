using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een jaar: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if((year % 4) == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Het is een schrikkeljaar.");
            }
            else
            {
                Console.WriteLine("Het is geen schrikkeljaar.");
            }
        }
    }
}
