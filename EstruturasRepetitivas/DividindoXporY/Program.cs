namespace DividindoXporY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1"));
                }
            }
        }
    }
}