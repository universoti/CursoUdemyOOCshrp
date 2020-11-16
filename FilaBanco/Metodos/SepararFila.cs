using System;
using System.Collections.Generic;
using System.Text;

namespace FilaBanco.Metodos
{
    public class SepararFila
    {
        //void  executa uma açao e nao devolve nada
        //tipos executa e devolve resposta
        // public   se é public ou privado
        //string     retorno a classe
        //OrganizarFila   nome do metodo
        //(int idade) propriedades de entrada de parametro

        public string OrganizarFila(int idade)
        {  //inicio
            string retorno = "";

            if (idade >= 65)
            {
                retorno = "Pessoa de fila prioritaria tipo b";
            }
            else
            {
                retorno = "Pessoa de fila normal tipo A";
            }

            return retorno;
        } //fim 

        public static string OrganizarFilaStatic(int idade)
        {  //inicio
            string retorno = "";

            if (idade >= 65)
            {
                retorno = "Pessoa de fila prioritaria tipo b";
            }
            else
            {
                retorno = "Pessoa de fila normal tipo A";
            }

            return retorno;
        } //fim 

    }
}
