using System;
using System.Collections.Generic;
using System.Text;

namespace Ibge22.dados
{
    public class uf
    {
        public uf()
        {
            ListaEstados = new List<uf>();
            
        }
        public string sigla { get; set; }
        public string nome { get; set; }

        public List<uf> ListaEstados { get; set; }
    }
}
