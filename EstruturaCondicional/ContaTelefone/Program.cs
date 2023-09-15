namespace ContaTelefone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os minutos utilizados:");
            int minutos = int.Parse(Console.ReadLine());

            double conta = 50.0;

            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine($"Valor a pagar: R$ {conta.ToString("F2")}");
        }
    }
}