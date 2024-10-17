using System.Linq;

namespace Exercicio3_DesafioPratico1;

public class ContadorDeCaracteres
{
    public int? contadorDeCaracteresSemEspaco(string palavras) 
    {
        if (palavras is null)
            return null;

        if (palavras.Contains(" "))
        {
            var listaPalavrasSemEspaco = palavras.Split(' ');
            return String.Join("", listaPalavrasSemEspaco).Length;
        };
        return palavras.Length;
    }
}
