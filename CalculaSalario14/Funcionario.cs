using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaSalario14
{
    public class Funcionario
    {
        public Funcionario(int cod) 
        {
            codigo = cod;
            nacionalidade = "br";
            Estados = new List<uf>();
            var obj = new uf();
            obj.sigla = "SP";
            obj.nome = "São Paulo";
            Estados.Add(obj);
            Estados.Add(new uf { sigla = "AC", nome = "Acre" });
            Estados.Add(new uf { sigla = "AL", nome = "Alagoas" });
            Estados.Add(new uf { sigla = "AP", nome = "Amapá" });
            Estados.Add(new uf { sigla = "GO", nome = "Goiás" });
            Estados.Add(new uf { sigla = "RJ", nome = "Rio de Janeiro" });

        }
        public Funcionario()
        {
            Estados = new List<uf>();
        }
        
        public int codigo { get; set; }
        public string  nome { get; set; }
        public int idade { get; set; }
        public decimal TotalHorasMes { get; set; }

        public string nacionalidade { get; set; }

        public List<uf> Estados;

    }
}
