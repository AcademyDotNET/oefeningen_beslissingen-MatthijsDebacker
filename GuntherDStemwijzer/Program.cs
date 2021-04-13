using System;

namespace GuntherDStemwijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!Question("Werk je veel?"))
            {
                if(Question("Eet je vaak Quinoa?"))
                {
                    Console.WriteLine("Stem voor Groen!");
                }
                else
                {
                    if(Question("Krijg je vaak de schuld voor alles?"))
                    {
                        Console.WriteLine("Stem voor SPA!");
                    }
                    else
                    {
                        if(Question("Geloof je nog in Sinterklaas?"))
                        {
                            Console.WriteLine("Stem voor PVDA!");
                        }
                        else
                        {
                            Console.WriteLine("Stem blanco!");
                        }
                    }
                }
            }
            else
            {
                if(Question("Koop je som bruin brood?"))
                {
                    if (Question("Ben je een seut?"))
                    {
                        Console.WriteLine("Stem voor CD&V!");
                    }
                    else
                    {
                        if(Question("Heb je vrienden?"))
                        {
                            if(Question("Staat jouw wagen, huis,.. op naam van jouw ouders?"))
                            {
                                Console.WriteLine("Stem voor OpenVld!");
                            }
                            else
                            {
                                Console.WriteLine("Stem blanco!");
                            }
                        }
                        else
                        {
                            Console.Write("Stem voor NVA!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Stem voor Vlaams Belang!");
                }
            }
        }

        static bool Question(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine().ToLower();

            if(answer == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
