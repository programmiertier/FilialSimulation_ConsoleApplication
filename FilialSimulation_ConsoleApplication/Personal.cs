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
            this.bezahlen();
        }
        ~Personal()
        {
            
        }

        public override void bezahlen()
        {
            WriteLine("Das Personal zahlt mit Rabatt");
            ReadLine();
            // this.listeAnzeigen();
        }
    }
}
