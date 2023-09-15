namespace DiaDaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string diaDaSemana;

            switch (x)
            {
                case 1:
                    diaDaSemana = "domingo";
                    break;
                case 2:
                    diaDaSemana = "segunda";
                    break;
                case 3:
                    diaDaSemana = "terça";
                    break;
                case 4:
                    diaDaSemana = "quarta";
                    break;
                case 5:
                    diaDaSemana = "quinta";
                    break;
                case 6:
                    diaDaSemana = "sexta";
                    break;
                case 7:
                    diaDaSemana = "sábado";
                    break;
                default:
                    diaDaSemana = "Valor inválido";
                    break;
            }

            Console.WriteLine($"Dia da semana: {diaDaSemana}");
        }
    }
}