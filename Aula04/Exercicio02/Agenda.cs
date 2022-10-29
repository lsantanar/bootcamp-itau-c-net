using System;

namespace Exercicio02
{
    class Agenda
    {
        private int contador = 0;

        //Array de pessoas que será nossa agenda
        private Pessoa[] agendaPessoas = new Pessoa[10];

        //Métodos da classe Agenda
        public int armazenaPessoa(string nome, int idade, float altura)
        {
            //Instancia meu objeto pessoa, passando os parametros do construtor
            Pessoa novaPessoa = new Pessoa(nome, idade, altura);
            //Coloca a nova pessoa dentro do array na primeira posição livre
            agendaPessoas[contador] = novaPessoa;
            
            //Depois de armazenar, adiciona 1 ao contador
            contador++;
        }

        //Método para buscar uma pessoa
        public int buscaPessoa(string nome)
        {
            //Variável para guardar a posição 
            int posicao = -1;

            //Loop for para percorrer o meu array e procurar a pessoa pelo nome
            for (int i = 0; i < contador; i++)
            {
                //Compara o nome passado pelo parâmetro...
                //Com o valor do objeto pessoa, dentro do array na posicao i
                if (nome.equals(agendaPessoas[i].getNome()))
                {
                    posicao = i;
                    return posicao;
                }
            }
            //Se retornar -1 é porque o nome não foi encontrado
            return posicao;
        }

        //Método para remover uma pessoa da agenda 
        //void removePessoa(String nome);

        public void removePessoa(string nome)
        {
            //Guardo em posicaoAgenda a posicao que devo remover do meu array
            //Utilizando o método buscaPessoa para encontrar a pessoa
            int posicaoAgenda = buscaPessoa(nome);

            if (posicaoAgenda > 0)
            {
                //Se for maior do que 0 eu removo  
                agendaPessoas[posicaoAgenda] = null;

                //Reordeno o meu array
                for(int i = posicaoAgenda; i < contador; i++)   
                {
                    agendaPessoas[i] = agendaPessoas[i+1];
                }    

                //Precisa subtrair -1 do contador
                contador--;      
            } else
            {
                //Se for -1, imprime mensagem para o usuario
                Console.WriteLine("- Pessoa não encontrada.");
            }
        }
    }
}