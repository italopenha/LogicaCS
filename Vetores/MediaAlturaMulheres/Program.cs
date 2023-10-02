namespace MediaAlturaMulheres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pessoas:");
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexo = new char[n];

            Console.WriteLine($"Digite a altura e o sexo de cada pessoa separados por um espaço:");

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(valores[0]);
                sexo[i] = char.Parse(valores[1]);
            }

            double maiorAltura = 0.0;
            double menorAltura = 3.0;

            foreach (double a in alturas)
            {
                if (a > maiorAltura)
                {
                    maiorAltura = a;
                }

                if (a < menorAltura)
                {
                    menorAltura = a;
                }
            }

            double soma = 0.0;
            int contMulheres = 0;
            int contHomens = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexo[i] == 'f' || sexo[i] == 'F')
                {
                    soma += alturas[i];
                    contMulheres++;
                }

                if (sexo[i] == 'm' || sexo[i] == 'M')
                    contHomens++;
            }

            double media = soma / contMulheres;

            Console.WriteLine($"Menor altura = {menorAltura.ToString("F2")}");
            Console.WriteLine($"Maior altura = {maiorAltura.ToString("F2")}");
            Console.WriteLine($"Media das alturas das mulheres = {media.ToString("F2")}");
            Console.WriteLine($"Numero de homens = {contHomens}");
        }
    }
}