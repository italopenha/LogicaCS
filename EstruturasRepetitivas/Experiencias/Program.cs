namespace Experiencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, quantidade, coelhos = 0, ratos = 0, sapos = 0;
            double percentualC, percentualR, percentualS, total;
            char especieAnimal;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] animal = Console.ReadLine().Split(' ');
                quantidade = int.Parse(animal[0]);
                especieAnimal = char.Parse(animal[1]);

                if (especieAnimal == 'C')
                {
                    coelhos += quantidade;
                }
                else if (especieAnimal == 'R')
                {
                    ratos += quantidade;
                }
                else if (especieAnimal == 'S')
                {
                    sapos += quantidade;
                }
            }

            total = coelhos + ratos + sapos;
            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            percentualC = coelhos * 100 / total;
            percentualR = ratos * 100 / total;
            percentualS = sapos * 100 / total;
            Console.WriteLine($"Percentual de coelhos: {percentualC.ToString("F2")} %");
            Console.WriteLine($"Percentual de ratos: {percentualR.ToString("F2")} %");
            Console.WriteLine($"Percentual de sapos: {percentualS.ToString("F2")} %");
        }
    }
}