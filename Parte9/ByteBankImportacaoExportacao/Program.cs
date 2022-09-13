using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    partial class Program 
    { 
        static void Main(string[] args)
        {

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo criado");

           var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine(bytesArquivo.Length);



            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }


            Console.ReadLine();



            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine(nome);


            UsarStreamDeEntrada();



            Console.WriteLine("Aplicação finalizada");

            Console.ReadLine();
        }
    }
} 
 