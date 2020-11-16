using Ibge22.dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ibge22.metodos
{
    public class Estaticas:Termino
    {
        public override void TerminoProcessamento(bool bcontar)
        {
            var ContSp = 0;
            var ContRj = 0;
            var ContMg = 0;
            var ContMt = 0;
            if (bcontar)
            {               
                List<Pessoas> PessoasListadas = 
                    new PreencharDados().PreecherPessoas().ToList(); //Pes.PreecherPessoas();
                // .COUNT - SERVE PRA VOCE CONTAR QUANTOS TEM NO OBJETO
                ContSp = PessoasListadas.Where(c => c.SiglaUf == "SP").Count();
                ContRj = PessoasListadas.Where(c => c.SiglaUf == "RJ").Count();
                ContMg = PessoasListadas.Where(c => c.SiglaUf == "MG").Count();
                ContMt = PessoasListadas.Where(c => c.SiglaUf == "MT").Count();
               
            }
           

            Console.WriteLine("Estatisca Sp: "+ContSp);
            Console.WriteLine("Estatisca Rj: " + ContRj);
        }

        //public override void TerminoProcessamento(bool bcontar)
        //{
        //    var ContSp = 0;
        //    var ContRj = 0;
        //    var ContMg = 0;
        //    var ContMt = 0;
        //    if (bcontar)
        //    {
        //        //Pessoas Pes = new Pessoas();
        //        //PreencharDados Pes = new PreencharDados();
        //        List<Pessoas> PessoasListadas = new PreencharDados().PreecherPessoas(); //Pes.PreecherPessoas();


        //        foreach (var item in PessoasListadas)
        //        {
        //            if (item.SiglaUf == "SP")
        //            {
        //                ContSp = ContSp + 1;
        //            }

        //            if (item.SiglaUf == "MG")
        //            {
        //                ContMg = ContMg + 1;
        //            }

        //            if (item.SiglaUf == "RJ")
        //            {
        //                ContRj = ContRj + 1;
        //            }
        //            if (item.SiglaUf == "MT")
        //            {
        //                ContMt = ContMt + 1;
        //            }
        //        }



        //    }


        //    Console.WriteLine("Estatisca Sp: " + ContSp);
        //    Console.WriteLine("Estatisca Rj: " + ContRj);
        //}
    }
}
