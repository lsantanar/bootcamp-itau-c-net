using System;

namespace Exercicios
{
    class Exercicio03
    {
        public static void executar()
        {
            int dias, meses, anos;

            Console.WriteLine("informe sua idade");
            int.TryParse(Console.ReadLine(), out int anos);
            
            Console.WriteLine("meses");
            int.TryParse(Console.ReadLine(), out int meses);

            Console.WriteLine("dias");
            int.TryParse(Console.ReadLine(), out int dias);

            dias = (dias+(anos*365)+(meses*30));

            Console.WriteLine("sua idade em dias é: " + dias);
        }
    }
}