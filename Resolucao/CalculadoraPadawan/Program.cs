using System;
using System.Globalization;
using CalculadoraPadawan.Models;

namespace CalculadoraPadawan
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("== Bem vindo a calculadora Padawan! ==");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Insira a entrada no seguinte formato: ");
            Console.WriteLine("       numero  operador  numero       ");
            Console.WriteLine();
            Console.WriteLine("Se quiser parar a execução digite SAIR");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");

            const string sair = "SAIR";
            string entrada = string.Empty;

            while (entrada != sair)
            {
                entrada = Console.ReadLine();

                try
                {
                    CalculadoraBasica calc = new CalculadoraBasica(entrada);
                    string resultado = calc.ExecutaOperacao();
                    Console.WriteLine($"Resultado: {resultado}", CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
            }
        }
    }
}
