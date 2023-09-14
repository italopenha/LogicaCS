namespace FormulaBhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0.0 || delta < 0)
                Console.WriteLine("Impossivel calcular");
            else
            {
                double r1 = (- b + Math.Sqrt(delta)) / (2.0 * a);
                double r2 = (- b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine($"R1 = {r1.ToString("F5")}");
                Console.WriteLine($"R2 = {r2.ToString("F5")}");
            }
        }
    }
}