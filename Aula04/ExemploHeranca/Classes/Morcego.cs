using System;

namespace ExemploHeranca
{
    class Morcego : Mamiferos
    {
        //Construtor
        public Morcego(string nomeMamifero):base(nomeMamifero)
        {

        }

        public void Voar()
        {
            Console.WriteLine("Sou capaz de voar.");
        }
    }
}