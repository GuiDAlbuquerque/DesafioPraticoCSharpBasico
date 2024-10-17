namespace Exercicio5_DesafioPratico1;

internal class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolhar uma opção de formato de exibição para a data de hoje:");
            Console.WriteLine("Data completa - 1");
            Console.WriteLine("Data formato dd/mm/aaaa - 2");
            Console.WriteLine("Hora no formato de 24 horas - 3");
            Console.WriteLine("Data com mês por extenso - 4");
            Console.WriteLine("Sair do programa - 5");
            Console.WriteLine("Digite o número da opção:");
            string escolha = Console.ReadLine();
            var exibirData = new ExibirData();
            exibirData.TiposExibicao(escolha, out continuar);
        }

    }
}
