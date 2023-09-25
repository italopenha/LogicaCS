namespace SequenciaDeNumerosESoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, maior, menor, soma;

            string[] valores = Console.ReadLine().Split(' ');
            m = int.Parse(valores[0]);
            n = int.Parse(valores[1]);

            while (m > 0 && n > 0)
            {
                maior = m;
                menor = n;

                if (n > m)
                {
                    maior = n;
                    menor = m;
                }

                soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    soma += i;
                    Console.Write($"{i} ");
                }

                Console.WriteLine($"Sum={soma}");

                valores = Console.ReadLine().Split(' ');
                m = int.Parse(valores[0]);
                n = int.Parse(valores[1]);
            }
        }
    }
}