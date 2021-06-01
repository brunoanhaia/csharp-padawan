using System;
using System.Collections.Generic;
using System.Linq;
using CalculadoraPadawan.Interface;

namespace CalculadoraPadawan.Models
{
    internal class CalculadoraBasica: ICalculadora
    {
        private double primeiroNumero;
        private double segundoNumero;
        private TipoOperacao tipoOperacao;
        private OperacaoBase operacao;

        private enum TipoOperacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao,
        };

        private Dictionary<string, TipoOperacao> dictOperacaoSimbolo = new Dictionary<string, TipoOperacao>
        {
            { "+", TipoOperacao.Soma },
            { "-", TipoOperacao.Subtracao },
            { "*", TipoOperacao.Multiplicacao },
            { "/", TipoOperacao.Divisao },
        };

        public CalculadoraBasica(string entrada)
        {
            RecebeEntrada(entrada);
        }

        private void RecebeEntrada(string entrada)
        {
            string[] arrayEntrada;
            try
            {
                arrayEntrada = entrada.Split(' ');

                if (arrayEntrada.Length == 3)
                {
                    primeiroNumero = double.Parse(arrayEntrada[0], System.Globalization.CultureInfo.InvariantCulture);
                    segundoNumero = double.Parse(arrayEntrada[2], System.Globalization.CultureInfo.InvariantCulture);

                    tipoOperacao = AdivinhaOperacao(arrayEntrada[1]);
                }
                else
                {
                    throw new ApplicationException();
                }
            }
            catch
            {
                throw new ApplicationException("Entrada inválida, por favor insira uma entrada válida");
            }

            if (tipoOperacao == TipoOperacao.Divisao && segundoNumero == 0)
            {
                throw new DivideByZeroException("Não é possível realizar a divisão por zero");
            }
        }
        private TipoOperacao AdivinhaOperacao(string entrada)
        {
            if (entrada.Length == 1)
            {
                if (dictOperacaoSimbolo.ContainsKey(entrada))
                {
                    return dictOperacaoSimbolo[entrada];
                }
            }

            throw new ApplicationException();
        }

        public string ExecutaOperacao()
        {
            switch (tipoOperacao)
            {
                case TipoOperacao.Soma:
                    operacao = new Soma();
                    break;
                case TipoOperacao.Subtracao:
                    operacao = new Subtracao();
                    break;
                case TipoOperacao.Multiplicacao:
                    operacao = new Multiplicacao();
                    break;
                case TipoOperacao.Divisao:
                    operacao = new Divisao();
                    break;
                default:
                    throw new ApplicationException();
            }

            operacao.Calcula(primeiroNumero, segundoNumero);

            return operacao.ToString();
        }
    }
}
