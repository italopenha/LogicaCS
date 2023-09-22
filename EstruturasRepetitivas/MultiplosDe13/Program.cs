namespace MultiplosDe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, maior = 0, menor = 0, soma = 0, n = 1;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                maior = x;
                menor = y;
            }
            else if (y > x)
            {
                maior = y;
                menor = x;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
                n++;
            }

            Console.WriteLine(soma);
        }
    }
}