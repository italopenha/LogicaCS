namespace TempoDeJogoEmMinutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int inicio = horaInicial * 60 + minutoInicial;
            int fim = horaFinal * 60 + minutoFinal;

            int duracao;

            if (inicio < fim)
            {
                duracao = fim - inicio;
            } else
            {
                duracao = (1440 - inicio) + fim;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");
        }
    }
}