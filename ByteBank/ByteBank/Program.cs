using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            

            Funcionario carlos = new Funcionario(2000, "12345679");
            carlos.Nome = "Carlos";
            //carlos.CPF = "123.456.789-10";
            //carlos.Salario = 2000;
            gerenciador.Registrar(carlos);
            
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("salario " + carlos.Salario);
            Console.WriteLine("bonificacao " + carlos.GetBonificacao());
            Console.WriteLine("salario atualizado com bonificacao " + carlos.Salario);
            carlos.AumentarSalario();
            Console.WriteLine("salario após aumento de salario " + carlos.Salario);

            Diretor priscila = new Diretor("789456766");
            priscila.Nome = "Priscila";
            //priscila.CPF = "123.456.789-10";
            //priscila.Salario = 4900;
            //gerenciador.Registrar(priscila);
            //Console.WriteLine(priscila.Nome);
            //Console.WriteLine(priscila.GetBonificacao());

            //Console.WriteLine("Total de bonificacao " + gerenciador.GetTotalBonificacao());

            //Console.WriteLine(Funcionario.TotalDeFuncionarios);
        }
    }
}
