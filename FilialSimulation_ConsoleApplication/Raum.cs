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
        protected int _raum_anzahlRegale;
        protected string _raum_bezeichnung;
        protected double _raum_flaeche;
        protected bool _raum_kundenErlaubt;
        protected Regal[] _regale;

        public Raum()
        {

        }

        public Raum(string b, double flaeche)
        {
            raum_bezeichnung = b;
            _raum_flaeche = flaeche;

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

        public Regal[] regale
        {
            get
            {
                return _regale;
            }

        }

        public void anzeigen(Regal[] platzhalterregal)
        { anzeigen(platzhalterregal, 0, platzhalterregal.Length - 1); }

        public void anzeigen(Regal[] platzhalterregal, int einzelnesRegal)
        { anzeigen(platzhalterregal, einzelnesRegal, einzelnesRegal); }

        public void anzeigen(Regal[] platzhalterregal, int von, int bis)
        {
            Display.darstellen(platzhalterregal, von, bis);

        }
    }
    internal class Verkauf : Raum
    {
        private int _anzahlKunden;

        public Verkauf()
        {

        }

        public Verkauf(string b, double flaeche, Artikel[] wkatalog) : base(b, flaeche)
        {
            _raum_kundenErlaubt = true;
            raum_anzahlRegale = (int)(flaeche / 0.5);
            _regale = new Regal[wkatalog.Length];
            for (int zaehler = 0; zaehler < wkatalog.Length /*anzahlRegale */; zaehler++)
            { _regale[zaehler] = new Regal(zaehler, wkatalog); }
        }
        public int anzahlKunden
        {
            get
            {
                return _anzahlKunden;
            }

            set
            {
            }
        }
    }
    internal class Lager : Raum
    {
        public Lager()
        {

        }
        public Lager(string b, double flaeche) : base(b, flaeche)
        {
            _raum_kundenErlaubt = false;
            raum_anzahlRegale = (int)(flaeche / 0.33);
        }
    }
}