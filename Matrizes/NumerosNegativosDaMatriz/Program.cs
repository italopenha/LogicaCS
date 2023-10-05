namespace NumerosNegativosDaMatriz
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

            Console.WriteLine("Valores negativos:");
            foreach (int i in mat)
            {
                if (i < 0)
                    Console.WriteLine(i);
            }
        }
    }
}