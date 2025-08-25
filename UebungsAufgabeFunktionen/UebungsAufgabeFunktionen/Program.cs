
using System;

namespace UebungsAufgabeFunktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;

            while (weiter)
            {
                int ersteZahl = 0;
                int zweiteZahl = 0;

                Console.WriteLine("Gib die erste Zahl ein mein Sohn");

                if (int.TryParse(Console.ReadLine(), out ersteZahl))
                {
                    Console.WriteLine("Gib die zweite Zahl ein mein Sohn");
                    if (int.TryParse(Console.ReadLine(), out zweiteZahl))
                    {
                        int ggT = MyMath.Calc_ggT(ersteZahl, zweiteZahl);
                        int kgV = MyMath.Calc_kgV(ersteZahl, zweiteZahl);

                        MyMath.ShowResult(ersteZahl, zweiteZahl, ggT, kgV);

                        
                    }
                }

               
                Console.WriteLine("Willst du noch eine Berechnung machen? (j/n)");
                string antwort = Console.ReadLine().ToLower();

                if (antwort != "j")
                {
                    weiter = false;
                }

                
            }

            Console.WriteLine("Programm beendet. Drücke eine Taste zum Schließen.");
            Console.ReadKey();
        }
    }
}
