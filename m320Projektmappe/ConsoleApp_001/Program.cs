namespace ConsoleApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wello, Horld!");

            int a = 2000;
            int b = 3000;
            int summe = MyMath.Add(a, b);
            Console.WriteLine($"Die Summe von {a} und {b} = {summe}");

        }
    }
}
