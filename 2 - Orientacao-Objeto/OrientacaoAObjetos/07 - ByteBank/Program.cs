using System;

namespace _07___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(1234, 599995);
            ContaCorrente contaPri = new ContaCorrente(1234, 99996);
            ContaCorrente contaPi = new ContaCorrente(1234, 99996);
            //Console.WriteLine(conta.Agencia);
            //Console.WriteLine(conta.Numero);
            //Console.WriteLine(contaPri.Agencia);

            Console.WriteLine(ContaCorrente.QtdContasCriadas);

        }
    }
}
