namespace Exercicio3_DesafioPratico1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        string palavras = Console.ReadLine();

        var contadorCaracteres = new ContadorDeCaracteres();
        Console.WriteLine(contadorCaracteres.contadorDeCaracteresSemEspaco(palavras));

    }
}
