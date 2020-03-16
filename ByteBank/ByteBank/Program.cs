using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno= new SistemaInterno();
            
            Diretor rogerio = new Diretor("12312232132");
            rogerio.Nome = "Rogerio";
            rogerio.Senha = "123";

            GerenteDeConta iris = new GerenteDeConta("123456789");
            iris.Nome = "Iris";
            iris.Senha = "abc";

            Funcionario igor = new Auxiliar("123456789");            
            igor.Nome = "Igor";
            //igor.Senha = "1234";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "321";

            sistemaInterno.Logar(rogerio, "123");
            sistemaInterno.Logar(rogerio, "1234");
            sistemaInterno.Logar(parceiro, "321");
            //sistemaInterno.Logar(igor, "1234");

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

            Desenvolvedor rogerio = new Desenvolvedor("123456789");
            rogerio.Nome = "Rogerio";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(iris);
            gerenciadorBonificacao.Registrar(rogerio);

            Console.WriteLine("Total de bonificacao R$" + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
