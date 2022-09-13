using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(548, 1),
                new ContaCorrente(786, 9999),
                null,
                new ContaCorrente(358, 7),
                new ContaCorrente(1, 253),
                null
            };

            // contas.Sort();~> chama a implementação dada em IComparable

            // contas.Sort(new ComparadorContaCorrentePorAgencia());

           var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);
            
            foreach (var conta in contasOrdenadas)
            {
                 Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "luiza",
                "ana"
            };

            nomes.Sort();


            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            var idades = new List<int>();


            idades.Add(78888888);
            idades.Add(50);
            idades.Add(100);
            idades.AdicionarVarios(8, 56, 78, 254);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }


        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();


            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }


            Console.WriteLine(SomarVarios(1, 2, 3, 4, 74578));
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeContaCorrente()
        {

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaGui = new ContaCorrente(1111, 1111111);


            ContaCorrente[] contas = new ContaCorrente[]
            {
                    contaGui,
                    new ContaCorrente(847, 5674587),
                    new ContaCorrente(847, 5674545),
                    new ContaCorrente(847, 5674547)
            };

            lista.AdicionarVarios(contas);
            
            
            lista.AdicionarVarios(
                contaGui,
                new ContaCorrente(847, 5674587),
                new ContaCorrente(847, 5674587),
                new ContaCorrente(847, 5674545),
                new ContaCorrente(847, 5674545),
                new ContaCorrente(847, 5674545),
                new ContaCorrente(847, 5674545),
                new ContaCorrente(847, 5674545),
                new ContaCorrente(847, 5674545)
                );
   

            for (int i = 0; i<lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista.GetItemNoIndice(i);
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
}


        static void TestaArrayDeReferenciaContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
{
                new ContaCorrente(847, 5674587),
                new ContaCorrente(847, 5674545),
                new ContaCorrente(847, 5674547)
 };


            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // Array de inteiros com 5 posições
            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"valor da idades[{indice}] = {idade}");

                acumulador += idade;
            }


            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
