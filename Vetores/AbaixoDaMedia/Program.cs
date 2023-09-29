namespace AbaixoDaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de elementos que terá o vetor:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite os {n} elementos separados por um espaço:");
            string[] valores = Console.ReadLine().Split(' ');

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(valores[i]);
            }

            double soma = 0.0;

            foreach (double v in vet)
            {
                soma += v;
            }

            double media = soma / n;
            Console.WriteLine(media.ToString("F3"));

            foreach (double v in vet)
            {
                if (v < media)
                {
                    Console.WriteLine(v.ToString("F1"));
                }
            }
        }
    }
}