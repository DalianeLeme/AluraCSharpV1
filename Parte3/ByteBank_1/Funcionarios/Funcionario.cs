using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_1.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarois { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarois++;
        }

        public abstract void AumentarSalario();


        // ObterBonificacao
        public abstract double GetBonificacao();
    }
}
