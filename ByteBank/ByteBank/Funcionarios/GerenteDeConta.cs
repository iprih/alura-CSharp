﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(400, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
