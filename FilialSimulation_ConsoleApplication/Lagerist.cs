using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Lagerist : Personal
    {
        public Lagerist()
        {
            this.id = Actor.lfrNr;
            WriteLine("Ich bin Lagerist mit der Nummer {0}", id);
        }

        public void umlagern(Einkaufszettel zettel, ref FilialSimulation_ConsoleApplication.Lager lager, ref FilialSimulation_ConsoleApplication.Verkauf verkauf)
        {
            WriteLine("Lagerist.umlagern(Aufragsliste) startet");
            WriteLine("Es liegen Anforderungen für {0} Artikel vor", zettel.liste.Count);

            Einkaufszettel rollwagen = new Einkaufszettel("Rollwagen");
            double lastenanfordern = 0;
            double lastenumgefuellt = 0;
            for (int zaehler = 0; zaehler < zettel.liste.Count; zaehler++)
            {
                lastenanfordern += zettel.liste[zaehler].anzahl * Warenkatalog.warenkatalog[zettel.liste[zaehler].artikel].artikel_volumen;
                if (lager.regale[zettel.liste[zaehler].anzahl].regal_aktuellerInhalt >= zettel.liste[zaehler].anzahl)
                {
                    {
                        WriteLine("Im Lager war genug vom Artikel {0}", zettel.liste[zaehler].artikel);
                    }
                    lager.regale[zettel.liste[zaehler].artikel].regal_aktuellerInhalt -= zettel.liste[zaehler].anzahl;
                    rollwagen.liste.Add(zettel.liste[zaehler]);
                }

                else
                {
                    {
                        WriteLine("zu wenig da, Regal {0} wird geleert", zettel.liste[zaehler].artikel);
                    }
                    rollwagen.liste.Add(new Einkaufszettel.zeile(zaehler, lager.regale[zettel.liste[zaehler].artikel].regal_aktuellerInhalt));
                    lager.regale[zettel.liste[zaehler].artikel].regal_aktuellerInhalt = 0;
                }
            }

            for (int zaehler = 0; zaehler < rollwagen.liste.Count; zaehler++)
            {
                lastenumgefuellt += rollwagen.liste[zaehler].anzahl * Warenkatalog.warenkatalog[rollwagen.liste[zaehler].artikel].artikel_volumen;
                lager.regale[rollwagen.liste[zaehler].artikel].regal_aktuellerInhalt -= rollwagen.liste[zaehler].anzahl;
                verkauf.regale[rollwagen.liste[zaehler].artikel].regal_aktuellerInhalt += rollwagen.liste[zaehler].anzahl;
            }
            WriteLine("Ich habe {0} cbm vom geforderten {1} umgeladen", lastenumgefuellt, lastenanfordern);
            ReadLine();
        }

        public override void bezahlen(ref Kasse ks)
        {
            base.bezahlen(ref ks);
        }

        ~Lagerist()
        {

        }
        // Attribute
        // Auftragsliste    Einkaufszettel  auftragsliste

        // Methoden
        // Auftragsliste abarbeiten
        // - aus dem Lager entnehmen    (daszu muss ein Lager da sein)
        // - in Verkauf einfüllen
    }
}