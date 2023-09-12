namespace Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota:");
            double notaA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            double notaB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            double notaC = double.Parse(Console.ReadLine());

            double mediaPonderada = ((notaA * 2) + (notaB * 3) + (notaC * 5)) / 10;

            Console.WriteLine($"MEDIA = {mediaPonderada.ToString("F1")}");
        }
    }
}