namespace GirarFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas da matriz:");
            int lin = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas da matriz:");
            int col = int.Parse(Console.ReadLine());

            int[,] mat = new int[lin, col];

            Console.WriteLine("Digite a matriz linha a linha, separando cada elemento por um espaço, pressione ENTER ao final de cada linha:");
            for (int i = 0; i < lin; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Digite o índice da linha que você deseja girar:");
            int indFila = int.Parse(Console.ReadLine());

            int[] girarFila = new int[col -1];

            for (int i = indFila - 1; i < indFila; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    girarFila[j] = mat[i, j];
                }

                mat[i, 0] = mat[i, col - 1];
                for (int k = 1; k < col; k++)
                {
                    mat[i, k] = girarFila[k - 1];
                }
            }

            for (int i = 0; i < lin; i++)
            {
                for (int j = 0;j < col; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}