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
        protected int _raum_flaeche;   // in qm
        protected static int _raum_kapazitaet;
        protected Regal[] regal = new Regal[_raum_kapazitaet];

        public Raum()
        {

        }

        public Raum(string rb, int rf)
        {

        }

    }
    internal class Verkauf : Raum
    {
        public Verkauf()
        {
            _raum_bezeichnung = "Ladenfläche";
        }
    }
    internal class Lager : Raum
    {
        public Lager()
        {
            _raum_bezeichnung = "Lagerfläche";
        }
    }
}
