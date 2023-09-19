namespace SortSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            int n1, n2, n3;

            if (a < b && a < c)
            {
                n1 = a;
                if (b < c)
                {
                    n2 = b;
                    n3 = c;
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else if (c < b)
                {
                    n2 = c;
                    n3 = b;
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
            }
            else if (b < c && b < a)
            {
                n1 = b;
                if (a < c)
                {
                    n2 = a;
                    n3 = c;
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else if (c < a)
                {
                    n2 = c;
                    n3 = a;
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
            }
            else if (c < a && c < b)
            {
                n1 = c;
                if (a < b)
                {
                    n2 = a;
                    n3 = b;
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else if (b < a)
                {
                    n2 = b;
                    n3 = a;
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
            }

            Console.WriteLine("");

            Console.WriteLine(valores[0]);
            Console.WriteLine(valores[1]);
            Console.WriteLine(valores[2]);
        }
    }
}