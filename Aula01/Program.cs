using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 37;
            string nomeAluno, sobrenomeAluno;
            bool validarIdade;
            //int
            
            //idade = idade + 1; //37 int Console.Write

            //idade++; //Nesse caso adicionarei +1 a idade depois da leitura

            //++idade; //Nesee caso adicionarei +1 a idade antes da leitura

            /* 
                Operadores Matemáticos

                + -> Soma
                - -> Subtracao
                / -> Divisao
                * -> Multiplicacao

                % -> Resto

                && -> AND
                || -> OR
                != -> DIFERENTE
                == -> IGUAL

            /*
                Um bloco de comentario
                Tudo que estiver aqui será ignorado pelo compilador
            */

            //Exemplo IF
            if(idade%2==0)
            {
                Console.WriteLine("Número par");
            }
            else
            {
                Console.WriteLine("Número ímpar");
            }

            //Exemplo FOR
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //Exemplo WHILE
            int x = 5;
            while(x > 0)
            {
                Console.WriteLine("X: " + x--);
            }

            //EXEMPLO DO WHILE
            int y = 5;
            do
            {
                Console.WriteLine("Y: " + y--);
            } while (y >0);          
            
                
            


            Console.WriteLine("A minha idade é " + idade);
        }
    }
}
