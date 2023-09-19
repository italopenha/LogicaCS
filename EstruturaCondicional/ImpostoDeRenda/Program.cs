namespace ImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double impostoFinal, valorBase, faixa008, faixa018, faixa028;

            double salario = float.Parse(Console.ReadLine());

            switch (salario)
            {
                case < 2000.00:
                    Console.WriteLine("Isento");
                    break;
                case < 3000.00:
                    impostoFinal = (salario - 2000.00) * 0.08;
                    Console.WriteLine($"R$ {impostoFinal.ToString("F2")}");
                    break;
                case < 4500.00:
                    valorBase = (salario - 2000.00);
                    faixa008 = 1000 * 0.08;
                    faixa018 = (valorBase - 1000) * 0.18;
                    impostoFinal = faixa008 + faixa018;
                    Console.WriteLine($"R$ {impostoFinal.ToString("F2")}");
                    break;
                case > 4500.00:
                    valorBase = (salario - 2000.00);
                    faixa008 = 1000 * 0.08;
                    faixa018 = 1500 * 0.18;
                    faixa028 = (valorBase - 2500) * 0.28;
                    impostoFinal = faixa008 + faixa018 + faixa028;
                    Console.WriteLine($"R$ {impostoFinal.ToString("F2")}");
                    break;
            }
        }
    }
}