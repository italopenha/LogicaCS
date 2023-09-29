namespace MaiorElemento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(valores[i]);
            }

            double maior = 0;
            int posicaoMaior = 0;
            for (int i = 0; i < n; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine(maior.ToString("F2"));
            Console.WriteLine(posicaoMaior);
        }
    }
}