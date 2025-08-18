namespace ConsoleApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wello, Horld!");

            int a = 200;
            int b = 300;
            int summe = MyMath.Add(a, b);
            Console.WriteLine($"Die Summe von {a} und {b} = {summe}");

        }
    }
}
