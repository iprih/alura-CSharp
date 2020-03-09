using System;

namespace _03___ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaRogerio = new ContaCorrente();
            ContaRogerio.titular = "Rogerio";
            ContaRogerio.agencia = 123;
            ContaRogerio.numero = 321456;

            ContaCorrente ContaRogerioTatu = new ContaCorrente();
            ContaRogerioTatu.titular = "Rogerio";
            ContaRogerioTatu.agencia = 123;
            ContaRogerioTatu.numero = 321456;

            Console.WriteLine("Igualdade de tipo de referencia: " + (ContaRogerio == ContaRogerioTatu));

            int idade1 = 30;
            int idade2 = 30;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade1 == idade2));

            ContaRogerio = ContaRogerioTatu;

            Console.WriteLine(ContaRogerio == ContaRogerioTatu);

            ContaRogerio.saldo = 300;
            Console.WriteLine(ContaRogerio.saldo);

            if (ContaRogerio.saldo >= 100)
            {
                ContaRogerio.saldo -= 100;
            }



        }
    }
}
