using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace FilialSimulation_ConsoleApplication
{
    internal static class Display
    {
        public static void darstellen(Regal[] schnurzipupsregal)
        {
            darstellen(schnurzipupsregal, 0, schnurzipupsregal.Length - 1);
        }

        public static void darstellen(Regal[] schnurzipupsregal, int einzelnesRegal)
        {
            darstellen(schnurzipupsregal, einzelnesRegal, einzelnesRegal);
        }

        public static void darstellen(Regal[] schnurzipupsregal, int von, int bis)
        {
            ForegroundColor = Black;
            for (int zaehler = von; zaehler <= bis; zaehler++)
            {
                Regal platzhalter = schnurzipupsregal[zaehler];
                if (platzhalter.regal_aktuellerInhalt < 30)
                {
                    BackgroundColor = Red;
                }
                else
                {
                    BackgroundColor = Green;
                }
                Write("{0,4:D}", schnurzipupsregal[zaehler].regal_id);
                if (zaehler % 40 == 0)
                {
                    WriteLine();
                    BackgroundColor = Black;
                }
                if (zaehler % 80 == 0)
                {
                    BackgroundColor = Black;
                    WriteLine();
                    WriteLine();
                }
            }
        }
    }
}
