namespace SomaLinhasDaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int n = int.Parse(valores[0]);
            int m = int.Parse(valores[1]);

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] soma = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    soma[i] += mat[i, j];
                }
                Console.WriteLine(soma[i]);
            }
        }
    }
}