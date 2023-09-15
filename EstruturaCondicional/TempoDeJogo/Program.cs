namespace TempoDeJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);
            int horasTotais = 0;

            if (horaInicial > horaFinal)
            {
                horasTotais = 24 - (horaInicial - horaFinal);
            }
            else if (horaFinal > horaInicial)
            {
                horasTotais = horaFinal - horaInicial;
            }
            else
            {
                horasTotais = 24;
            }

            Console.WriteLine($"O JOGO DUROU {horasTotais} HORA(S)");
        }
    }
}