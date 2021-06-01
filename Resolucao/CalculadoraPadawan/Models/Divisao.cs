namespace CalculadoraPadawan.Models
{
    internal class Divisao : OperacaoBase
    {
        public override double Calcula(double numerador, double denominador)
        {
            resultado = numerador / denominador;

            return resultado;
        }
    }
}
