namespace ConversaoDeTempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int horas = n / 3600;
            int resto = n % 3600;

            int minutos = resto / 60;
            int segundos = resto % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}