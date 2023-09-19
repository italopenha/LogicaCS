namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                double perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1")}");
            } else
            {
                double areaTrapezio = (a + b) * c / 2;
                Console.WriteLine($"Area = {areaTrapezio.ToString("F1")}");
            }
        }
    }
}