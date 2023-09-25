namespace SequenciaS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, s = 0;

            for (double i = 2; i <= 100;  i++)
            {
                x = 1 / i;
                s += x;
            }

            s += 1;

            Console.WriteLine(s.ToString("F2"));
        }
    }
}