namespace SomaAcimaDaDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas e colunas da matriz:");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine("Digite a matriz linha a linha, separando cada elemento por um espaço, pressione ENTER ao final de cada linha:");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    soma += mat[i, j];
                }
            }
            Console.WriteLine(soma);
        }
    }
}