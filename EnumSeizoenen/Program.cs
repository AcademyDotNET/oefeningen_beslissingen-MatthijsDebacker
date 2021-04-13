using System;

namespace EnumSeizoenen
{
    class Program
    {
        enum Seizoenen
        {
            Winter,
            Lente,
            Zomer,
            Herfst
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een maandnummer: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Seizoenen seizoen = new Seizoenen();

            switch (month)
            {
                case 1:
                case 2:
                    seizoen = Seizoenen.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    seizoen = Seizoenen.Lente;
                    break;
                case 6:
                case 7:
                case 8:
                    seizoen = Seizoenen.Zomer;
                    break;
                case 9:
                case 10:
                case 11:
                    seizoen = Seizoenen.Herfst;
                    break;
                case 12:
                    seizoen = Seizoenen.Winter;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"De maand ligt in het seizoen: {seizoen}");
            if(seizoen == Seizoenen.Winter || seizoen == Seizoenen.Herfst)
            {
                Console.WriteLine("Dit is een koud seizoen.");
            }
            else
            {
                Console.WriteLine("Dit is een warm seizoen.");
            }
        }
    }
}
