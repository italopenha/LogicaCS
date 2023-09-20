namespace SomaDeParesConsecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma1, soma2;
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma1 = 0;
                soma2 = 0;
                if (x % 2 == 0)
                {
                    soma1 += x;
                    x += 2;
                    soma1 += x;
                    x += 2;
                    soma1 += x;
                    x += 2;
                    soma1 += x;
                    x += 2;
                    soma1 += x;
                    Console.WriteLine(soma1);
                }
                else if (x % 2 != 0)
                {
                    x++;
                    soma2 += x;
                    x += 2;
                    soma2 += x;
                    x += 2;
                    soma2 += x;
                    x += 2;
                    soma2 += x;
                    x += 2;
                    soma2 += x;
                    Console.WriteLine(soma2);
                }
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}