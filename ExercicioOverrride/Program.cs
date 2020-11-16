using System;

namespace ExercicioOverrride
{
    class Program
    {
        static void Main(string[] args)
        {
            var fl = new Filho();
            fl.ExibirMensagem();
            fl.idFilho = 2;
            fl.snomefilho = "filho";
            Console.WriteLine(fl.idPai.ToString());
            Console.WriteLine(fl.nomepai);
            Console.WriteLine(fl.idFilho.ToString());
            Console.WriteLine(fl.snomefilho);
        }
    }
}
