namespace Exercicio1_DesafioPratico1;

public class MensagemBoasVindas
{
    public static void ExibirMensagemBoasVindas(string nomeDigitado)
    {
        if (nomeDigitado is not null && nomeDigitado is not "")
            Console.WriteLine($"Olá,{nomeDigitado}! Seja muito bem - vindo(a)!");
    }
}
