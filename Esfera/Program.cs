namespace Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, raio, volume;

            Console.WriteLine("Digite o valor do raio da esfera:");
            raio = double.Parse(Console.ReadLine());

            volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
        }
    }
}