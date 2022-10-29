using System;

namespace ClassesAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {
            var variavelAnonima = new {Nome="José" , Idade=19};
            Console.WriteLine(variavelAnonima.Nome);

            var variavelAnonima2 = new {Nome="Lucas" , Idade=19};
        }
    }
}