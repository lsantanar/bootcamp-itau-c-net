using System;

namespace Exercicios
{
    class Exercicio03
    {
        public static void executar3()
        {
            /*
            Escreva um algoritmo para ler as dimensões de um retângulo
            (base e altura), calcular e escrever a área do retângulo.
            */

           int baseRetangulo, alturaRetangulo;
            Console.Write("Digite o valor da Base do Retângulo: ");
            if (int.TryParse(Console.ReadLine(), out baseRetangulo))
           {
                Console.Write("Digite o valor da altura do retângulo: ");
                if (int.TryParse(Console.ReadLine(), out alturaRetangulo))
                {
                    int areaRetangulo = baseRetangulo * alturaRetangulo;
                    Console.WriteLine(" --> Área do Retângulo: " + areaRetangulo);
                } else {
                    Console.WriteLine("Valor inválido para altura");
                }
           } else
           {
               Console.WriteLine("Valor Inválido para a base.");
           }
        }
    }
}