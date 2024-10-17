namespace Exercicio1_DesafioPratico1;

public class NomeComSobrenome
{
    public static string RetornarNomeConcatenadoComSobrenome(string nome, string sobrenome)
    {
        if((nome is not null && nome is not "") && (sobrenome is not null && sobrenome is not ""))
            return($"Nome Completo: {nome} {sobrenome}");
        return "Nome ou sobrenome não informados";
    }
}
