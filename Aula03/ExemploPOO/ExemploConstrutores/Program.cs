using System;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro peugeotPrata = new Carro("Peugeot" , "Prata"); //quando tá em parênteses está chamando o construtor
            peugeotPrata.setExtras(true, "Radio Android 7");
            Console.WriteLine($"*** Total Carros: {Carro.ContadorCarros()}");
            Console.WriteLine(peugeotPrata.getInfoCarro());
            Console.WriteLine(peugeotPrata.getExtras());
            Console.WriteLine("----------------------------------------------------");

            Carro corollaPreto = new Carro("Toyota" , "Corolla");
            corollaPreto.setExtras(false, "Radio CD MP3");
            Console.WriteLine(corollaPreto.getInfoCarro());
            Console.WriteLine(corollaPreto.getExtras());
        }
    }
}
