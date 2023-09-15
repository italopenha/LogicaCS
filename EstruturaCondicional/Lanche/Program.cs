namespace Lanche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double precoTotal = 0.0;

            switch (codigo)
            {
                case 1:
                    precoTotal = quantidade * 4.00;
                    break;
                case 2:
                    precoTotal = quantidade * 4.50;
                    break;
                case 3:
                    precoTotal = quantidade * 5.00;
                    break;
                case 4:
                    precoTotal = quantidade * 2.00;
                    break;
                case 5:
                    precoTotal = quantidade * 1.50;
                    break;
            }

            Console.WriteLine($"Total: R$ {precoTotal.ToString("F2")}");
        }
    }
}