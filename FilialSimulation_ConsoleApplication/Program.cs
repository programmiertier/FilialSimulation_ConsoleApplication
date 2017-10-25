using System;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Warenkatalog wkatalog = new Warenkatalog();
            // Verkauf einVerkauf = new Verkauf(); // ruft leeren Konstruktor auf
            Verkauf hierwirdeingekauft = new Verkauf("VerkaufsRaumBesondersToll", 400.0, ref wkatalog.warenkatalog);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal);            // alle Regale
            // ReadLine();

            // hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 7);      // genau 1 Regal
            // ReadLine();

            // hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 1, 20);    // ein Bereich von bis

            /* Lager lagerraum = new Lager();
            Lager apfellager = new Lager("ApfelkuchenBitteHier", 240.0);
            apfellager.anzeigen();*/

            // einkaufen testen
            // hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 4);   // Regal 4 aufrufen
            // hierwirdeingekauft.schnurzipupsregal[4].regal_aktuellerInhalt -= 20;    // 20 aus Regal 4 entnehmen
            // hierwirdeingekauft.anzeigen(hierwirdeingekauft.schnurzipupsregal, 4);   // Regal 4 nochmal zur Kontrolle aufrufen
            ReadLine();

            FilialSimulation_Actor_ConsoleApplication.Actor meier = new FilialSimulation_Actor_ConsoleApplication.Actor();
            meier.wareEntnehmen();


        }
    }
}