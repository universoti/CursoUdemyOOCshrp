using System;
using System.Collections.Generic;

namespace CalculaSalario14
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Funcionario Func = new Funcionario();
        //    Console.WriteLine("Digite o nome do funcionario");
        //    Func.nome = Console.ReadLine();

        //    Console.WriteLine("Digite a idade do funcionario");
        //    Func.idade = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Digite quantidade de hrs trabalhadas  do funcionario");
        //    Func.TotalHorasMes = Convert.ToDecimal(Console.ReadLine());

        //    Console.WriteLine("Digite a nacionalidade do funcionario(br,ex)");
        //    Func.nacionalidade = Console.ReadLine();
        //    var resposta = CalculosFuncionario.tipoSupevisor; //exemplo so pra demonstrar,nao serve pra nada
        //    //refatorando CalculosFuncionario Calculos = new CalculosFuncionario();
        //    //refatorandovar SalarioTotal = Calculos.ReturnaSal(Func.TotalHorasMes, Func.nacionalidade);
        //    var SalarioTotal = CalculosFuncionario.ReturnaSal(Func.TotalHorasMes, Func.nacionalidade);

        //    Console.WriteLine($@"Funcionario : {Func.nome}");
        //    Console.WriteLine($@"Idade : {Func.idade}");
        //    Console.WriteLine($@"Seu salario mes foi : {SalarioTotal}");
        //}
        
        static void Main(string[] args)
        {
            List<Funcionario> ListaFuncionario = new List<Funcionario>();

            for (int i = 1; i <= 3; i++)
            {
                // Funcionario Func = new Funcionario(i);
                Funcionario Func = new Funcionario();
                Console.WriteLine($@"Digite o nome do funcionario n {i}");
                Func.nome = Console.ReadLine();

                Console.WriteLine("Digite a idade do funcionario");
                Func.idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite quantidade de hrs trabalhadas  do funcionario");
                Func.TotalHorasMes = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite a nacionalidade do funcionario(br,ex)");
                Func.nacionalidade = Console.ReadLine();
                ListaFuncionario.Add(Func);
                Console.WriteLine("------------------------");
            }

            foreach (var Func in ListaFuncionario)
            {
                var resposta = CalculosFuncionario.tipoSupevisor;
                //var SalarioTotal = CalculosFuncionario.ReturnaSal(Func.TotalHorasMes, Func.nacionalidade);
                var SalarioTotal = CalculosFuncionario.ReturnaSal();
                Console.WriteLine($@"Cod : {Func.codigo}");
                Console.WriteLine($@"Funcionario : {Func.nome}");
                Console.WriteLine($@"Idade : {Func.idade}");
                Console.WriteLine($@"Seu salario mes foi : {SalarioTotal}");
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Fim do processamento");

        }
    }
}
