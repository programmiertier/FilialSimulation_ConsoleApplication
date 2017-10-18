using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    internal class Raum
    {
        protected string _raum_bezeichnung;
        protected double _raum_flaeche;   // in qm
        protected static int _raum_anzahlRegale;
        protected bool _raum_kundenErlaubt;

        protected Regal[] schnurzipupsregal = new Regal[_raum_anzahlRegale];

        public int raum_anzahlRegale
        {
            get
            {
                return _raum_anzahlRegale;
            }

            set
            {
                _raum_anzahlRegale = value;
            }
        }

        public string raum_bezeichnung
        {
            get
            {
                return _raum_bezeichnung;
            }

            set
            {
                _raum_bezeichnung = value;
            }
        }

        public double raum_flaeche
        {
            get
            {
                return _raum_flaeche;
            }

            set
            {
                _raum_flaeche = value;
            }
        }

        public bool raum_kundenErlaubt
        {
            get
            {
                return _raum_kundenErlaubt;
            }

            set
            {
                _raum_kundenErlaubt = value;
                if (value == true)
                { Write("erlaubt"); }
                else
                { Write("nicht erlaubt"); }
            }
        }

        public Raum()
        {
            WriteLine("Leerer Konstruktor der Mutterklasse");
        }

        public Raum(string bezeichnung, int anzahlRegale, double flaeche, bool kundenErlaubt)
        {
            raum_bezeichnung = bezeichnung;
            raum_anzahlRegale = anzahlRegale;
            raum_flaeche = flaeche;
            raum_kundenErlaubt = kundenErlaubt;
        }
    }

    internal class Verkauf : Raum
    {
        public Verkauf(string bezeichnung, int anzahlRegale, double flaeche, bool kundenErlaubt) : base(bezeichnung, anzahlRegale, flaeche, kundenErlaubt)
        {
            // wert, der gelesen werden soll, MUSS rechts vom = stehen
            WriteLine("Mein Verkaufsraum heißt {0}\nEs sind {1} Regale vorhanden\nmeine Fläche beträgt\t{2}qm\nKunden sind {3}\n", bezeichnung, anzahlRegale, flaeche, kundenErlaubt);
        }

        public Verkauf()
        {
            WriteLine("Hier ist der leere Verkaufsraum");
        }
    }

    internal class Lager : Raum
    {
        public Lager(string bezeichnung, int anzahlRegale, double flaeche, bool kundenErlaubt) : base(bezeichnung, anzahlRegale, flaeche, kundenErlaubt)
        {
            WriteLine("Mein Lagerraum heißt {0}\nEs sind {1} Regale vorhanden\nmeine Fläche beträgt\t{2}qm\nKunden {3}", bezeichnung, anzahlRegale, flaeche, kundenErlaubt);
        }
        
        public Lager()
        {
            WriteLine("Ein leeres Lager, ganz ohne Parameterliste im Konstruktor");
        }
    }
}
