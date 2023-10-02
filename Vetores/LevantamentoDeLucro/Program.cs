namespace LevantamentoDeLucro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos:");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            Console.WriteLine($"Digite o nome, o preço de compra e o preço de venda separados por um espaço:");

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                precoCompra[i] = double.Parse(valores[1]);
                precoVenda[i] = double.Parse(valores[2]);
            }

            double lucro = 0.0;
            double lucroPorcentagem = 0.0;
            int abaixo10 = 0;
            int entre10e20 = 0;
            int acima20 = 0;
            double somaCompra = 0.0;
            double somaVenda = 0.0;
            double lucroTotal = 0.0;

            for (int i = 0; i < n; i++)
            {
                lucro = precoVenda[i] - precoCompra[i];
                lucroPorcentagem = lucro / precoCompra[i] * 100;

                if (lucroPorcentagem < 10.0)
                    abaixo10++;
                else if (lucroPorcentagem >= 10.0 && lucroPorcentagem <= 20.0)
                    entre10e20++;
                else
                    acima20++;

                somaCompra += precoCompra[i];
                somaVenda += precoVenda[i];
                lucroTotal += lucro;
            }

            Console.WriteLine($"Lucro abaixo de 10%: {abaixo10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {entre10e20}");
            Console.WriteLine($"Lucro acima de 20%: {acima20}");
            Console.WriteLine($"Valor total de compra: {somaCompra.ToString("F2")}");
            Console.WriteLine($"Valor total de venda: {somaVenda.ToString("F2")}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2")}");
        }
    }
}