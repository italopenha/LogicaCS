namespace TipoDeCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0, alcool = 0, gasolina = 0, diesel = 0;

            while (codigo != 4)
            {
                codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}