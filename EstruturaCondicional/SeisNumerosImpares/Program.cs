namespace SeisNumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 != 0)
            {
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
            }
            
            if (x % 2 == 0)
            {
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
                x++;
                x++;
                Console.WriteLine(x);
            }
        }
    }
}