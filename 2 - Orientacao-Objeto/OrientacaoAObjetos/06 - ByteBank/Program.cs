using System;

namespace _06___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Priscila";
            cliente.CPF = "123.456.789-91";
            cliente.Profissao = "Desenvolvedora";

            

            conta.Saldo = -10;
            conta.Titular = cliente;


            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
