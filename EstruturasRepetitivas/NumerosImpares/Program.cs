namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, impar = 0, impares = 0;

            x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000)
            {
                while (impar <= x)
                {
                    if (impar % 2 != 0)
                    {
                        Console.WriteLine(impar);
                    }
                    impar++;
                }
            }
        }
    }
}