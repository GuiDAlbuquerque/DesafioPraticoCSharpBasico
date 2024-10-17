using System.Text.RegularExpressions;

namespace Exercicio4_DesafioPratico1;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite uma placa válida:");
        string placa = Console.ReadLine();

        var validadorPlaca = new ValidadorPlaca();
        Console.WriteLine(validadorPlaca.padraoValido(placa) ? "verdadeiro" : "falso");
    }
}
