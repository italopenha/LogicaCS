namespace VariasNotasComValidacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo = 1;

            do
            {
                int cont = 0;
                double nota = 0.0, somaNotas = 0.0, media;
                while (cont < 2)
                {
                    nota = double.Parse(Console.ReadLine());
                    if (nota < 0.0 || nota > 10.0)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        somaNotas += nota;
                        cont++;
                    }
                }
                media = somaNotas / cont;
                Console.WriteLine($"media = {media.ToString("F2")}");

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    codigo = int.Parse(Console.ReadLine());
                } while (codigo < 1 || codigo > 2);

            } while (codigo == 1);
        }
    }
}