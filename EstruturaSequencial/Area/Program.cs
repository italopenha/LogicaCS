namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double areaTriangulo = a * c / 2;
            double areaCirculo = pi * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");
        }
    }
}