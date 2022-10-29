using System;

namespace Exercicios
{
    class Exercicio06
    {
        public static void executar()
        {
            /*
            Escreva um algoritmo para ler as dimensões de um retângulo
            (base e altura), calcular e escrever a área do retângulo.
            */
           double salarioAtual = 0, percentualReajuste = 0, novoSalario = 0;

           //Leitura dos valores
           Console.Write(" - Digite o salário mensal atual: ");
           double.TryParse(Console.ReadLine(), out salarioAtual);

           Console.Write(" - Digite o percentual do reajuste: ");
           double.TryParse(Console.ReadLine(), out percentualReajuste);

           //Calculamos o novo salário
           novoSalario = salarioAtual + (percentualReajuste/100) * salarioAtual;

           //Imprime o novo salário
           Console.WriteLine(" - O novo salário é: R$ " + Math.Round(novoSalario, 2));
        }
    }
}