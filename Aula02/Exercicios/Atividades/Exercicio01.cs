using System;

namespace Exercicios
{
    class Exercicio01
    {
        public static void executar()
        {
                    /*Escreva um algoritmo que armazene o valor 10 em uma variável A e o 
                    valor 20 em uma variável B. A seguir (utilizando apenas atribuições entre 
                    variáveis) troque os seus conteúdos fazendo com que o valor que está em 
                    A passe para B e vice-versa. Ao final, escrever os valores que ficaram 
                    armazenados nas variáveis.*/
            int A = 10;
            int B = 20;

            A = B;
            B = A;

            Console.WriteLine("A: " + A + " - B: " + B);
        }
    }
}