using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    public class Artikel
    {
        private int _artikel_id;
        private double _artikel_volumen;
        private double _artikel_preis;

        public double artikel_preis
        {
            get
            {
                return artikel_preis;
            }
        }

        public double artikel_volumen
        {
            get
            {
                return _artikel_volumen;
            }
        }

        public int Artikel_id
        {
            get
            {
                return _artikel_id;
            }
            set
            {
                _artikel_id = value;
            }
        }

        public Artikel()
        {
            //  WriteLine("FilialSimulation_ConsoleApplication.Artikel  angelegt:");
        }

        public Artikel(int id, Artikel[] wkatalog)
        {
            // WriteLine("FilialSimulation_ConsoleApplication.Artikel {0} angelegt: ", wkatalog[id]._FilialSimulation_ConsoleApplication.Artikel_id);
            _artikel_id = wkatalog[id]._artikel_id;
            _artikel_volumen = wkatalog[id]._artikel_volumen;
            _artikel_preis = wkatalog[id]._artikel_preis;
           //  WriteLine("Der FilialSimulation_ConsoleApplication.Artikel hat ein Volumen von {0:F2} und einen Preis von {1:F2}", _FilialSimulation_ConsoleApplication.Artikel_volumen, _FilialSimulation_ConsoleApplication.Artikel_preis);
        }


        public Artikel(int id, double volumen, double preis)
        {
            // WriteLine("FilialSimulation_ConsoleApplication.Artikel wurde {0} angelegt: ", id);
            _artikel_id = id;
            _artikel_preis = preis;
            _artikel_volumen = volumen;
        }
    }
}