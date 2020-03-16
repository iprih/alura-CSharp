using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("123456789");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("123456789");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("123456789");
            igor.Nome = "Igor";

            GerenteDeConta iris = new GerenteDeConta("123456789");
            iris.Nome = "Iris";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(iris);

            Console.WriteLine("Total de bonificacao" + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
