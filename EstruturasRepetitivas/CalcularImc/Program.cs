namespace CalcularImc;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Digite o seu peso (Kg):");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura (m):");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (Math.Pow(altura, 2));

        switch (imc)
        {
            case < 18.5:
                Console.WriteLine($"Seu IMC é {imc.ToString("F2")}. Você está abaixo do peso!");
                break;
            case < 25:
                Console.WriteLine($"Seu IMC é {imc.ToString("F2")}. Você está no peso ideal!");
                break;
            case < 30:
                Console.WriteLine($"Seu IMC é {imc.ToString("F2")}. Você está com sobrepeso!");
                break;
            case < 35:
                Console.WriteLine($"Seu IMC é {imc.ToString("F2")}. Você está com obesidade grau 1!");
                break;
            case < 40:
                Console.WriteLine($"Seu IMC é {imc.ToString("F2")}. Você está com obesidade grau 2!");
                break;
            case > 40:
                Console.WriteLine($"Seu IMC é {imc.ToString("F2")}. Você está com obesidade severa!");
                break;
            default:
                Console.WriteLine("Erro!");
                break;
        }
    }
}
