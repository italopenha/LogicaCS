namespace QuadradoDePares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, pares = 2;
            double resultado;

            n = int.Parse(Console.ReadLine());

            if (n > 5 && n < 2000)
            {
                while (pares <= n)
                {
                    if (pares % 2 == 0)
                    {
                        resultado = Math.Pow(pares, 2);
                        Console.WriteLine($"{pares}^2 = {resultado}");
                    } 
                    pares++;
                }
            }
        }
    }
}