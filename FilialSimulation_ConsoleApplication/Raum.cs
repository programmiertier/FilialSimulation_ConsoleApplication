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

        public Raum()
        {
            WriteLine("Leerer Konstruktor der Mutterklasse");
        }
    }

    internal class Verkauf : Raum
    {
        public string verkaufsraumbezeichnung;

        public Verkauf(string verkaufsraumbezeichnung)
        {
            _raum_bezeichnung = verkaufsraumbezeichnung;    // wert, der gelesen werden soll, MUSS rechts vom = stehen
            WriteLine("Mein Verkaufsraum heißt {0}", verkaufsraumbezeichnung);
        }

        public Verkauf()
        {
            WriteLine("Hier ist der leere Verkaufsraum");
        }
    }

    internal class Lager : Raum
    {
        public string lagerbezeichnungweilname;

        public Lager(string lagerbezeichnungweilname)
        {
            _raum_bezeichnung = lagerbezeichnungweilname;
            WriteLine("Mein Name ist {0}", lagerbezeichnungweilname);
        }
        
        public Lager()
        {
            WriteLine("Ein leeres Lager, ganz ohne Parameterliste im Konstruktor");
        }
    }
}
