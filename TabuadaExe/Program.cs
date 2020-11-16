using System;
using System.Collections.Generic;

namespace TabuadaExe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com o numero da tabuada!");
            var numero = Console.ReadLine();
            int multiplcador = 10;
            Console.WriteLine($@"Exibindo a tabuada do {numero}!");
            //solucao 1 + mais recomendavel 
            for (int i = 0; i <= multiplcador; i++)
            {
                int total = Convert.ToInt16(numero) * i;

                Console.WriteLine($@"{numero} x {i} = {total}");
            }

            //solucao 2 + menos recomendavel 
            List<int> mut = new List<int>() { 0, 1, 2, 3,4,5,6,7,8,9,10 };
            foreach (var item in mut)
            {
                int total = Convert.ToInt16(numero) * item;

                Console.WriteLine($@"{numero} x {item} = {total}");
            }
           
        }
    }
}
