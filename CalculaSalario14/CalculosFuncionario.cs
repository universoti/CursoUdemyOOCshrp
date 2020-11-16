using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CalculaSalario14
{
    public class CalculosFuncionario
    {
        public static string tipoSupevisor = "Sim";  //exemplo capitulo 15

        //private decimal CalculaSal(decimal QtHoras,string nacionalidade)
        private static decimal CalculaSal(decimal QtHoras, string nacionalidade)
        {
            //refatorando...
            //decimal total = 0;

            //if (nacionalidade=="br")
            //{
            //    total = QtHoras * 150;
            //}
            //else
            //{
            //    total = QtHoras * 450;
            //}
            //return total;
            //if (tipoSupevisor=="Sim")  //exemplo capitulo 15
            //{

            //}
            return QtHoras * (nacionalidade == "br" ? 150 : 450);//<- tipo de if especial no csharp
        }

        //refatorando public decimal ReturnaSal(decimal pQtHoras, string pnacionalidade)
        public static decimal ReturnaSal(decimal pQtHoras, string pnacionalidade)
        {
            //melhorando nosso codigo - refatorando
            //decimal total = CalculaSal(pQtHoras, pnacionalidade);
           //return total;
           return CalculaSal(pQtHoras, pnacionalidade);
        }

        public static decimal ReturnaSal()
        {
           return CalculaSal(QtHoras:240,nacionalidade:"br");
        }
    }
}
