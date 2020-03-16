using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public interface Autenticavel //contrato
    {
        bool Autenticar(string senha);

    }
}
