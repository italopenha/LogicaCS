namespace SomaSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}