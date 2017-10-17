using System;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    class Program
    {
        static Artikel[] warenkatalog = new Artikel[]
          {
              new Artikel(1, 1.99, 0.12),
              new Artikel(2, 23.00, 11.1),
              new Artikel(3, 2.25, 3),
              new Artikel(4, 1.66, 3.12),
              new Artikel(5, 5.30, 8.10),

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