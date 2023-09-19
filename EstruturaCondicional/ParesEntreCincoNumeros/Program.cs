namespace ParesEntreCincoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            float n4 = float.Parse(Console.ReadLine());
            float n5 = float.Parse(Console.ReadLine());

            int pares = 0;

            if (n1 % 2 == 0)
            {
                pares++;
            }

            if (n2 % 2 == 0)
            {
                pares++;
            }

            if (n3 % 2 == 0)
            {
                pares++;
            }

            if (n4 % 2 == 0)
            {
                pares++;
            }

            if (n5 % 2 == 0)
            {
                pares++;
            }

            Console.WriteLine($"{pares} valores pares");
        }
    }
}