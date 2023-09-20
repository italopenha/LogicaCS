namespace ValidacaoDeNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double nota = 0.0, somaNotas = 0.0, media;

            nota = double.Parse(Console.ReadLine());

            while (cont < 2)
            {
                if (nota < 0.0 || nota > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine());
                }                    
                else
                {
                    somaNotas += nota;
                    cont++;
                    nota = double.Parse(Console.ReadLine());
                }
            }

            media = somaNotas / cont;
            Console.WriteLine($"media = {media.ToString("F2")}");
        }
    }
}