using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioOverrride
{
    public class Pai
    {
        public int idPai { get; set; }
        public string nomepai { get; set; }
        public virtual void ExibirMensagem()
        {
            
            Console.WriteLine("Eu sou o pai ");
        }
    }
}
