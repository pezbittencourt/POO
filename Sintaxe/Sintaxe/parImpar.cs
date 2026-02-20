using System;
namespace Sintaxe
{
    internal class parImpar
    {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(numero % 2 == 0 ? "o numero é par" : "o numero é impar");

        }
    }
}
