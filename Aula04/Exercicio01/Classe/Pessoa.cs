using System;

namespace exercicio01
{
    class Pessoa
    {   
        //declarei variaveis
        private string nome;
        private DateTime dataNascimento;
        private double altura;
        int idade = 0;

        //construtor
        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.altura = altura;
        }

        //criação dos gets
        public void getExibirDados()
        {
            Console.WriteLine("Nome: " + nome + "\n Data de Nascimento: " + dataNascimento.ToShortDate
        }

        //criação dos sets
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        //criação do método calcular idade
        public int CalcularIdade()
        {

            int idade = DateTime.Today.Year - this.dataNascimento.Year;
            return idade;
        }
    }
}