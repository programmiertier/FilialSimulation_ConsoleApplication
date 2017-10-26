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
        public static void darstellen(Regal[] dasRegal, int von, int bis)
        {
            // Clear();
            BackgroundColor = Gray;
            ForegroundColor = Green;
            WriteLine("Hier kommt Regal {0} bis {1} auf den Schirm", von, bis);
            for (int zaehler = von; zaehler <= bis; zaehler++)
            {
                ForegroundColor = Black;
                if (zaehler % 40 == 0)
                {
                    BackgroundColor = Gray;
                    Write(" ");
                    WriteLine();
                    Write(" ");
                    if (zaehler % 80 == 0)
                    {
                        BackgroundColor = Gray;
                        WriteLine("{0,40}", " ");
                        Write(" ");
                    }
                }
                else
                {
                    BackgroundColor = Green;
                    if (dasRegal[zaehler].regal_nachfuellen)
                    {
                        BackgroundColor = Red;
                        Write("!");
                        BackgroundColor = Green;
                    }
                    else
                    { Write("#"); }
                }
            }
            BackgroundColor = Gray;
            WriteLine(" ");
            WriteLine("{0,41}", " ");
        }
    }
}
