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


        }
    }
}
