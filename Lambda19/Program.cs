using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda19
{
    class Program
    {
        static void Main(string[] args)
        {
            //select - escolhe os atributos
            // where = filtra um resultado
            //sum = soma
            //distinct - tira resultados repetidos

            var Listar = new ListarUfs();
            var Lestados = Listar.PreencherUfs().ToList();
            string  nome = Lestados.Select(c => c.nome).FirstOrDefault();  //select traz os campos
            string nome_selecionado = Lestados.Where(c => c.sigla == "RJ").Select(c => c.sigla).FirstOrDefault();
            decimal valorsomado = Lestados.Sum(c => c.aliq);

            List<string> lnomes = Lestados.Where(s => s.sigla == "SP").Select(sel=>sel.nome).ToList();
            List<string> lnomes2 = Lestados.Select(sel => sel.nome).Distinct().ToList();

            Console.WriteLine("Hello World!");
        }
    }
}
