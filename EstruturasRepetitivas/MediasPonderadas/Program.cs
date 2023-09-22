namespace MediasPonderadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a, b, c, mediaPonderada = 0.0;

            n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                a = double.Parse(valores[0]);
                b = double.Parse(valores[1]);
                c = double.Parse(valores[2]);

                mediaPonderada = (a * 2 + b * 3 + c * 5) / (2 + 3 + 5);
                Console.WriteLine(mediaPonderada.ToString("F1"));
            } 
        }
    }
}