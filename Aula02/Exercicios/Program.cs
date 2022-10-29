using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** LISTA DE EXERCÍCIOS 01 ***");
            int opcao = 0;

            do
            {
                Console.Write("- Digite o número do exercício (0 - para sair): "); //Mensagem para o usuário digitar o número do exercício
                int.TryParse(Console.ReadLine(), out opcao); //Captura e conversão a inteiro da opção digitada

                switch (opcao)
                {
                    case 1:
                        Exercicio01.executar();
                        break;
                    case 2:
                        Exercicio02.executar2();
                        break;
                    case 3:
                        Exercicio03.executar3();
                        break;
                    case 4:
                        Exercicio04.executar();
                        break;
                    case 5:
                        Exercicio05.executar();
                        break;
                    case 6:
                        Exercicio06.executar();
                        break;
                    case 99:
                        Console.WriteLine(" Saindo do Programa ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}