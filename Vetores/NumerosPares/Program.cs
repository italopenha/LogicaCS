namespace NumerosPares
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

            int par;
            int contPares = 0;

            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    par = vet[i];
                    Console.Write($"{par} ");
                    contPares++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(contPares);
        }
    }
}