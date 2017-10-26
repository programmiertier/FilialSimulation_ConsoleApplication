using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Einkaufszettel
    {
        public struct zeile
        {
            public int artikel;
            public int anzahl;
            private int eins;
            private int aktuellerInhalt;

            public zeile(int eins, int aktuellerInhalt) : this()
            {
                this.eins = eins;
                this.aktuellerInhalt = aktuellerInhalt;
            }
        }

        public List<zeile> liste = new List<zeile>();

        public Einkaufszettel()
        {
            Random zufall = new Random(Actor.lfrNr);     //(Actor.lfrNr);        // wenn Klasse Actor noch nicht ins Projekt übernommen wurde
            int bis = zufall.Next(1, 11);
            for (int von = 1; von <= bis; von++)
            { liste.Add(new zeile() { artikel = zufall.Next(1, 800), anzahl = zufall.Next(1, 100) }); }
        }

        public Einkaufszettel(string irgendwas)
        {

        }

        public void zeigen()
        {
            foreach (zeile platzhalter in liste)
            {
                WriteLine("Artikel {0} ist {1}mal auf der Liste", platzhalter.artikel, platzhalter.anzahl);
            }
        }
    }
}
