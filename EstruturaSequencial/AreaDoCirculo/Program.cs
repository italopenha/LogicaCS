using System.Globalization;

namespace AreaDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;

            Console.WriteLine("--- ÁREA DO CÍRCULO ---");
            Console.WriteLine("Digite o raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = n * Math.Pow(raio, 2);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}