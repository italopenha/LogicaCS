namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado, n;

            n = int.Parse(Console.ReadLine());

            if (n >= 2 && n <= 1000)
            {
                for (int i = 1; i <= 10; i++)
                {
                    resultado = i * n;
                    Console.WriteLine($"{i} x {n} = {resultado}");
                }
            }
        }
    }
}