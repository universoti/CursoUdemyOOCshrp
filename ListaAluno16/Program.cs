using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ListaAluno16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> ListaAlunos = new List<Aluno>();

            for (int i = 0; i <= 3; i++)
            {
                Aluno CadAluno = new Aluno();

                Console.WriteLine("Digite o nome do aluno!");
                CadAluno.nome = Console.ReadLine();
                Console.WriteLine("Digite idade do aluno!");
                CadAluno.idade = Convert.ToInt32(Console.ReadLine());
                ListaAlunos.Add(CadAluno);

            }


            foreach (var item in ListaAlunos)
            {
                
                Console.WriteLine($@"Alunos {item.nome} cadastrado com sucesso!");
            }

            
            Console.WriteLine("Alunos foram todos cadastrados!");
        }
    }
}
