using System.Globalization;

namespace NotasMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para converter em notas e moedas:");
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int[] notas = { 100, 50, 20, 10, 5, 2 };
            decimal[] moedas = { 1.0m, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };

            int nota100 = (int)valor / notas[0];
            decimal resto100 = valor % notas[0];
            int nota50 = (int)resto100 / notas[1];
            decimal resto50 = resto100 % notas[1];
            int nota20 = (int)resto50 / notas[2];
            decimal resto20 = resto50 % notas[2];
            int nota10 = (int)resto20 / notas[3];
            decimal resto10 = resto20 % notas[3];
            int nota5 = (int)resto10 / notas[4];
            decimal resto5 = resto10 % notas[4];
            int nota2 = (int)resto5 / notas[5];
            decimal resto2 = resto5 % notas[5];

            decimal moeda1 = resto2 / moedas[0];
            decimal restoMoeda1 = resto2 % moedas[0];
            decimal moeda050 = restoMoeda1 / moedas[1];
            decimal restoMoedas050 = restoMoeda1 % moedas[1];
            decimal moeda025 =  restoMoedas050 / moedas[2];
            decimal restoMoedas025 = restoMoedas050 % moedas[2];
            decimal moeda010 = restoMoedas025 / moedas[3];
            decimal restoMoedas010 = restoMoedas025 % moedas[3];
            decimal moeda005 = restoMoedas010 / moedas[4];
            decimal restoMoedas005 = restoMoedas010 % moedas[4];
            decimal moeda001 = restoMoedas005 / moedas[5];
            decimal restoMoedas001 = restoMoedas005 % moedas[5];

            int moeda1int = (int)moeda1;
            int moeda050int = (int)moeda050;
            int moeda025int = (int)moeda025;
            int moeda010int = (int)moeda010;
            int moeda005int = (int)moeda005;
            int moeda001int = (int)moeda001;

            Console.WriteLine($"NOTAS:");
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
            Console.WriteLine($"MOEDAS:");
            Console.WriteLine($"{moeda1int} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda050int} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda025int} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda010int} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda005int} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda001int} moeda(s) de R$ 0.01");
        }
    }
}