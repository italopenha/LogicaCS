namespace SequenciaSII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y = 2, s = 0;

            for (double i = 3; i <= 39; i += 2)
            {
                x = i / y;
                y *= 2;
                s += x;
            }

            s += 1;

            Console.WriteLine(s.ToString("F2"));
        }
    }
}