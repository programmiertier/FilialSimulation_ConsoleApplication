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
        public Regal[] _regale;

        public Regal[] dummyregal = new Regal[_raum_anzahlRegale];

        public Regal[] regale
        {
            get
            {
                return _regale;
            }

        }

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

        public void anzeigen(Regal[] dummyregal)
        {
            Display.darstellen(dummyregal, 0, dummyregal.Length - 1);
        }

        public void anzeigen(Regal[] dummyregal, int einzelnesRegal)
        {
            Display.darstellen(dummyregal, einzelnesRegal, einzelnesRegal);
        }

        public void anzeigen(Regal[] dummyregal, int von, int bis)
        {
            Display.darstellen(dummyregal, von, bis);
        }
    }

    internal class Verkauf : Raum
    {
        private int _anzahlKunden;

        public Verkauf()
        {

        }

        /* public Verkauf(string b, double flaeche) : base(b, flaeche)
        {
            _raum_kundenErlaubt = true;
            raum_anzahlRegale = (int)(flaeche / 0.5);
        } */

        public Verkauf(string b, double flaeche, ref Artikel[] wkatalog) : base(b, flaeche)
        {
            _raum_kundenErlaubt = true;
            raum_anzahlRegale = (int)(flaeche / 0.5);

            dummyregal = new Regal[wkatalog.Length];
            for(int zaehler = 0; zaehler < wkatalog.Length; zaehler++)
            {
                dummyregal[zaehler] = new Regal(zaehler, wkatalog);
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