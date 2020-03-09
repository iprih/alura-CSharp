using System;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaPriscila = new ContaCorrente();
            contaPriscila.titular = "priscila";
            Console.WriteLine("O saldo original é: " + contaPriscila.saldo) ;
            bool resultadoSaque = contaPriscila.Sacar(30);
            Console.WriteLine("Após o saque o saldo é: " + contaPriscila.saldo);
            Console.WriteLine(resultadoSaque);

            contaPriscila.Depositar(500);
            Console.WriteLine(contaPriscila.saldo);

            ContaCorrente contaRogerio = new ContaCorrente();

            contaRogerio.titular = "Rogerio";

            Console.WriteLine("Saldo Pri :" + contaPriscila.saldo);
            Console.WriteLine("Saldo Rogerio :" + contaRogerio.saldo);

            bool resultadoTransferencia = contaPriscila.Transferir(200, contaRogerio);

            Console.WriteLine("Saldo Pri: " + contaPriscila.saldo);
            Console.WriteLine("Saldo Rogerio: " + contaRogerio.saldo);
            Console.WriteLine(resultadoTransferencia);

            contaRogerio.Transferir(100, contaPriscila);

            Console.WriteLine("Saldo Pri: " + contaPriscila.saldo);
            Console.WriteLine("Saldo Rogerio: " + contaRogerio.saldo);
            Console.WriteLine(resultadoTransferencia);

        }
    }
}
