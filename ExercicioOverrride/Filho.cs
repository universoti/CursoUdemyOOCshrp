using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioOverrride
{
    public class Filho:Pai
    {
        public int idFilho { get; set; }
        public string snomefilho { get; set; }
        public override void ExibirMensagem()
        {
            base.idPai = 1;
            base.nomepai = "Pai";
            base.ExibirMensagem();
            Console.WriteLine("eu sou o filho");
        }
    }
}
