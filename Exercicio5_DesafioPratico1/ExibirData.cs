using Microsoft.VisualBasic;

namespace Exercicio5_DesafioPratico1;

public class ExibirData
{
    public void TiposExibicao(string opcao, out bool continuar) 
    {
        var dataAtual = DateTime.Now;

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Você escolheu a Opção 1");
                Console.WriteLine(dataAtual.ToString());
                Console.WriteLine(" ");
                continuar = true;
                break;
            case "2":
                Console.WriteLine("Você escolheu a Opção 2");
                Console.WriteLine(dataAtual.ToString("d"));
                Console.WriteLine(" ");
                continuar = true;
                break;
            case "3":
                Console.WriteLine("Você escolheu a Opção 3");
                Console.WriteLine(dataAtual.ToString("T"));
                Console.WriteLine(" ");
                continuar = true;
                break;
            case "4":
                Console.WriteLine("Você escolheu a Opção 4");
                Console.WriteLine(dataAtual.ToString("D"));
                Console.WriteLine(" ");
                continuar = true;
                break;
            case "5":
                Console.WriteLine("Saindo...");
                continuar = false;
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                continuar = true;
                break;
        }

    }

}
