namespace CalculadoraPadawan.Models
{
    internal class Multiplicacao : OperacaoBase
    {
        public override double Calcula(double primeiroNumero, double segundoNumero)
        {
            resultado = primeiroNumero * segundoNumero;

            return resultado;
        }
    }
}
