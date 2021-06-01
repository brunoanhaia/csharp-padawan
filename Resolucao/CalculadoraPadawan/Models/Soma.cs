namespace CalculadoraPadawan.Models
{
    internal class Soma : OperacaoBase
    {
        public override double Calcula(double primeiroNumero, double segundoNumero)
        {
            resultado = primeiroNumero + segundoNumero;

            return resultado;
        }
    }
}
