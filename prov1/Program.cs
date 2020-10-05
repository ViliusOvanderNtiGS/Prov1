using System;

namespace prov1
{
    class Program
    {
        static void Main(string[] args)
        {

            int skott = 0;
            string boom = "";
            bool succ = false;


            Console.WriteLine("sänka skepp");
            Console.WriteLine("skriv in en kordinat mellan 1-10");

            while (!succ)
            {
                boom = Console.ReadLine();
                succ = int.TryParse(boom, out skott);
                if (!succ)
                {
                    Console.WriteLine("Det där är inte en siffra");
                }
                else if (skott > 10 || skott < 1)
                {
                    Console.WriteLine("skriv en kordinat mellan 1-10");
                }
            }

            while (skott != 7)
            {
                Console.WriteLine("Miss!");
                Console.WriteLine("testa ingen, skriv en kordinat mellan 1-10");
                Console.ReadLine();
            }

            if (skott == 7)
            {
                Console.WriteLine("Träff!");
                Console.WriteLine("Tryck Enter för att stänga ner");
                Console.ReadLine();
            }

            //man kan bara skriv svaret rätt första gången









        }

    }
}
