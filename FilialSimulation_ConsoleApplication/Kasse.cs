using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    class Kasse  // soll den Umsatz berechnen für jeden Kunden
                 // für den ganzen Tag
                 // Bestandsabfragen (pro Regal) ermöglichen
                 // Schwund ermitteln 
    {
        // Attribute
        private double kunde_umsatz;
        private double tages_umsatz;
        public bool offen;

        // Methoden
        public Kasse(ref Warenkatalog wkatalog)
        {
            offen = true;
            kunde_umsatz = 0.0;
            tages_umsatz = 0.0;
            WriteLine("Kasse ist geöffnet");
        }

        public double kunde_abrechnen(Einkaufszettel ekw)
        {
            // für jeden Artikel im Einkaufswagen muss der passende Preis ermittelt werden (aus warenkatalog)
            kunde_umsatz = 0.0;
            for (int zaehler = 0; zaehler < ekw.liste.Count; zaehler++) // durch den Einkaufswagen mit Schleife
            {
                WriteLine("Artikel {0,3}, {1,3}mal Einzelpreis:{2,4:F2} Euro", ekw.liste[zaehler].artikel, ekw.liste[zaehler].anzahl, Warenkatalog.warenkatalog[zaehler].artikel_preis);
                kunde_umsatz += ekw.liste[zaehler].anzahl * Warenkatalog.warenkatalog[zaehler].artikel_preis+2.5;
            }   // if(this.)
            tages_umsatz += kunde_umsatz;
            return kunde_umsatz;    // Kasse meldet den Actor den Preis
        }

        public Einkaufszettel nachfuellen_anfordern()
        {
            return new Einkaufszettel();
        }

        public Einkaufszettel fehlbestand_anzeigen()
        {
            // über alle Regale wandern und jedes mit 'nachfüllen' = true
            // in die Fehlliste eintragen

            // for oder foreach (==true)

            // fehldende Menge zum Maximalbestand

            // max - rest
            return new Einkaufszettel("Fehlliste");
        }
    }
}