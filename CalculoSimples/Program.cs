namespace CalculoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] camisetas = Console.ReadLine().Split(' ');
            int codigoCamiseta = int.Parse(camisetas[0]);
            int quantidadeCamisetas = int.Parse(camisetas[1]);
            double valorCamiseta = double.Parse(camisetas[2]);

            string[] bermudas = Console.ReadLine().Split(' ');
            int codigoBermuda = int.Parse(bermudas[0]);
            int quantidadeBermudas = int.Parse(bermudas[1]);
            double valorBermuda = double.Parse(bermudas[2]);

            double valorTotal = (quantidadeCamisetas * valorCamiseta) + (quantidadeBermudas * valorBermuda);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2")}");
        }
    }
}