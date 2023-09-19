namespace ParesImparesPositivosNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            if (n1 % 2 == 0 && n1 > 0)
            {
                pares++;
                positivos++;
            }
            else if (n1 % 2 != 0 && n1 < 0)
            {
                impares++;
                negativos++;
            }
            else if (n1 % 2 == 0 && n1 < 0)
            {
                pares++;
                negativos++;
            }
            else if (n1 % 2 != 0 && n1 > 0)
            {
                impares++;
                positivos++;
            }
            else if (n1 == 0)
            {
                pares++;
            }


            if (n2 % 2 == 0 && n2 > 0)
            {
                pares++;
                positivos++;
            }
            else if (n2 % 2 != 0 && n2 < 0)
            {
                impares++;
                negativos++;
            }
            else if (n2 % 2 == 0 && n2 < 0)
            {
                pares++;
                negativos++;
            }
            else if (n2 % 2 != 0 && n2 > 0)
            {
                impares++;
                positivos++;
            }
            else if (n2 == 0)
            {
                pares++;
            }

            if (n3 % 2 == 0 && n3 > 0)
            {
                pares++;
                positivos++;
            }
            else if (n3 % 2 != 0 && n3 < 0)
            {
                impares++;
                negativos++;
            }
            else if (n3 % 2 == 0 && n3 < 0)
            {
                pares++;
                negativos++;
            }
            else if (n3 % 2 != 0 && n3 > 0)
            {
                impares++;
                positivos++;
            }
            else if (n3 == 0)
            {
                pares++;
            }

            if (n4 % 2 == 0 && n4 > 0)
            {
                pares++;
                positivos++;
            }
            else if (n4 % 2 != 0 && n4 < 0)
            {
                impares++;
                negativos++;
            }
            else if (n4 % 2 == 0 && n4 < 0)
            {
                pares++;
                negativos++;
            }
            else if (n4 % 2 != 0 && n4 > 0)
            {
                impares++;
                positivos++;
            }
            else if (n4 == 0)
            {
                pares++;
            }

            if (n5 % 2 == 0 && n5 > 0)
            {
                pares++;
                positivos++;
            }
            else if (n5 % 2 != 0 && n5 < 0)
            {
                impares++;
                negativos++;
            }
            else if (n5 % 2 == 0 && n5 < 0)
            {
                pares++;
                negativos++;
            }
            else if (n5 % 2 != 0 && n5 > 0)
            {
                impares++;
                positivos++;
            }
            else if (n5 == 0)
            {
                pares++;
            }

            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}