using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    class Actor
    {
        public struct zeile
        {
            int art;
            int anz;

            public zeile(int eins, int zwei)
            {
                art = eins;
                anz = zwei;
            }
        }
        static public int lfrNr;
        protected Einkaufszettel _einkaufsliste;
        protected Einkaufszettel _einkaufswagen;
        protected int id;
        private int rolle;

        public Einkaufszettel einkaufsliste
        {
            get
            {
                return _einkaufsliste;
            }

            set
            {
                _einkaufsliste = value;
            }
        }

        public Einkaufszettel einkaufswagen
        {
            get
            {
                return _einkaufswagen;
            }

            set
            {

            }
        }

        public Actor()
        {
            lfrNr++;
            _einkaufsliste = new Einkaufszettel();
            WriteLine("Es wurde zuerst ein Einkaufszettel erstellt");
        }

        ~Actor()
        {

        }

        public void Liste_zeigen()
        {
            _einkaufsliste.zeigen();
        }

        public virtual void bezahlen()
        {
            Console.WriteLine("Der Actor zahlt für");
            // this.Liste_zeigen();
        }

        public void wareEntnehmen(FilialSimulation_ConsoleApplication.Raum verkaufenderRaum)
        {
            Einkaufszettel einkaufswagen = new Einkaufszettel("Einkaufswagen");     // wird durch set vom _einkaufswagen durchlaufen
            for (int zaehler = 0; zaehler < _einkaufsliste.liste.Count; zaehler++)
            {
                WriteLine("Auf dem Zettel {0}: Artikel {1,3} soll {2,3} mal gekauft werden", zaehler, _einkaufsliste.liste[zaehler].artikel, _einkaufsliste.liste[zaehler].anzahl);
                if (verkaufenderRaum.regale[_einkaufsliste.liste[zaehler].artikel].regal_aktuellerInhalt >= _einkaufsliste.liste[zaehler].anzahl)
                { // genug im Regal
                    WriteLine("genug da");
                    verkaufenderRaum.regale[_einkaufsliste.liste[zaehler].artikel].regal_aktuellerInhalt -= _einkaufsliste.liste[zaehler].anzahl;                    // einkaufswagen.liste.Add = // wunsch
                    einkaufswagen.liste.Add(_einkaufsliste.liste[zaehler]);
                }
                else
                { // zu wenig im Regal, alles was noch da ist
                    WriteLine("zu wenig da, Regal wird leer gemacht");

                    //   einkaufswagen.liste.Last().anzahl = r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt;
                    verkaufenderRaum.regale[_einkaufsliste.liste[zaehler].artikel].regal_aktuellerInhalt = 0;

                }
                //    Console.WriteLine("Im Wagen lfdNr: {0},ArtikelNr:{1}, Anzahl:{2}", i, _einkaufsliste.liste[i].artikel, _einkaufsliste.liste[i].anzahl);
                verkaufenderRaum.regale[_einkaufsliste.liste[zaehler].artikel].regal_nachfuellen = verkaufenderRaum.regale[_einkaufsliste.liste[zaehler].artikel].regal_aktuellerInhalt <= verkaufenderRaum.regale[_einkaufsliste.liste[zaehler].artikel]._regal_mindestBestand;
            }
            WriteLine("Im Wagen sind {0} verschiedene Artikel ", einkaufswagen.liste.Count);
        }
    }
}