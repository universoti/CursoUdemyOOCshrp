using System;

namespace ExercicioVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            var executar = new ExecutarMetodos();
            executar.PreencherParametros();
            Console.WriteLine(ParametrosEstaticos.nome);
            Console.WriteLine(ParametrosEstaticos.smensagem);
        }
    }
}
