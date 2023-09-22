namespace PUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{a} {b} {c} PUM");
                a = c + 2;
                b = a + 1;
                c = b + 1;
            }
        }
    }
}