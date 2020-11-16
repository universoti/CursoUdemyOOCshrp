using System;

namespace ExercicioCapCinco
{
    class Program
    {
        //mensagem 1
        //Aluno cadastrado com sucesso!
        //mensagem
        //Aluno
        //Codigo: cod_aluno
        //nome : nome_aluno
        //idade : idade
        //Escolaridade: ds_escolaridade

        
        static void Main(string[] args)
        {
            
            int cod_aluno = 0;
            string nome_aluno = "";
            int idade = 0;
            string ds_escolaridade = "";
            
            Console.WriteLine("Digite codigo do aluno");
            cod_aluno = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite nome do aluno");
            nome_aluno = Console.ReadLine();
            
            Console.WriteLine("Digite idade do aluno");
            idade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite escolaridade do aluno");
            ds_escolaridade = Console.ReadLine();

            string sidentificacaoaluno = "Cod.: "+cod_aluno.ToString() 
                                                +" Nome: " +nome_aluno;
            string sidade = "idade: " + idade.ToString();
            string sescola = "Escolaridade: " + ds_escolaridade;
            Console.WriteLine("  ");
            Console.WriteLine("xxxxxxxxx");
            Console.WriteLine("Aluno cadastrado com sucesso!");
            Console.WriteLine("Aluno!");
            Console.WriteLine("----------");
            Console.WriteLine(sidentificacaoaluno);
            Console.WriteLine("----------");
            Console.WriteLine(sidade);
            Console.WriteLine("----------");
            Console.WriteLine(sescola);




        }
    }
}
