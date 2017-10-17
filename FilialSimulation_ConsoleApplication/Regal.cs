using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    public class Regal
    {
        int id;
        double volumenRegal = 1.0;
        int aktuellerInhalt;
        double aktuellerWert;       // wie viel die aktuellen Waren, im Regal (natürlich... Peperoni) wert sind
        double kapazitaet;
        bool nachfuellen;
        double mindestBestand;
        

        public void mindest(double mindestBestand, double kapazitaet)
        {
            mindestBestand = kapazitaet * 0.3;
        }
    }
}