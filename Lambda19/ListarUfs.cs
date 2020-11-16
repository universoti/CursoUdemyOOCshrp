using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda19
{
    public class ListarUfs
    {
        public List<Uf> PreencherUfs()
        {
            List<Uf> estados = new List<Uf>();

            estados.Add(new Uf() { sigla = "SP", nome = "São Paulo",aliq=10 });
            estados.Add(new Uf() { sigla = "RJ", nome = "Rio de Janeiro", aliq = 10 });
            estados.Add(new Uf() { sigla = "SC", nome = "Santa Catarina", aliq = 10 });
            estados.Add(new Uf() { sigla = "GO", nome = "Goais", aliq = 10 });
            estados.Add(new Uf() { sigla = "MG", nome = "Minas Gerias", aliq = 10 });
            estados.Add(new Uf() { sigla = "MG", nome = "Minas Gerias", aliq = 10 });
            estados.Add(new Uf() { sigla = "MT", nome = "Mato Grosso", aliq = 10 });
            return estados;
        }
    }
}
