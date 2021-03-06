﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

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
        public double zwischensumme;

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
                kunde_umsatz += ekwagen.liste[zaehler].anzahl * Warenkatalog.warenkatalog[ekwagen.liste[zaehler].artikel].artikel_preis;
            }   // if(this.)
            tages_umsatz += kunde_umsatz;
            WriteLine("Warenwert ist:\t{0} Euro", kunde_umsatz);
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
            WriteLine("kasse.fehlbestand_anzeigen(namedesraums)");
            Einkaufszettel arbeitsliste = new Einkaufszettel("Lagerist");
            /* for (int zaehler = 0; zaehler < verkaufdort.regale.Length; zaehler ++)
            {
                if (verkaufdort.regale[zaehler].regal_nachfuellen == true)
                {
                    // WriteLine("Regal{0} muss aufgefüllt werden", zaehler);
                    // WriteLine("Es fehlen zur maximalen Füllung {0} Einheiten", verkaufdort.regale[zaehler].regal_kapazitaet - verkaufdort.regale[zaehler].regal_aktuellerInhalt);
                    WriteLine("Regal {0} muss gefüllt werden ", zaehler);
                    WriteLine("Es fehlt zum Maximalbestand {0} Einheiten", verkaufdort.regale[zaehler].regal_kapazitaet - verkaufdort.regale[zaehler].regal_aktuellerInhalt);
                    arbeitsliste.liste.Add(new Einkaufszettel.zeile() { artikel = zaehler, anzahl = verkaufdort.regale[zaehler].regal_kapazitaet - verkaufdort.regale[zaehler].regal_aktuellerInhalt });
                }
            } */

            var fehlliste = from inhalt in verkaufdort.regale
                            where inhalt.regal_nachfuellen
                            select new
                            {
                                id = inhalt.regal_id,
                                menge = inhalt.regal_kapazitaet - inhalt.regal_aktuellerInhalt
                            };

            foreach(var item in fehlliste)
            { arbeitsliste.liste.Add(new Einkaufszettel.zeile(item.id, item.menge));
                WriteLine("Artikel: {0,4}, fehlt {1,3} mal", item.id, item.menge);
            }
            // fehldende Menge zum Maximalbestand

            // max - rest
            // return new Einkaufszettel("Fehlliste");
            WriteLine("{0}", arbeitsliste);
            return arbeitsliste;
        }

        public double warenwertAnzeigen(FilialSimulation_ConsoleApplication.Raum irgendwo)
        {
            double gesamterWert = 0;
            var warenwert = from inhalt in irgendwo.regale
                             select inhalt.regal_aktuellerWert;
            gesamterWert = warenwert.Sum();
            /* foreach (var item in gesamtwert)
            {
                // WriteLine("{0}", item);    // zeigt mir jeden Artikel
                gesamterWert += item;
                {
                        WriteLine("{0}", item);
                }
            } */
            WriteLine("Gesamtwert der Waren im Raum: {0}", gesamterWert);
            return gesamterWert;
        }

        public double momentanWert(FilialSimulation_ConsoleApplication.Raum irgendwosonst)
        {
            double gesamtWert = 0;
            var warenwert = from inhalt in irgendwosonst.regale select inhalt.regal_aktuellerWert;
            gesamtWert = warenwert.Sum();
            return gesamtWert;
        }
    }
}