using ByteBank;
using System;

namespace _02___ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Rogerio";

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
