using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilialSimulation_Actor_ConsoleApplication
{
    class Kasse  // soll den Umsatz berechnen für jeden Kunden
                 // für den ganzen Tag 
                 // Bestandsabfragen ( pro Regal) ermöglichen
                 // Schwund ermitteln 
    {
        // Attribute
        private double kunde_umsatz;
        private double tages_umsatz;
        public bool offen;
        private Warenkatalog wkatalog;

        // Methoden

        public Kasse(ref Warenkatalog wkatalog)
        {
            offen = true;
            kunde_umsatz = 0.0;
            tages_umsatz = 0.0;
            Console.WriteLine("Kasse ist geöffnet");
        }

        public double kunde_abrechnen(Einkaufszettel ekw)
        {
            kunde_umsatz = 0.0;
            for (int i = 0; i < ekw.liste.Count; i++)
            {
                Console.WriteLine("FilialSimulation_ConsoleApplication.Artikel {0,3}, {1,3} mal a {2,4:F2} Euro", ekw.liste[i].artikel, ekw.liste[i].anzahl, Warenkatalog.warenkatalog[i].artikel_preis);
                kunde_umsatz += ekw.liste[i].anzahl * Warenkatalog.warenkatalog[i].artikel_preis;



            }
            tages_umsatz += kunde_umsatz;
            return kunde_umsatz;
        }

        public Einkaufszettel nachfuellen_anfordern()
        {
            return new Einkaufszettel();
        }

        public Einkaufszettel fehlbestand_anzeigen()
        {
            return new Einkaufszettel();
        }
    }
}