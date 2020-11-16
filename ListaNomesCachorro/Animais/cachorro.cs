using System;
using System.Collections.Generic;
using System.Text;

namespace ListaNomesCachorro.Animais
{
    public class cachorro
    {

        public string nome { get; set; }
        public int idade { get; set; }
        public string raca { get; set; }

        public string resultado_latir_cachorro(string disparar)
        {
            if (disparar == "chamar")
            {

            }
            return "auau";
        }

    }
}
