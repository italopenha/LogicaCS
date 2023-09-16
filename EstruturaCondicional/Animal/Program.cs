namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            if (a == "vertebrado" && b == "ave" && c == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (a == "vertebrado" && b == "ave" && c == "onivoro")
            {
                Console.WriteLine("pomba");
            }

            if (a == "vertebrado" && b == "mamifero" && c == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (a == "vertebrado" && b == "mamifero" && c == "herbivoro")
            {
                Console.WriteLine("vaca");
            }

            if (a == "invertebrado" && b == "inseto" && c == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (a == "invertebrado" && b == "inseto" && c == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }

            if (a == "invertebrado" && b == "anelideo" && c == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (a == "invertebrado" && b == "anelideo" && c == "onivoro")
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}