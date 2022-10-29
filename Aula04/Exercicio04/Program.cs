using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto controle = new ControleRemoto();
            Console.WriteLine(controle.AumentarVol());
        }
    }
}