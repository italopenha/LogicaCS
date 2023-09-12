namespace GastoDeCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tempo gasto:");
            int tempoGasto = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média:");
            int velocidadeMedia = int.Parse(Console.ReadLine());

            double distanciaPercorrida = tempoGasto * velocidadeMedia;
            double litros = distanciaPercorrida / 12;

            Console.WriteLine($"{litros.ToString("F3")}");
        }
    }
}