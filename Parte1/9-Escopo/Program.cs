using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 . . . ");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;
              

            if (acompanhado == true)
            {
                mensagemAdicional = "João esta acompanhado";
            }
            else
                mensagemAdicional = "João não esta acompanhado";
            //sem chaves apenas se tiver uma linha
           



            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }


        Console.ReadLine();

        }
    }

}
