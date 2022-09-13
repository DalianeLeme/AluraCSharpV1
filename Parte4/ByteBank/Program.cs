using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }


            Console.WriteLine("A execução foi finalizada. Tecle enter para sair");
            Console.ReadLine();

        }

        private static void CarregarContas()
        {

            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                //IDisposable
                leitor.LerProximaLinha();
            }






            // ------------------------------------------------

            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas1.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");

            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //   }
           // }
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}

// ---------------------------------------------------------

//try
//{
//    ContaCorrente conta = new ContaCorrente(456, 4568772);
//    ContaCorrente conta2 = new ContaCorrente(574, 245674);

//    conta2.Transferir(10000, conta);

//    conta.Depositar(50);
//    Console.WriteLine(conta.Saldo);
//    conta.Sacar(-500);
//    Console.WriteLine(conta.Saldo);

//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Argumento com problema: " + ex.ParamName);
//    Console.WriteLine( "Ocorreu uma exceção do tipo ArgumentException");
//    Console.WriteLine( ex.Message );
//}
//catch (SaldoInsuficienteException ex)
//{
//    Console.WriteLine(ex.Saldo);
//    Console.WriteLine(ex.ValorSaque);

//    Console.WriteLine(ex.StackTrace);

//    Console.WriteLine(ex.Message);
//    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.ReadLine();





//-------------------------------------------------------------





/* static void Main(string[] args)
{
    try
    {
        Metodo();
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
        Console.WriteLine("Aconteceu um erro!");
    }

    Console.ReadLine();
}

//Teste com a cadeia de chamada:
//Metodo -> TestaDivisao -> Dividir
private static void Metodo()
{
    TestaDivisao(0);
}

public static void TestaDivisao(int divisor)
{
    int resultado = Dividir(10, divisor);
    Console.WriteLine("Resultado da divisão de 10 por " + " é " + resultado);
}

private static int Dividir(int numero, int divisor)
{
    try
    {
        return numero / divisor;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Exceção com numero = " + numero);
        throw;
    }
} */






