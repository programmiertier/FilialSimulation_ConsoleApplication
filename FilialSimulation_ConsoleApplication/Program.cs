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
            FilialSimulation_Actor_ConsoleApplication.Kasse kasse = new FilialSimulation_Actor_ConsoleApplication.Kasse(ref wkatalog);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);            // alle Regale
            FilialSimulation_Actor_ConsoleApplication.Personal martha = new FilialSimulation_Actor_ConsoleApplication.Personal();
            martha.einkaufswagen = martha.wareEntnehmen(hierwirdeingekauft);
            martha.bezahlen(ref kasse);
            ReadLine();
            FilialSimulation_Actor_ConsoleApplication.Kunde paul = new FilialSimulation_Actor_ConsoleApplication.Kunde();
            paul.einkaufswagen = paul.wareEntnehmen(hierwirdeingekauft);
            paul.bezahlen(ref kasse);
            FilialSimulation_Actor_ConsoleApplication.Kunde friedrich = new FilialSimulation_Actor_ConsoleApplication.Kunde();
            friedrich.einkaufswagen = friedrich.wareEntnehmen(hierwirdeingekauft);
            friedrich.bezahlen(ref kasse);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);
            ReadLine();
        }
    }
}