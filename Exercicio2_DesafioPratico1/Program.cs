namespace Exercicio2_DesafioPratico1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        string numero1 = Console.ReadLine();

        Console.WriteLine("Digite o segundo número:");
        string numero2 = Console.ReadLine();

        double numero1Double = Double.Parse(numero1);
        double numero2Double = Double.Parse(numero2);

        var operacoesMatematicas = new OperacoesMatematicas();

        Console.WriteLine(operacoesMatematicas.Soma(numero1Double, numero2Double));
        Console.WriteLine(operacoesMatematicas.Subtracao(numero1Double, numero2Double));
        Console.WriteLine(operacoesMatematicas.Multiplicacao(numero1Double, numero2Double));
        Console.WriteLine(operacoesMatematicas.Divisao(numero1Double, numero2Double) != null ? operacoesMatematicas.Divisao(numero1Double, numero2Double) : "Não é possivel dividir por zero.");
        Console.WriteLine(operacoesMatematicas.Media(numero1Double, numero2Double));
    }
}
