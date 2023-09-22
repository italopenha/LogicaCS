namespace QuadradoEaoCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 1, c = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{a} {b} {c}");
                a = a + 1;
                b = Math.Pow(a, 2);
                c = Math.Pow(a, 3);
            }
        }
    }
}