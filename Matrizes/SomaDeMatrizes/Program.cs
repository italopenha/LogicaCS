namespace SomaDeMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas das matrizes:");
            int lin = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas das matrizes:");
            int col = int.Parse(Console.ReadLine());

            int[,] mat1 = new int[lin, col];
            int[,] mat2 = new int[lin, col];

            Console.WriteLine("Digite a matriz 1 linha a linha, separando cada elemento por um espaço, pressione ENTER ao final de cada linha:");
            for (int i = 0; i < lin; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    mat1[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Digite a matriz 2 linha a linha, separando cada elemento por um espaço, pressione ENTER ao final de cada linha:");
            for (int i = 0; i < lin; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    mat2[i, j] = int.Parse(s[j]);
                }
            }

            int[,] mat3 = new int[lin, col];

            Console.WriteLine("");

            Console.WriteLine("A soma de cada elemento das matrizes 1 e 2, geram a matriz:");
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}