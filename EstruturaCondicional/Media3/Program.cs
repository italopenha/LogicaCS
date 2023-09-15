namespace Media3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');
            float n1 = float.Parse(notas[0]);
            float n2 = float.Parse(notas[1]);
            float n3 = float.Parse(notas[2]);
            float n4 = float.Parse(notas[3]);

            float media = ((n1 * 2.0f) + (n2 * 3.0f) + (n3 * 4.0f) + (n4 * 1.0f)) / 10.0f;

            Console.WriteLine($"Media: {media.ToString("F1")}");

            if (media >= 7.0f)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0f)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0f && media < 7.0f)
            {
                Console.WriteLine("Aluno em exame.");
                float nExame = float.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {nExame.ToString("F1")}");
                float novaMedia = (media + nExame) / 2.0f;
                if (novaMedia >= 5.0f)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {novaMedia.ToString("F1")}");
                }
                else if (novaMedia < 5.0f)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {novaMedia.ToString("F1")}");
                }
            }
        }
    }
}