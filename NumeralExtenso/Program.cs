using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string palavra;

            Console.Write("Digite um Número: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("\n");

            palavra = numero.ToWords();
            Console.WriteLine("Seu numero em palavras");
            Console.WriteLine(palavra);
        }
    }
}
