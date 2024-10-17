namespace Exercicio2_DesafioPratico1;

public class OperacoesMatematicas
{
    public double Soma(double valor1, double valor2)
    {
        return valor1 + valor2;
    }

    public double Subtracao(double valor1, double valor2)
    {
        return valor1 - valor2;
    }

    public double Multiplicacao(double valor1, double valor2)
    {
        return valor1 * valor2;
    }
    public double? Divisao(double valor1, double valor2)
    {
        if (!valor2.Equals(0))
            return valor1 / valor2;
        return null;
    }
    public double Media(double valor1, double valor2)
    {
        return (valor1 + valor2) / 2;
    }
}
