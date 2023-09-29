namespace SomaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de elementos que terão os vetores:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite os {n} elementos do vetor A separados por um espaço:");
            string[] valoresA = Console.ReadLine().Split(' ');

            Console.WriteLine($"Digite os {n} elementos do vetor B separados por um espaço:");
            string[] valoresB = Console.ReadLine().Split(' ');

            int[] vetA = new int[n];
            int[] vetB = new int[n];

            for (int i = 0; i < n; i++)
            {
                vetA[i] = int.Parse(valoresA[i]);
                vetB[i] = int.Parse(valoresB[i]);
            }

            int[] vetC = new int[n];

            for (int i = 0; i < n; i++)
            {
                vetC[i] = vetA[i] += vetB[i];
            }

            foreach (int i in vetC)
            {
                Console.Write($"{i} ");
            }
        }
    }
}