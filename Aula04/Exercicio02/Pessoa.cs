using System;

namespace Exercicio02
{
    class Pessoa
    {
        //Propriedades Encapsuladas
        private string nome; 
        private int idade;
        private float altura;

        //Construtor para classe
        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura; 
        }

        //Método get para ler o nome da pessoa
        public string getNome()
        {
            return nome;
        }
    }
}