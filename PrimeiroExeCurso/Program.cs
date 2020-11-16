using System;

namespace PrimeiroExeCurso
{
    class Program
    {
        //bool bConsumidorFinal;
        //decimal dValor;
        //double dValor1;
        //float fvalor;
        //int ivalor;
        //string snome = "Erick Fernando!";

        //var vnomemarktplace = "Udemy";
        //var vvalor = 0.00m;
        //var vbconsumidor = true;

        //bConsumidorFinal = true;
        //    dValor = 1 + 1;
        static void Main(string[] args)
        {
            //referente as aulas tipos de dados , var , operadores
            
            var total = 0.00;
            var valor1 = 0.00;
            var valor2 = 0.00;

            valor1 = 10;
            valor2 = 10;

            //processos matemáticos
            //soma
            total = valor1 + valor2;
            //subtracao
            total = valor1 - valor2;
            //divisao
            total = valor1 / valor2;
            //multiplicacao 
            total = valor1 * valor2;
            //concatenações
            var smsg1 = " mensagem1 ";
            var smsg2 = " mensagem2 ";
            var smensagem = smsg1 + smsg2;

            Console.WriteLine($@"Resultado Calculadora:{total} ");
        }
    }
}
