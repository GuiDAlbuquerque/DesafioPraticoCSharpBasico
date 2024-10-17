namespace Exercicio1_DesafioPratico1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();

        MensagemBoasVindas.ExibirMensagemBoasVindas(nomeDigitado: nome);
        Console.WriteLine(NomeComSobrenome.RetornarNomeConcatenadoComSobrenome(nome, sobrenome));
    }
}
