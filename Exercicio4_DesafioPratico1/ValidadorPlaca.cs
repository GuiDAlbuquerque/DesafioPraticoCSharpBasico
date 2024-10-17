using System.Numerics;
using System.Text.RegularExpressions;

namespace Exercicio4_DesafioPratico1;

public class ValidadorPlaca
{
    Regex placaPattern = new Regex(@"([A-Z]{3}[0-9]{4})$", RegexOptions.IgnoreCase);

    public bool padraoValido(string placa)
    {
        if (placa is null)
            return false;
        return placaPattern.IsMatch(placa);
    }
}
