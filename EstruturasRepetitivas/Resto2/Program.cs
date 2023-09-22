namespace Resto2
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int n = int.Parse(Console.ReadLine());

            if (n < 10000)
            {
                for (int i = 1; i <= 10000; i++)
                {
                    if (i % n == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}