namespace PositivosMedia
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

            int positivos = 0;
            float somaPositivos = 0.0f;

            if (n1 > 0)
            {
                positivos++;
                somaPositivos += n1;
            }

            if (n2 > 0)
            {
                positivos++;
                somaPositivos += n2;
            }

            if (n3 > 0)
            {
                positivos++;
                somaPositivos += n3;
            }

            if (n4 > 0)
            {
                positivos++;
                somaPositivos += n4;
            }

            if (n5 > 0)
            {
                positivos++;
                somaPositivos += n5;
            }

            if (n6 > 0)
            {
                positivos++;
                somaPositivos += n6;
            }

            Console.WriteLine($"{positivos} valores positivos");

            float media = somaPositivos / positivos;

            Console.WriteLine($"{media.ToString("F1")}");
        }
    }
}