using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            PresentQuestion("2 + 8 - 10 * 2 / 10", "6", "12", "8", "3", ConsoleColor.Green, ConsoleColor.Black);
            score += HandleInput("c");

            PresentQuestion("(false || true) && false", "true", "false", "error", "trualse", ConsoleColor.Black, ConsoleColor.Gray);
            score += HandleInput("b");

            PresentQuestion("a ,b ,c of d?", "c", "b", "d", "a", ConsoleColor.Yellow, ConsoleColor.DarkGray);
            score += HandleInput("d");

            Console.WriteLine("Voltooid!");
            Console.WriteLine($"Uw eindscore is: {score}");
        }

        static int HandleInput(string correctAnswer)
        {
            Console.WriteLine("Uw antwoord:");
            string answer = Console.ReadLine().ToLower();

            if(answer == correctAnswer)
            { 
                return 2;
            }
            else
            {
                return -1;
            }
        }

        static void PresentQuestion(string q, string a, string b, string c, string d, ConsoleColor foreGround, ConsoleColor backGround)
        {
            Console.ForegroundColor = foreGround;
            Console.BackgroundColor = backGround;

            Console.WriteLine(q);
            Console.WriteLine(new string('#', 20));
            Console.WriteLine($"a) {a}");
            Console.WriteLine($"b) {b}");
            Console.WriteLine($"c) {c}");
            Console.WriteLine($"d) {d}");

            Console.ResetColor();
        }
    }
}
