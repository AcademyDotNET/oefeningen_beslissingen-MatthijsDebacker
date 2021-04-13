using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int number = r.Next(1, 6);

            Console.WriteLine("What number between 1 and 6 did I just choose?");
            int guess = Convert.ToInt32(Console.ReadLine());

            if(guess == number)
            {
                Console.WriteLine("IMPOSSIBLE....you won.");
            }
            else
            {
                Console.WriteLine("YOU LOSE!");
            }
        }
    }
}
