namespace MediaAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pessoas:");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];

            Console.WriteLine($"Digite o nome, idade e altura de cada pessoa separados por um espaço:");

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);
                alturas[i] = double.Parse(valores[2]);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += alturas[i];
            }

            double media = soma / n;

            int contIdades = 0;
            for (int i = 0; i < n; i++)
            {
                if (idades[i] < 16)
                {
                    contIdades++;
                }
            }

            double menos16 = (double)contIdades / n * 100.0;

            Console.WriteLine($"Altura média: {media.ToString("F2")}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {menos16.ToString("F1")}%");
        }
    }
}