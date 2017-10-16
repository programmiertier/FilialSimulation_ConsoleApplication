using System;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    class Artikel
    {
        int id;
        double volumen;
        double preis;
        
        public Artikel(int meineid, Artikel[] warenkorb)
        {
            WriteLine("Artikel {0} angelegt: ", warenkorb[meineid].id);
            id = warenkorb[meineid].id;
            volumen = warenkorb[meineid].volumen;
            preis = warenkorb[meineid].preis;
            WriteLine("Mit einem Preis von {0:F2} und einem Volumen von {1:F2}", preis, volumen);
        }


        public Artikel(int meineid, double meinpreis, double meinvolumen)
        {
            // WriteLine("Artikel {0} angelegt: ", id);
            id = meineid;
            volumen = meinvolumen;
            preis = meinpreis;
        }


    }
    

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