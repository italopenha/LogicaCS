namespace NumerosPositivos
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
            float n6 = float.Parse(Console.ReadLine());

            float positivos = 0;

            if (n1 > 0)
            {
                positivos++;
            }

            if (n2 > 0)
            {
                positivos++;
            }

            if (n3 > 0)
            {
                positivos++;
            }

            if (n4 > 0)
            {
                positivos++;
            }

            if (n5 > 0)
            {
                positivos++;
            }

            if (n6 > 0)
            {
                positivos++;
            }

            Console.WriteLine($"{positivos} valores positivos");
        }
    }
}