using System;

namespace TerceiroExe
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            Console.WriteLine("Digite a sua idade:");
            idade = Convert.ToInt16(Console.ReadLine());
            string resultado = idade.ToString();
            
            Console.WriteLine("O Erick tem ! "+ resultado+" anos");
        }
    }
}
