namespace UltrapassandoZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, i;
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            for (i = 0; soma < z; i++)
            {
                soma += x + 1;
            }

            Console.WriteLine(i);
        }
    }
}