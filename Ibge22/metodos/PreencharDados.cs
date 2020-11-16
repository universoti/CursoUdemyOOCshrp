using Ibge22.dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ibge22.metodos
{
    public class PreencharDados
    {
        public List<uf> PreencherUfs()
        {
            uf estados = new uf();

            estados.ListaEstados.Add(new uf() { sigla = "SP", nome = "São Paulo" });
            estados.ListaEstados.Add(new uf() { sigla = "RJ", nome = "Rio de Janeiro" });
            estados.ListaEstados.Add(new uf() { sigla = "SC", nome = "Santa Catarina" });
            estados.ListaEstados.Add(new uf() { sigla = "GO", nome = "Goais" });
            estados.ListaEstados.Add(new uf() { sigla = "MG", nome = "Minas Gerias" });
            estados.ListaEstados.Add(new uf() { sigla = "MT", nome = "Mato Grosso" });
            return estados.ListaEstados;
        }

        public List<Pessoas> PreecherPessoas()
        {
            var ListaEstados = PreencherUfs().ToList();
            var ListaPessoas = new List<Pessoas>();            
            ListaPessoas.Add(
                new Pessoas()
                {
                    idade = 23,
                    nome = "Elibae",
                    SiglaUf = "SP",
                    Estado = ListaEstados.
                            Where(c => c.sigla == "SP").
                            Select(c=>c.nome).FirstOrDefault()
                });
            ListaPessoas.Add(
                new Pessoas()
                {
                    idade = 30,
                    nome = "Fernanda",
                    SiglaUf = "RJ",
                    Estado = ListaEstados.
                            Where(c => c.sigla == "RJ").
                            Select(c => c.nome).FirstOrDefault()
                });

            return ListaPessoas;
        }

        //public List<Pessoas> PreecherPessoas()
        //{
        //    var ListaEstados = PreencherUfs();
        //    var ListaPessoas = new List<Pessoas>();

        //    var Pessoa = new Pessoas();
        //    Pessoa.idade = 22;
        //    Pessoa.nome = "Elibe";
        //    Pessoa.SiglaUf = "SP";
        //    foreach (var item in ListaEstados)
        //    {
        //        if (item.sigla == Pessoa.SiglaUf)
        //        {
        //            Pessoa.Estado = item.nome;
        //        }
        //    }
        //    ListaPessoas.Add(Pessoa);

        //    Pessoa = new Pessoas();
        //    Pessoa.idade = 30;
        //    Pessoa.nome = "Fernanda";
        //    Pessoa.SiglaUf = "RJ";
        //    foreach (var item in ListaEstados)
        //    {
        //        if (item.sigla == Pessoa.SiglaUf)
        //        {
        //            Pessoa.Estado = item.nome;
        //        }
        //    }
        //    ListaPessoas.Add(Pessoa);

        //    return ListaPessoas;
        //}
    }
}
