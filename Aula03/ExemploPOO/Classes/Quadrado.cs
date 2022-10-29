using System;

namespace ExemploPOO
{
    class Quadrado
    {
        //int area = lado1 * lado2;
        //return lado * lado
        
        //Método
        public double calcularArea(double lado)
        {
            return Math.Pow(lado,2); //Pow = Potência, eleva algum número ao quadrado.
        }
    }
}