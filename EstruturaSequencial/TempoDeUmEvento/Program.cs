namespace TempoDeUmEvento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dia ");
            int diaInicial = int.Parse(Console.ReadLine());
            string[] horarioInicial = Console.ReadLine().Split(" : ");
            int horaInicial = int.Parse(horarioInicial[0]);
            int minutoInicial = int.Parse(horarioInicial[1]);
            int segundoInicial = int.Parse(horarioInicial[2]);

            Console.Write("Dia ");
            int diaFinal = int.Parse(Console.ReadLine());
            string[] horarioFinal = Console.ReadLine().Split(" : ");
            int horaFinal = int.Parse(horarioFinal[0]);
            int minutoFinal = int.Parse(horarioFinal[1]);
            int segundoFinal = int.Parse(horarioFinal[2]);

            int inicio = (diaInicial - 1) * 24 * 60 * 60 + horaInicial * 60 * 60 + minutoInicial * 60 + segundoInicial;
            int fim = (diaFinal - 1) * 24 * 60 * 60 + horaFinal * 60 * 60 + minutoFinal * 60 + segundoFinal;

            int duracao = fim - inicio;
            int diasTotais = duracao / (24 * 60 * 60);
            int resto = duracao % (24 * 60 * 60);
            int horasTotais = resto / (60 * 60);
            resto = resto % (60 * 60);
            int minutosTotais = resto / 60;
            int segundosTotais = resto % 60;

            Console.WriteLine($"{diasTotais} dia(s)");
            Console.WriteLine($"{horasTotais} hora(s)");
            Console.WriteLine($"{minutosTotais} minuto(s)");
            Console.WriteLine($"{segundosTotais} segundo(s)");
        }
    }
}