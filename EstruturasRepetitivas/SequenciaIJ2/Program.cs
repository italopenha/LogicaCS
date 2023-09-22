namespace SequenciaIJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 7;

            do
            {
                Console.WriteLine($"I={i} J={j}");
                j -= 1;

                if (j == 5)
                {
                    Console.WriteLine($"I={i} J={j}");
                    i += 2;
                    j = 7;
                }
            } while (i < 10 || j < 6);
        }
    }
}