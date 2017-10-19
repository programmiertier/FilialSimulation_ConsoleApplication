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

        public Regal[] schnurzipupsregal = new Regal[_raum_anzahlRegale];

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

        }

        public Raum(string b, double flaeche)
        {
            _raum_bezeichnung = b;
            _raum_flaeche = flaeche;
        }

        public void anzeigen(Regal[] schnurzipupsregal)
        {
            WriteLine(GetType().ToString());
            WriteLine("Das Objekt hat folgende Eignschaften ");
            WriteLine("Bezeichnung: {0}\tFläche: {1}", raum_bezeichnung, _raum_flaeche);
            WriteLine("Hier stehen {0} Regale ", raum_anzahlRegale);
            WriteLine("Kunden sind {0} erlaubt", _raum_kundenErlaubt ? "" : "nicht");
            foreach (Regal platzhalter in schnurzipupsregal)
            {
                WriteLine("Im Regal: {0} sind {1} Gegenstände\n", platzhalter.regal_id, platzhalter.regal_aktuellerInhalt);
            }
        }
    }

    internal class Verkauf : Raum
    {
        public Verkauf()
        {

        }

        /*public Verkauf(string b, double flaeche) : base(b, flaeche)
        {
            _raum_kundenErlaubt = true;
            raum_anzahlRegale = (int)(flaeche / .5);
        }*/

        public Verkauf(string b, double flaeche, Artikel[] wkatalog) : base(b, flaeche)
        {
            _raum_kundenErlaubt = true;
            raum_anzahlRegale = (int)(flaeche / 0.5);

            schnurzipupsregal = new Regal[wkatalog.Length];
            for(int zaehler = 0; zaehler < wkatalog.Length; zaehler++)
            {
                schnurzipupsregal[zaehler] = new Regal(zaehler, wkatalog);
            }
        }
    }

    internal class Lager : Raum
    {
        public Lager()
        {

        }

        /*public Lager(string b, double flaeche) : base(b, flaeche)
        {
            _raum_kundenErlaubt = false;
            raum_anzahlRegale = (int)(flaeche / 0.5);
        }*/
    }
}