using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSEMBUG
{
    internal class Program
    {
           static void Main(string[] args)
            {

                private static void TestaInnerException()
                {
                    try
                    {
                        ContaCorrente conta1 = new ContaCorrente(456, 568875);
                        ContaCorrente conta2 = new ContaCorrente(5487, 548744314);


                        //conta1.Transferir(100000, conta2);
                        conta1.Sacar(1000);
                    }
                    catch (OperacaoFinanceiraException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.StackTrace);


                        //Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");         
                    }
                }

                Console.WriteLine("Execução finalizada. Tecle enter para sair");
                Console.ReadLine();
            }

        private static void CarregarContas()
        {
            LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt");
        }
    }
    }
