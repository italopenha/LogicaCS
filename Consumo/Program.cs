namespace Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância percorrida em KM:");
            double distanciaPercorrida = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de combustível utilizado em litros:");
            double combustivelGasto = double.Parse(Console.ReadLine());

            double consumoMedio = distanciaPercorrida / combustivelGasto;

            Console.WriteLine($"{consumoMedio.ToString("F3")} km/l");
        }
    }
}