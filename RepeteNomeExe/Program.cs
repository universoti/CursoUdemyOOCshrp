using System;

namespace RepeteNomeExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome !");
            var nome = Console.ReadLine();

            Console.WriteLine("Entre com o numero para repetir !");
            var numero= Console.ReadLine();

            for (int i = 1; i <= Convert.ToInt16(numero); i++)
            {
                Console.WriteLine($@"Meu nome é {nome}");
            }

           
        }
    }
}
