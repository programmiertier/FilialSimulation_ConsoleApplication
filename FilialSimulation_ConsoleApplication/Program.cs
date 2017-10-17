using System;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    
    class Program
    {
        static Artikel[] warenkatalog = new Artikel[]
        {
              new Artikel(0, 0.15, 0.15),
              new Artikel(1, 0.12, 1.99),   // id, preis, volumen
              new Artikel(2, 0.1, 23.00),
              new Artikel(3, 0.2, 2.25),
              new Artikel(4, 0.12, 1.66),
              new Artikel(5, 0.20, 5.30),

        };
        
        static void Main()
        {
            WriteLine("Hier kommt der Warenkatalog:");
            for (int dieID = 0; dieID < warenkatalog.Length; dieID++)
            {
                Regal temp = new Regal(dieID, warenkatalog);        // wenn nur Artikel, dann Artikel statt Regal
            }

            ReadLine();
        }
    }
}