using System;
using System.Collections.Generic;
using System.Text;

namespace Ibge22.dados
{
    public partial class Pessoas
    {
        public Pessoas()
        {            
            //ListaPessoas = new List<Pessoas>();
            
        }
        public int idade { get; set; }
        public string nome { get; set; }
        public string Estado { get; set; }   //a descriçao do estado
        public string SiglaUf { get; set; }

        //public List<Pessoas> ListaPessoas { get; set; }
    }
}
