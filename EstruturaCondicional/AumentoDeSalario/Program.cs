namespace AumentoDeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double reajuste, percentual, novoSalario;

            double salarioAntigo = double.Parse(Console.ReadLine());

            switch (salarioAntigo)
            {
                case <= 400.00:
                    reajuste = salarioAntigo * 0.15;
                    novoSalario = salarioAntigo + reajuste;
                    percentual = 0.15 * 100;
                    Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
                    Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
                    Console.WriteLine($"Em percentual: {percentual} %");
                    break;
                case <= 800.00:
                    reajuste = salarioAntigo * 0.12;
                    novoSalario = salarioAntigo + reajuste;
                    percentual = 0.12 * 100;
                    Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
                    Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
                    Console.WriteLine($"Em percentual: {percentual} %");
                    break;
                case <= 1200.00:
                    reajuste = salarioAntigo * 0.10;
                    novoSalario = salarioAntigo + reajuste;
                    percentual = 0.10 * 100;
                    Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
                    Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
                    Console.WriteLine($"Em percentual: {percentual} %");
                    break;
                case <= 2000.00:
                    reajuste = salarioAntigo * 0.07;
                    novoSalario = salarioAntigo + reajuste;
                    percentual = 0.07 * 100;
                    Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
                    Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
                    Console.WriteLine($"Em percentual: {percentual} %");
                    break;
                case > 2000.00:
                    reajuste = salarioAntigo * 0.04;
                    novoSalario = salarioAntigo + reajuste;
                    percentual = 0.04 * 100;
                    Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
                    Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
                    Console.WriteLine($"Em percentual: {percentual} %");
                    break;
            }
        }
    }
}