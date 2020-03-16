using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{

    public class Diretor : Funcionario
    {
        //public string Nome { get; set; }
        //public string CPF { get; set; }
        //public double Salario { get; set; }
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Novo Diretor");
     
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
            //base.AumentarSalario(); 
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
            //return Salario + base.GetBonificacao();

        }
    }
}
