using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Actor
    {
        protected int id;
        private static int instances = 0;
        private string _rolle = "Actor";
        private Einkaufszettel _einkaufsliste;
        static public int lfrNr;
        protected Einkaufszettel _einkaufswagen;

        public struct zeile
        {
            int art;
            int anz;
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

        public Einkaufszettel einkaufsliste
        {
            get
            {
                return _einkaufsliste;
            }

            set
            {

            }
        }

        /* public Actor()
        {
            _einkaufsliste = new Einkaufszettel();
            instances++;
            _id = instances;
            if (this.GetType() == typeof(Kunde))
            {
                _rolle = "Kunde";
            }
            if (this.GetType() == typeof(Personal))
            {
                _rolle = "Personal";
            }
            if (this.GetType() == typeof(Dieb))
            {
                _rolle = "Dieb";
            }
        } */

        public Actor()
        {
            lfrNr++;
            _einkaufsliste = new Einkaufszettel();
            WriteLine("Zuerst geht es durch den leeren Konstruktor vom Actor");
        }

        ~Actor()
        {
            
        }

        public void listeAnzeigen()
        {
            // WriteLine("Person {0} hat die Rolle {1}", _id, _rolle);
            einkaufsliste.zeigen();
            ReadLine();
        }

        public virtual void bezahlen()
        {
            WriteLine("Der Actor zahlt für");
            // this.listeAnzeigen();
        }
        


        public void wareEntnehmen()
        {
            Einkaufszettel einkaufswagen = new Einkaufszettel("Einkaufswagen");
            for (int zaehler = 0; zaehler < einkaufsliste.liste.Count; zaehler++)
            {
                
                WriteLine("Auf dem Zettel:\t{0}\tArtikel\t\t{1,3} soll\t{2,3} mal gekauft werden", zaehler, einkaufsliste.liste[zaehler].artikel, einkaufsliste.liste[zaehler].anzahl);
                //            if(  >  )
                //             { // genug im Regal

                // einkaufswagen.liste.Add = // wunsch
                // Verkauf[xx].   -= wunsch;
                //              }
                //              else
                //              { // zu wenig im Regal, alles was noch da ist
                // einkaufswagen.liste. = // Verkauf[xx].
                // Verkauf[xx].   = 0;
                //     
                WriteLine("Im Wagen lfdNr:\t{0}\tArtikelNr:\t{1,3}, Anzahl:\t{2,3}", zaehler, einkaufsliste.liste[zaehler].artikel, einkaufsliste.liste[zaehler].anzahl);
                einkaufswagen.liste.Add(_einkaufsliste.liste[zaehler]);
                WriteLine();
            }
            WriteLine("Im Wagen sind {0} verschiedene Artikel ", einkaufswagen.liste.Count);
            WriteLine("-----");
            ReadLine();
        }
    }
}
