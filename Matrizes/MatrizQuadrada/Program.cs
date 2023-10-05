﻿namespace MatrizQuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            int contNegativos = 0;
            foreach (int i in mat)
            {
                if (i < 0)
                    contNegativos++;
            }

            Console.WriteLine($"QUANTIDADE DE NEGATIVOS = {contNegativos}");
        }
    }
}