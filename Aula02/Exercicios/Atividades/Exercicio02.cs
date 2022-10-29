using System;

namespace Exercicios
{
    class Exercicio02
    {
        public static void executar2()
        {
            /*
            Escreva um algoritmo para ler um valor (do teclado) e
            escrever (na tela) o seu antecessor.
            */

            Console.Write("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int valorDigitado);
            --valorDigitado;
            Console.WriteLine("Número antecessor: " + valorDigitado);
        }
    }
}