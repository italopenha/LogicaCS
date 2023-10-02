namespace MediaDosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de elementos que terá o vetor:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite os {n} elementos separados por um espaço:");
            string[] valores = Console.ReadLine().Split(' ');

            int[] vet = new int[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            int soma = 0;
            int contPares = 0;

            foreach (int v in vet)
            {
                if (v % 2 == 0)
                {
                    soma += v;
                    contPares++;
                }  
            }

            double media = soma / contPares;

            Console.WriteLine(media.ToString("F1"));
        }
    }
}