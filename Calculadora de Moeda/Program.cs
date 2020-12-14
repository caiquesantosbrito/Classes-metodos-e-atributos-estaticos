using System;
using Calculadora_de_Moeda.Classe;

namespace Calculadora_de_Moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2,5));

            Console.WriteLine("Digite um valor:");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor de dolar para real é: ");
            Console.WriteLine(Conversor.ConverterDolarParaReal());
            Console.WriteLine("Valor de real para dolar é: ");
            Console.WriteLine(Conversor.ConverterRealParaDolar());
            Console.WriteLine("Valor de euro para para real é: ");
            Console.WriteLine(Conversor.CoverterEuroParaReal());
            Console.WriteLine("Valor de real para euro é: ");
            Console.WriteLine(Conversor.ConverterRealParaEuro());

            Testar();
        }
        static void Testar(){
            
        }
    }
}
