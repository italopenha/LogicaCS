namespace MaiorPosicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, maior = 0, posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                n = int.Parse(Console.ReadLine());

                if (maior < n)
                {
                    maior = n;
                    posicao = i;
                }
            }

            Console.WriteLine($"{maior}");
            Console.WriteLine($"{posicao}");
        }
    }
}