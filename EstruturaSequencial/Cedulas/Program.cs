namespace Cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para decompor:");
            int valor = int.Parse(Console.ReadLine());

            int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };

            int cedula100 = valor / cedulas[0];
            int resto100 = valor % cedulas[0];
            int cedula50 = resto100 / cedulas[1];
            int resto50 = resto100 % cedulas[1];
            int cedula20 = resto50 / cedulas[2];
            int resto20 = resto50 % cedulas[2];
            int cedula10 = resto20 / cedulas[3];
            int resto10 = resto20 % cedulas[3];
            int cedula5 = resto10 / cedulas[4];
            int resto5 = resto10 % cedulas[4];
            int cedula2 = resto5 / cedulas[5];
            int resto2 = resto5 % cedulas[5];
            int cedula1 = resto2 / cedulas[6];
            int resto1 = resto2 % cedulas[6];

            Console.WriteLine($"{cedula100} nota(s) de R$ 100,00");
            Console.WriteLine($"{cedula50} nota(s) de R$ 50,00");
            Console.WriteLine($"{cedula20} nota(s) de R$ 20,00");
            Console.WriteLine($"{cedula10} nota(s) de R$ 10,00");
            Console.WriteLine($"{cedula5} nota(s) de R$ 5,00");
            Console.WriteLine($"{cedula2} nota(s) de R$ 2,00");
            Console.WriteLine($"{cedula1} nota(s) de R$ 1,00");
        }
    }
}