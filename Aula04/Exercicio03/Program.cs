using System;
using Exercicio03.Classes;

namespace Exercicio03
{
    class Program
    {
        /*
            3. Crie uma classe denominada Elevador para armazenar as informações de um elevador
            dentro de um prédio. A classe deve armazenar o andar, total de andares
            no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
            presentes nele. A classe deve também disponibilizar os seguintes métodos:
            
            Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
            andares no prédio (os elevadores sempre começam no térreo e vazio);
            
            Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
            espaço);
            Sai : para remover uma pessoa do elevador (só deve remover se houver alguém
            dentro dele);
            
            Sobe : para subir um andar (não deve subir se já estiver no último andar);
            
            Desce : para descer um andar (não deve descer se já estiver no térreo);
            
            Encapsular todos os atributos da classe (criar os métodos set e get).
        */
        static void Main(string[] args)
        {
            //Instanciar meu elevador
            Elevador elevador1 = new Elevador();

            //Inicializar o elevador
            elevador1.Inicializa(10,6);

            //Nosso elevador começa sempre no térreo.
            //Coloco 5 pessoas no elevador
            for(int i = 0; i < 5; i++)
            {
                elevador1.Entra();
            }

            //Subir meu elevador
            //Deveria chegar ao andar 1
            elevador1.Sobe();

            //Subir mais uma pessoa no andar 1
            elevador1.Entra();

            //Subir para o andar 2
            elevador1.Sobe();

            //Vão descer 3 pessoas
            for(i = 0; i < 3; i++)
            {
                elevador1.Sai();
            }

            //E vão subir 10 pessoas
            for(i = 0; i < 10; i++)
            {
                elevador1.Entra();
            }

            //Subir até o andar 4
            elevador1.Sobe();
        }
    }
}