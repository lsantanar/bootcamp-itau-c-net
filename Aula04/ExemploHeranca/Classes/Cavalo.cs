using System;

namespace ExemploHeranca
{
    class Cavalo : Mamiferos // : indica que está herdando mamíferos
    {
        //Construtor subclasse
        public Cavalo(string nomeAnimal):base(nomeAnimal)
        {
            
        }

        //Método próprio da classe
        public void Galopar()
        {
            Console.WriteLine("Sou capaz de galopar.");
        }
    }
}
