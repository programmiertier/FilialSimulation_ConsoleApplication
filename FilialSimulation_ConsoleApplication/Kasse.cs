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

        public double kunde_abrechnen(Einkaufszettel ekwagen)
        {
            // für jeden Artikel im Einkaufswagen muss der passende Preis ermittelt werden (aus warenkatalog)
            kunde_umsatz = 0.0;
            for (int zaehler = 0; zaehler < ekwagen.liste.Count; zaehler++) // durch den Einkaufswagen mit Schleife
            {
                WriteLine("Artikel: {0,3},\t{1,3}mal, mit Einzelpreis:\t{2,4:F2} Euro", ekwagen.liste[zaehler].artikel, ekwagen.liste[zaehler].anzahl, Warenkatalog.warenkatalog[zaehler].artikel_preis);
                kunde_umsatz += ekwagen.liste[zaehler].anzahl * Warenkatalog.warenkatalog[zaehler].artikel_preis+2.5;
            }   // if(this.)
            tages_umsatz += kunde_umsatz;
            return kunde_umsatz;    // Kasse meldet den Actor den Preis
        }

        public Einkaufszettel nachfuellen_anfordern()
        {
            // Auftrag an Personal, die Regale auf der Fehlliste nachzufüllen

            // man benötigt einen Lagerbubi, der angesprochen wird

            // Fehlliste mit der Menge (also das, was bei fehlbestand_anzeigen auf den Bildschirm kommt)
            return new Einkaufszettel();
        }

        public  Einkaufszettel fehlbestand_anzeigen(FilialSimulation_ConsoleApplication.Raum verkaufdort)        // was im Regal fehlt, um wieder voll zu sein
        {
            // über alle Regale wandern und jedes mit 'nachfüllen' = true
            // in die Fehlliste eintragen

            // for oder foreach (==true)
            Einkaufszettel arbeitsliste = new Einkaufszettel("Fehlliste");
            for (int zaehler = 0; zaehler < verkaufdort.regale.Length; zaehler ++)
            {
                if (verkaufdort.regale[zaehler].regal_nachfuellen == true)
                {
                    // WriteLine("Regal{0} muss aufgefüllt werden", zaehler);
                    // WriteLine("Es fehlen zur maximalen Füllung {0} Einheiten", verkaufdort.regale[zaehler].regal_kapazitaet - verkaufdort.regale[zaehler].regal_aktuellerInhalt);
                    arbeitsliste.liste.Add(new Einkaufszettel.zeile() { artikel = zaehler, anzahl = verkaufdort.regale[zaehler].regal_kapazitaet - verkaufdort.regale[zaehler].regal_aktuellerInhalt });

                }
            }

            // fehldende Menge zum Maximalbestand

            // max - rest
            // return new Einkaufszettel("Fehlliste");
            return arbeitsliste;
        }
    }
}