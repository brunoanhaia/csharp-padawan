using CalculadoraPadawan.Interface;

namespace CalculadoraPadawan.Models
{
    internal abstract class OperacaoBase
    {
        protected double resultado;

        public abstract double Calcula(double primeiroNumero, double segundoNumero);

        public override string ToString()
        {
            return resultado.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
