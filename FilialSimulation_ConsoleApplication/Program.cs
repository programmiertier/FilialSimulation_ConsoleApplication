using System;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    
    class Program
    {
        static Artikel[] warenkatalog = new Artikel[]
        {
              new Artikel(1, 1.99, 0.12),   // id, preis, volumen
              new Artikel(2, 23.00, 0.1),
              new Artikel(3, 2.25, 0.2),
              new Artikel(4, 1.66, 0.12),
              new Artikel(5, 5.30, 0.20),

        };
        
        static Regal[] erstesregal = new Regal[]
        {
            new Regal(1, )
        };

        

        static void Main()
        {
            WriteLine("Hier kommt der Warenkatalog:");
            for (int dieID = 0; dieID < warenkatalog.Length; dieID++)
            {
                Artikel temp = new Artikel(dieID, warenkatalog);
            }

            ReadLine();
        }
    }
}