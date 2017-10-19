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
              new Artikel(6, 0.1, 1.66),
              new Artikel(7, 0.15, 1.66),
              new Artikel(8, 0.1, 1.66),
              new Artikel(9, 0.15, 23.00),
              new Artikel(10, 0.12, 2.25)

        };
        
        static void Main()
        {
            /*Regal[] verkauftsraum = new Regal[warenkatalog.Length]; // Speicher für 800, vom Typ Regal
            


            WriteLine("Hier kommt der Warenkatalog:");
            for (int dieID = 0; dieID < warenkatalog.Length; dieID++)
            {
                // Artikel temp = new Artikel(dieID, warenkatalog);
                // Regal temp = new Regal(dieID, warenkatalog);
                verkauftsraum[dieID] = new Regal(dieID, warenkatalog);
            }
            ReadLine();
            // WriteLine("Das Regal hat einen Inhalt von:\t{0}" ,verkauftsraum[4].regal_aktuellerInhalt);
            foreach(Regal r in verkauftsraum)
            {
                Write("{0:D2}\t", r.regal_aktuellerInhalt);
            }
            ReadLine();*/

            // Verkauf einVerkauf = new Verkauf(); // ruft leeren Konstruktor auf
            Verkauf verkaufhier = new Verkauf("VerkaufsRaumBesondersToll", 400.0, warenkatalog);
            verkaufhier.anzeigen(verkaufhier.schnurzipupsregal);
            // Regale des Verkaufsraumes anzeigen
            // ein bestimmtes Regal
            // alle Regale

            // Lager lagerraum = new Lager();
            /*Lager apfellager = new Lager("ApfelkuchenBitteHier", 240.0);
            apfellager.anzeigen();*/

            ReadLine();
        }
    }
}