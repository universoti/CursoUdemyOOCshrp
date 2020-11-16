using Ibge22.metodos;
using System;

namespace Ibge22
{
    class Program
    {
        static void Main(string[] args)
        {
            Estaticas Procesamento = new Estaticas();
            Console.WriteLine("Contar as pessoas");
            string contar = Console.ReadLine();
            bool bcontar = false;
            if (contar=="S")
            {
                bcontar = true;
            }
            Procesamento.TerminoProcessamento(bcontar);
            Console.WriteLine("Termino");
        }
    }
}
