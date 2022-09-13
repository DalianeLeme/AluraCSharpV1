using ByteBank_1.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_1.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
