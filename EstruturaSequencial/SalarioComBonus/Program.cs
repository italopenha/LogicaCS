namespace SalarioComBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalVendas, comissao = 0.15, salarioTotal;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu salário fixo:");
            salarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor total das suas vendas:");
            totalVendas = double.Parse(Console.ReadLine());

            salarioTotal = salarioFixo + (totalVendas * comissao);

            Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("F2")}");
        }
    }
}