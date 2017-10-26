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
            Verkauf hierwirdeingekauft = new Verkauf("VerkaufsRaumBesondersToll", 400.0, ref Warenkatalog.warenkatalog);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);            // alle Regale

            FilialSimulation_Actor_ConsoleApplication.Kunde huber = new FilialSimulation_Actor_ConsoleApplication.Kunde();
            huber.wareEntnehmen(hierwirdeingekauft);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);
            ReadLine();
            FilialSimulation_Actor_ConsoleApplication.Personal meier = new FilialSimulation_Actor_ConsoleApplication.Personal();
            meier.wareEntnehmen(hierwirdeingekauft);
            FilialSimulation_Actor_ConsoleApplication.Kasse leer = new FilialSimulation_Actor_ConsoleApplication.Kasse(ref wkatalog);
            

            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);

        }
    }
}