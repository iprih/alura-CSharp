using System;

namespace _05___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente priscila = new Cliente();

            //priscila.nome = "Priscila";
            //priscila.profissao = "Desenvolvedora";
            //priscila.cpf = "123456789";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = priscila;
            conta.titular = new Cliente();
            conta.titular.nome = "Priscila Silva";
            conta.titular.cpf = "123456789";
            conta.titular.profissao = "Desenvolvedora";
            conta.saldo = 500;
            conta.agencia = 456;
            conta.numero = 12345;

           //Console.WriteLine(priscila.nome);

            
           
            Console.WriteLine(conta.titular.nome + ", " + conta.titular.profissao);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
