using FilaBanco.Metodos;
using FilaBanco.Publico;
using System;

namespace FilaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            string retornofila = "";
            PublicoBanco pessoal= new PublicoBanco();
            Console.WriteLine("Digite sua idade");
            pessoal.idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o motivo da vinda");
            pessoal.Motivo = Console.ReadLine();

            //SepararFila separar= new SepararFila();
            //retornofila = separar.OrganizarFila(pessoal.idade);
            retornofila = SepararFila.OrganizarFilaStatic(pessoal.idade);

            Console.WriteLine(retornofila);
        }
    }
}
