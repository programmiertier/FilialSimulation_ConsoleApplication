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
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.dummyregal);            // alle Regale

            FilialSimulation_Actor_ConsoleApplication.Actor meier = new FilialSimulation_Actor_ConsoleApplication.Actor();
            meier.wareEntnehmen(hierwirdeingekauft);
            ReadLine();

        }
    }
}