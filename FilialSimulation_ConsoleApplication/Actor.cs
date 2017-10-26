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

            public zeile(int i, int j)
            {
                art = i;
                anz = j;
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

        public virtual void bezahlen(ref Kasse ks)
        {
            Console.WriteLine("Der Actor zahlt für");
            // this.Liste_zeigen();
        }

        public Einkaufszettel wareEntnehmen(FilialSimulation_ConsoleApplication.Raum verkaufenderRaum)
        {
            Einkaufszettel einkaufswagen = new Einkaufszettel("Einkaufswagen");
            for (int i = 0; i < _einkaufsliste.liste.Count; i++)
            {

                WriteLine("Auf dem Zettel{0} FilialSimulation_ConsoleApplication.Artikel {1,3} soll {2,3} mal gekauft werden", i, _einkaufsliste.liste[i].artikel, _einkaufsliste.liste[i].anzahl);
                if (verkaufenderRaum.regale[_einkaufsliste.liste[i].artikel].regal_aktuellerInhalt >= _einkaufsliste.liste[i].anzahl)
                { // genug im Regal
                    WriteLine("genug da");
                    verkaufenderRaum.regale[_einkaufsliste.liste[i].artikel].regal_aktuellerInhalt -= _einkaufsliste.liste[i].anzahl;                    // einkaufswagen.liste.Add = // wunsch
                    einkaufswagen.liste.Add(_einkaufsliste.liste[i]);
                }
                else
                { // zu wenig im Regal, alles was noch da ist
                    Console.WriteLine("zu wenig da, Regal wird leer gemacht");
                    einkaufswagen.liste.Add(new Einkaufszettel.zeile(i, verkaufenderRaum.regale[_einkaufsliste.liste[i].artikel].regal_aktuellerInhalt));
                    verkaufenderRaum.regale[_einkaufsliste.liste[i].artikel].regal_aktuellerInhalt = 0;
                    //          einkaufswagen.liste.Add(new Einkaufszettel.zeile(i, r.regale[_einkaufsliste.liste[i].FilialSimulation_ConsoleApplication.Artikel].aktuellerInhalt));

                }
                //    Console.WriteLine("Im Wagen lfdNr: {0},FilialSimulation_ConsoleApplication.ArtikelNr:{1}, Anzahl:{2}", i, _einkaufsliste.liste[i].FilialSimulation_ConsoleApplication.Artikel, _einkaufsliste.liste[i].anzahl);
                verkaufenderRaum.regale[_einkaufsliste.liste[i].artikel].regal_nachfuellen = verkaufenderRaum.regale[_einkaufsliste.liste[i].artikel].regal_aktuellerInhalt <= verkaufenderRaum.regale[_einkaufsliste.liste[i].artikel]._regal_mindestBestand;
            }
            WriteLine("Im Wagen sind {0} verschiedene FilialSimulation_ConsoleApplication.Artikel ", einkaufswagen.liste.Count);
            return einkaufswagen;   // wegen Änderung der Rückgabe von void auf Einkaufszettel
        }
    }
}