namespace Media1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota:");
            double notaA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            double notaB = double.Parse(Console.ReadLine());

            double mediaPonderada = ((notaA * 3.5) + (notaB * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {mediaPonderada.ToString("F5")}");
        }
    }
}