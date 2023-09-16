namespace TiposDeTriangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            float n1 = float.Parse(valores[0]);
            float n2 = float.Parse(valores[1]);
            float n3 = float.Parse(valores[2]);

            float a = 0.0f, b = 0.0f, c = 0.0f;

            if (n1 > n2 && n1 > n3)
            {
                a = n1;
                if (n2 > n3)
                {
                    b = n2;
                    c = n3;
                }
                else
                {
                    c = n3;
                    b = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                a = n2;
                if (n1 > n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                a = n3;
                if (n1 > n2)
                {
                    b = n1;
                    c = n2;
                }
                else
                {
                    b = n2;
                    c = n1;
                }
            }
            else if (n1 == n2 && n3 > n2)
            {
                a = n3;
                b = n1;
                c = n2;
            }
            else if (n1 < n2 && n2 == n3)
            {
                a = n3;
                b = n2;
                c = n1;
            }
            else if (n1 > n2 && n3 == n1)
            {
                a = n3;
                b = n1;
                c = n2;
            }
            else
            {
                a = n1;
                b = n2;
                c = n3;
            }
            
            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } else
            {
                if (a * a == b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                } else if (a * a > b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                } else if (a * a < b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
            }

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}