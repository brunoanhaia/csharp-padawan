namespace CalculadoraPadawan.Models
{
    internal class Subtracao : OperacaoBase
    {
        public override double Calcula(double primeiroNumero, double segundoNumero)
        {
            resultado = primeiroNumero - segundoNumero;

            return resultado;
        }
    }
}
