namespace CrescimentoPopulacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int pa = int.Parse(valores[0]);
                int pb = int.Parse(valores[1]);
                decimal g1 = decimal.Parse(valores[2]);
                decimal g2 = decimal.Parse(valores[3]);

                int pTotalA = pa;
                int pTotalB = pb;
                int anos;

                for (anos = 0; pTotalA <= pTotalB; anos++)
                {
                    pTotalA += (int)(pTotalA * (g1 / 100));

                    pTotalB += (int)(pTotalB * (g2 / 100));
                }

                if (anos > 100)
                    Console.WriteLine("Mais de 1 seculo.");
                else
                    Console.WriteLine($"{anos} anos.");
            }
        }
    }
}