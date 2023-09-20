namespace Idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade = double.Parse(Console.ReadLine());
            double somaIdades = 0.0, media;
            int cont = 0;

            if (idade < 0)
                Console.WriteLine("impossivel calcular");
            else
            {
                while (idade > 0)
                {
                    somaIdades += idade;
                    cont++;
                    idade = int.Parse(Console.ReadLine());
                }

                media = somaIdades / cont;

                Console.WriteLine(media.ToString("F2"));
            }
        }
    }
}