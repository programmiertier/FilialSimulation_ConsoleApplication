using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Lagerist : Personal
    {
        public Lagerist()
        {
            this.id = Actor.lfrNr;
            WriteLine("Ich bin Lagerist mit der Nummer {0}", id);
        }
        
        public override void bezahlen(ref Kasse ks)
        {
            base.bezahlen(ref ks);
        }

        ~Lagerist()
        {

        }
        // Attribute
        // Auftragsliste    Einkaufszettel  auftragsliste

        // Methoden
        // Auftragsliste abarbeiten
        // - aus dem Lager entnehmen    (daszu muss ein Lager da sein)
        // - in Verkauf einfüllen
    }
}