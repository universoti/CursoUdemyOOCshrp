using ListaNomesCachorro.Animais;
using ListaNomesCachorro.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ListaNomesCachorro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lchachorros = new List<string>();

            cachorro objcachorro = new cachorro();
            objcachorro.nome = "Rex";
            objcachorro.raca = "vira lata";
            objcachorro.idade = 1;


            var dono = new proprietario();
            dono.nome = "Erick Fernando";
            dono.vlcarteira = 1000;          

            #region codidodesativado
            //var nomecachorro = "Barney";
            //lchachorros.Add(nomecachorro);
            //Console.WriteLine("Cachorro " + nomecachorro + " adicionado");
            //nomecachorro = "Rex";
            //lchachorros.Add(nomecachorro);
            //Console.WriteLine("Cachorro " + nomecachorro + " adicionado");
            //nomecachorro = "Rim Tim Tim ";
            //lchachorros.Add(nomecachorro);
            //Console.WriteLine("Cachorro " + nomecachorro + " adicionado");
            #endregion
           
            //3 cachorros
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome do cachorro!");
                var nomecachorro = Console.ReadLine();
                lchachorros.Add(nomecachorro);
                Console.WriteLine("Cachorros "+ nomecachorro + " Adicionado com sucesso!");
            }

            foreach (var item in lchachorros.ToList())
            {                
                Console.WriteLine("Cachorros " + item + " Adicionado com sucesso!");
            }

           
        }
    }
}
