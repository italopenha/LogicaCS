namespace Grenais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vInter = 0, vGremio = 0, empates = 0, grenais = 0, gInter, gGremio, codigo = 1;
            
            do
            {
                string[] gols = Console.ReadLine().Split(' ');
                gInter = int.Parse(gols[0]);
                gGremio = int.Parse(gols[1]);

                if (gInter > gGremio)
                {
                    vInter++;
                    grenais++;
                }
                else if (gGremio > gInter)
                {
                    vGremio++;
                    grenais++;
                }
                else
                {
                    empates++;
                    grenais++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                codigo = int.Parse(Console.ReadLine());
            } while (codigo == 1);

            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{vInter}");
            Console.WriteLine($"Gremio:{vGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vInter > vGremio)
                Console.WriteLine("Inter venceu mais");
            else if (vGremio > vInter)
                Console.WriteLine("Gremio venceu mais");
            else
                Console.WriteLine("Nao houve vencedor");
        }
    }
}