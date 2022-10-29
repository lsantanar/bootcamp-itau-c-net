using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Cavalo mangaLarga = new Cavalo("Pé de Pano");
            Humano sapiens = new Humano("José");
            Morcego vampiro = new Morcego("Batman");

            Console.WriteLine("*******Cavalo*******");
            mangaLarga.getNomeAnimal();
            mangaLarga.CuidarFilhotes();
            mangaLarga.Respirar();
            mangaLarga.Galopar();

            Console.WriteLine("*******Humano*******");
            sapiens.getNomeAnimal();
            sapiens.Pensar();
            sapiens.Respirar();

            Console.WriteLine("*******Morcego*******");
            vampiro.getNomeAnimal();
            vampiro.Voar();
        }
    }
}