using System;

namespace Excecoes24
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Chamada em tela
                Console.WriteLine("digite a sua idade");
                int idade = Convert.ToInt32(Console.ReadLine());
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro"+ex.Message+"nao digitou nada");
               // throw ex;
            }
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
