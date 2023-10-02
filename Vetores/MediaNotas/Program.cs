namespace MediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de alunos:");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] notas1 = new double[n];
            double[] notas2 = new double[n];

            Console.WriteLine($"Digite o nome e as duas notas de cada aluno separados por um espaço:");

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                notas1[i] = double.Parse(valores[1]);
                notas2[i] = double.Parse(valores[2]);
            }

            
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < n; i++)
            {
                double soma = 0.0;
                soma += notas1[i] + notas2[i];
                double media = soma / 2;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}