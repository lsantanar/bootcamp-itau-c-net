using System;

namespace ExemploHeranca
{
    class Mamiferos
    {
        //Propriedade Encapsulada
        private string nomeAnimal;

        //Construtor
        public Mamiferos(string nomeAnimal)
        {
            this.nomeAnimal = nomeAnimal;
        }

        //Define dois métodos comuns a todos os mamíferos
        public void Respirar()
        {
            Console.WriteLine("Sou capaz de respirar.");
        }

        public void CuidarFilhotes()
        {
            Console.WriteLine("Cudo dos meus filhotes");
        }

        public void getNomeAnimal()
        {
            Console.WriteLine("- O nome do animal é: " + nomeAnimal);
        }

        public void Pensar()
        {
            Console.WriteLine("Pensamento básico instintivo");
        }
    }
}