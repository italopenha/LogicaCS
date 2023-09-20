namespace SenhaFixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;
            int senha = int.Parse(Console.ReadLine());
            
            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}