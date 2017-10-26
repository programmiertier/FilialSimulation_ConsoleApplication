using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Personal : Actor
    {
        public Personal()
        {
            this.id = Actor.lfrNr;
            WriteLine("Ich bin Personal und werde als {0}. aufgerufen", id);
        }
        ~Personal()
        {
            
        }

        public override void bezahlen(ref Kasse ks)
        {
            WriteLine("Das Personal zahlt mit Rabatt");
            Console.WriteLine("statt {0,6:F2} nur {1,6:F2} Euro", ks.kunde_abrechnen(einkaufswagen), ks.kunde_abrechnen(einkaufswagen) * .7);
            ReadLine();
            // this.listeAnzeigen();
        }
    }
}
