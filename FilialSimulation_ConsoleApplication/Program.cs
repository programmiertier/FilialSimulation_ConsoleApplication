using System;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Warenkatalog wkatalog = new Warenkatalog();
            Warenkatalog lagerkatalog = new Warenkatalog();
            // Verkauf einVerkauf = new Verkauf(); // ruft leeren Konstruktor auf
            Verkauf hierwirdeingekauft = new Verkauf("VerkaufsRaumBesondersToll", 400.0, ref Warenkatalog.warenkatalog);
            FilialSimulation_Actor_ConsoleApplication.Kasse kasse = new FilialSimulation_Actor_ConsoleApplication.Kasse(ref wkatalog);
            Lager lager = new Lager("gemeinsamer Keller in Ossendorf", 240.0, ref Warenkatalog.warenkatalog);
            WriteLine("Hier kommt der Keller");
            lager.anzeigen(lager.regale);
            kasse.warenwertAnzeigen(lager);
            ReadLine();
            WriteLine("-----");
            WriteLine("Hier kommt der Verkaufsraum");
            WriteLine("-----");
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);
            kasse.warenwertAnzeigen(hierwirdeingekauft);
            ReadLine();
            FilialSimulation_Actor_ConsoleApplication.Kunde friedrich = new FilialSimulation_Actor_ConsoleApplication.Kunde();
            friedrich.einkaufswagen = friedrich.wareEntnehmen(hierwirdeingekauft);
            friedrich.bezahlen(ref kasse);
            
            ReadLine();
            kasse.fehlbestand_anzeigen(hierwirdeingekauft);
            FilialSimulation_Actor_ConsoleApplication.Lagerist friedhelm = new FilialSimulation_Actor_ConsoleApplication.Lagerist();
            friedhelm.einkaufswagen = friedhelm.wareEntnehmen(hierwirdeingekauft);
            friedhelm.bezahlen(ref kasse);
            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);

            ReadLine();
        }
    }
}