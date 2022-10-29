using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de Operador Ternario 
            /*
            string saudacao = DateTime.Now.AddHours(-4).Hour > 12 ? "Boa Tarde" : "Bom dia";
            Console.WriteLine(saudacao + " - Hora: " + DateTime.Now.AddHours(-4).Hour);
            saudacao = DateTime.Now.Hour > 12 ? "Boa Tarde" : "Bom dia";
            Console.WriteLine(saudacao + " - Hora: " + DateTime.Now.Hour + ":"+DateTime.Now.Minute);
            Console.WriteLine(saudacao + " - Hora: " + DateTime.Now.ToShortTimeString());
            Console.WriteLine(saudacao + " - Hora: " + DateTime.Now.ToString("HH:mm:ss"));
            
            int idade = 20;
            Console.WriteLine(idade > 18 ? "Maior de Idade" : "Menor de Idade");
            */

            //Exemplo Switch...Case

        do
        {
            Console.Write("Digite o dia da semana: ");
            if(int.TryParse(Console.ReadLine(), out int diaSemana))
            {
                //Usando Switch
                switch(diaSemana)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Segunda");
                        break;
                    case 3:
                        Console.WriteLine("Terça");
                        break;
                    case 4:
                        Console.WriteLine("Quarta");
                        break;
                    case 5:
                        Console.WriteLine("Quinta");
                        break;
                    case 6:
                        Console.WriteLine("Sexta");
                        break;
                    case 7:
                        Console.WriteLine("Sábado");
                        break;
                    default:
                        Console.WriteLine("Dia Inválido");
                        break;
                }

                //Exemplo utilizando IF...Else
                /*
                if(diaSemana == 1)
                {
                    Console.WriteLine("Domingo");
                } else if (diaSemana == 2)
                {
                    Console.WriteLine("Segunda");
                } else if (diaSemana == 3)
                {
                    Console.WriteLine("Terça");
                }else if (diaSemana == 4)
                {
                    Console.WriteLine("Quarta");
                }
                else if (diaSemana == 5)
                {
                    Console.WriteLine("Quinta");
                }
                else if (diaSemana == 6)
                {
                    Console.WriteLine("Sexta");
                }
                else if (diaSemana == 7)
                {
                    Console.WriteLine("Sábado");
                } else
                {
                    Console.WriteLine("Dia inválido");
                }
                */
            }else
            {
                Console.WriteLine("Formato Inválido");
            }

            } while(diaSemana != 99);
                Console.WriteLine("*** Fim Programa ***"); 
        }
    }
}
