namespace SomaDeImparesConsecutivos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int soma = 0;
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (x % 2 == 0)
                {
                    for (int j = 0; j < y; j++)
                    {
                        x++;
                        soma += x;
                        x++;
                    }
                }
                else
                {
                    for (int j = 0; j < y; j++)
                    {
                        soma += x;
                        x += 2;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
