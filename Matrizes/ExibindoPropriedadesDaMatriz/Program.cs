namespace ExibindoPropriedadesDaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas e colunas da matriz:");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            Console.WriteLine("Digite a matriz linha a linha, separando cada elemento por um espaço, pressione ENTER ao final de cada linha:");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = double.Parse(s[j]);
                }
            }

            Console.WriteLine();

            double somaPositivos = 0.0;

            foreach (double i in mat)
            {
                if (i > 0)
                    somaPositivos += i;
            }

            Console.WriteLine($"Soma dos positivos: {somaPositivos}");

            Console.WriteLine($"Digite o índice de uma linha de 0 a {n}, para exibir os elementos:");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Linha escolhida: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == l)
                        Console.Write(mat[i, j].ToString("F1") + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Digite o índice de uma coluna de 0 a {n}, para exibir os elementos:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Coluna escolhida: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == c)
                        Console.Write(mat[i, j].ToString("F1") + " ");
                }
            }

            Console.WriteLine();

            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write(mat[i, j].ToString("F1") + " ");
                }
            }

            double[,] mat2 = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        mat2[i, j] = Math.Pow(mat[i, j], 2);
                    else
                        mat2[i, j] = mat[i, j];
                }
            }

            Console.WriteLine(); 

            Console.WriteLine("Matriz alterada(N°s negativos elevados ao quadrado):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat2[i, j].ToString("F1") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}