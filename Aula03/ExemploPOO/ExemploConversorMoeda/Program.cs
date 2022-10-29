using System;

namespace ExemploConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroReal obj = new ConversorEuroReal();
            Console.WriteLine(obj.converter(100));

            obj.mudarValorEuro(6.10);
            Console.WriteLine(obj.converter(100));

            obj.mudarValorEuro(-5);
            Console.WriteLine(obj.converter(100));  
        }
    }
}