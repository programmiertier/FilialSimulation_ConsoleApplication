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
            // Verkauf einVerkauf = new Verkauf(); // ruft leeren Konstruktor auf
            Verkauf hierwirdeingekauft = new Verkauf("VerkaufsRaumBesondersToll", 400.0, warenkatalog);
            // hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal);            // alle Regale
            ReadLine();

            // hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 7);      // genau 1 Regal
            ReadLine();

            // hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 1, 3);    // ein Bereich von bis

            /* Lager lagerraum = new Lager();
            Lager apfellager = new Lager("ApfelkuchenBitteHier", 240.0);
            apfellager.anzeigen();*/

            // einkaufen testen
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 4);   // Regal 4 aufrufen
            hierwirdeingekauft.schnurzipupsregal[4].regal_aktuellerInhalt -= 20;    // 20 aus Regal 4 entnehmen
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 4);   // Regal 4 nochmal zur Kontrolle aufrufen
            ReadLine();

        }
    }
}