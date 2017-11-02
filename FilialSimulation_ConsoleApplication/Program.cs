using System;
using System.Linq;
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
            Lager lagerraum = new Lager("gemeinsamer Keller in Ossendorf", 240.0, ref Warenkatalog.warenkatalog);

            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);

            WriteLine("Wert aller Regale bei der Eröffnung: {0}", kasse.momentanWert(hierwirdeingekauft));
            ReadLine();

            // gesucht werden alle Regal-IDs, wo die Regale mehr wert sind als 500 Euro
            var mehrAls500Wert = from inhalt in hierwirdeingekauft.regale where inhalt.regal_aktuellerWert > 500 select inhalt.regal_id;
            foreach(var item in mehrAls500Wert)
            {
                WriteLine("Das Regal {0} ist mehr als 500 Euro wert", item);
            }

            
            FilialSimulation_Actor_ConsoleApplication.Kunde friedrich = new FilialSimulation_Actor_ConsoleApplication.Kunde();
            friedrich.einkaufswagen = friedrich.wareEntnehmen(hierwirdeingekauft);
            friedrich.bezahlen(ref kasse);

            FilialSimulation_Actor_ConsoleApplication.Personal heinrich = new FilialSimulation_Actor_ConsoleApplication.Personal();
            heinrich.einkaufswagen = heinrich.wareEntnehmen(hierwirdeingekauft);
            heinrich.bezahlen(ref kasse);
            FilialSimulation_Actor_ConsoleApplication.Lagerist paul = new FilialSimulation_Actor_ConsoleApplication.Lagerist();
            paul.umlagern(kasse.fehlbestand_anzeigen(hierwirdeingekauft), ref lagerraum, ref hierwirdeingekauft);

            hierwirdeingekauft.anzeigen(hierwirdeingekauft.regale);
            ReadLine();
            kasse.fehlbestand_anzeigen(hierwirdeingekauft);

            WriteLine("Wert aller Regale: {0}", kasse.momentanWert(hierwirdeingekauft));


            ReadLine();
        }
    }
}