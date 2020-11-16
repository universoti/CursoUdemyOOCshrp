using ExePrimeiraLista.Cadastros.Aluno;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ExePrimeiraLista
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<string> lnomesAlunos = new List<string>();
        //    var nome = "Erick Fernando";
        //    lnomesAlunos.Add(nome);

        //    nome = "Fernanda ";
        //    lnomesAlunos.Add(nome);

        //    nome = "Roberto";
        //    lnomesAlunos.Add(nome);

        //    lnomesAlunos.Remove(nome);

        //    Console.WriteLine("Hello World!");
        //}

        static void Main(string[] args)
        {
           // enum formacao { fundamental, medio, superior };
            List<string> lnomesAlunos = new List<string>();

            Aluno objAluno = new Aluno()  //dia dia 
            {
                nome = "Eliabe dias",
                altura = 1.67,
                formacao_escolar="superior",
                idade=24,
                peso=61
                            
            };  //inicializer 
            //jeito mais complicado
            //objAluno.nome = "";
            //objAluno.altura = 1.65;
            


            Console.WriteLine("Aluno cadastrado! "+objAluno.nome);
            Console.WriteLine("Idade: " + objAluno.idade.ToString());
        }
    }
}
