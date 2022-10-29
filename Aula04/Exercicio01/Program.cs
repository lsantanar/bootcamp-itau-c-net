using System;

namespace exercicio01
{

/*
Crie uma classe para representar uma pessoa, com os atributos privados de nome, data de
nascimento e altura. Crie os métodos públicos necessários para sets e gets e também um
método para imprimir todos dados de uma pessoa. Crie um método para calcular a idade
da pessoa
*/

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Rodrigo",new DateTime(1988, 12, 22), 1.84);
            
            p1.getExibirDados();

            p1.setNome("Baronny");
            p1.getExibirDados();
        }
    }
}