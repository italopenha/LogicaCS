namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            int maiorAB = ((a + b) + Math.Abs(a - b)) / 2;
            int maiorABC = ((maiorAB + c) + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine($"{maiorABC} eh o maior");
        }
    }
}