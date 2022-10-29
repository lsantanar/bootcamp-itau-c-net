using System;

namespace Exercicio03.Classes
{
    class Elevador
    {
        //Propriedades ou Atributos
        private int andarAtual = 0;
        private int totalAndares = 0;
        private int capacidade = 0;
        private int totalPessoasAtual = 0;

        //Métodos
        public void Inicializa(int capacidade, int totalAndares)
        {
            this.capacidade = capacidade;
            this.totalAndares = totalAndares;
            this.andarAtual = 0;
            this.totalPessoasAtual = 0;
        }

        public void Entra()
        {
            if(totalPessoasAtual < capacidade)
            {
                ++totalPessoasAtual;
                Console.WriteLine("- Entrou uma pessoa. ({0})",totalPessoasAtual);
                
            } else
            {
                Console.WriteLine("- Elevador está cheio");
            }
        }

        public void Sai()
        {
            if(totalPessoasAtual > 0)
            {
                --totalPessoasAtual;
                Console.WriteLine("- Saiu uma pessoa ({0})", totalPessoasAtual);
                
            } else
            {
                Console.WriteLine("- Não há ninguém dentro do elevador");
            }
        }

        public void Sobe()
        {
            if(andarAtual < totalAndares)
            {
                ++andarAtual;
                Console.WriteLine("- Subindo. Andar {0}",andarAtual);
            }else
            {
                Console.WriteLine("- O Elevador já está no último andar");
            }

        }

        public void Desce()
        {
            if(andarAtual > 0)
            {
                --andarAtual;
                Console.WriteLine("- Descendo. Andar {0}",andarAtual);
            }else
            {
                Console.WriteLine("- O Elevador já está no térreo");
            }
        }
    }
}