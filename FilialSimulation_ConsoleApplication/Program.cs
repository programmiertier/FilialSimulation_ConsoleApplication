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
            Verkauf hierwirdeingekauft = new Verkauf("VerkaufsRaumBesondersToll", 400.0, wkatalog.warenkatalog);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);            // alle Regale

            FilialSimulation_Actor_ConsoleApplication.Personal meier = new FilialSimulation_Actor_ConsoleApplication.Personal();
            meier.wareEntnehmen(hierwirdeingekauft);
            FilialSimulation_Actor_ConsoleApplication.Dieb mayrhubr = new FilialSimulation_Actor_ConsoleApplication.Dieb();
            mayrhubr.wareEntnehmen(hierwirdeingekauft);
            FilialSimulation_Actor_ConsoleApplication.Kunde baecker = new FilialSimulation_Actor_ConsoleApplication.Kunde();
            baecker.wareEntnehmen(hierwirdeingekauft);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);
            ReadLine();

        }
    }
}