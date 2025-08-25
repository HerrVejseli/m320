namespace UebungsAufgabeFunktionen
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z ;
            while (b != 0)
            {
                z = a % b; 
                a = b;        
                b = z;     
            }
            return a; 
        }
        public static void ShowResult(int ersteZahl, int zweiteZahl, int ggT, int kgV)
        {
            Console.WriteLine($"ggT von {ersteZahl} und {zweiteZahl} ist {ggT}");
            Console.WriteLine($"kgV von {ersteZahl} und {zweiteZahl} ist {kgV}");
        }



        public static int Calc_kgV(int a, int b)
        {
            int ggT = Calc_ggT(a, b);

            int x = a * b;

            int kgV = x / ggT;

            return kgV;
        }
    }
}
