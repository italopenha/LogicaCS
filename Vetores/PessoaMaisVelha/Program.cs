namespace PessoaMaisVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pessoas para colocar no vetor:");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            string[] pessoas = new string[n];

            Console.WriteLine($"Digite o nome e a idade de cada pessoa separados por um espaço:");

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);
            }

            int maiorIdade = 0;
            string maiorNome = "";

            for (int i = 0; i < n; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    maiorNome = nomes[i];
                }
            }

            Console.WriteLine($"Pessoa mais velha: {maiorNome}");
        }
    }
}