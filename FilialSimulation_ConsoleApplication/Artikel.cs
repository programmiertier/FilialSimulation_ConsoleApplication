using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    class Artikel
    {
        int id;
        double volumen;
        double preis;

        public Artikel(int meineid, Artikel[] warenkorb)
        {
            WriteLine("Artikel {0} angelegt: ", warenkorb[meineid].id);
            id = warenkorb[meineid].id;
            volumen = warenkorb[meineid].volumen;
            preis = warenkorb[meineid].preis;
            WriteLine("Mit einem Preis von {0:F2} und einem Volumen von {1:F2}", preis, volumen);
        }


        public Artikel(int meineid, double meinpreis, double meinvolumen)
        {
            // WriteLine("Artikel {0} angelegt: ", id);
            id = meineid;
            volumen = meinvolumen;
            preis = meinpreis;
        }


    }
}