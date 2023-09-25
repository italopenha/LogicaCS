namespace FatorialSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                fatorial = n * i;
                n = fatorial;
            }

            Console.WriteLine(fatorial);
        }
    }
}