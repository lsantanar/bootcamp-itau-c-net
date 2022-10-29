namespace Aula02
{
    class ExemploExcecoes
    {
        public static void ExemploExcecoes()
        {
            try
            {
                 Console.Write("Digite a idade do aluno: ");
                 int idadeAluno = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Idade Inválida");
            
            }finally
            {
                //Sempre vai ser executado 
        }    
    
    }
}