using System;
using System.Collections.Generic;
using System.Text;

namespace Ibge22.metodos
{
    public class Termino
    {
        public virtual void TerminoProcessamento(bool bcontar)
        {
            Console.WriteLine("termino de processamento");
        }
    }
}
