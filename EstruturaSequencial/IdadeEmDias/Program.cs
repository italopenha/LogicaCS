namespace IdadeEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade em dias:");
            int idadeEmDias = int.Parse(Console.ReadLine());

            int ano = 365;
            int mes = 30;

            int idadeEmAnos = idadeEmDias / ano;
            int restoAnos = idadeEmDias % ano;
            int idadeEmMeses = restoAnos / mes;
            int restoMeses = restoAnos % mes;
            int idadeDias = restoMeses;

            Console.WriteLine($"{idadeEmAnos} ano(s)");
            Console.WriteLine($"{idadeEmMeses} mes(es)");
            Console.WriteLine($"{idadeDias} dia(s)");
        }
    }
}