namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorPorHora, salario;

            Console.WriteLine("Digite o número do funcionário:");
            numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a raceber por hora:");
            valorPorHora = double.Parse(Console.ReadLine());
            
            salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
        }
    }
}