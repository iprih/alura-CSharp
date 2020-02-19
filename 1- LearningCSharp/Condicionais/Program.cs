using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            int qtdPessoas = 1;

            if (idade >= 18 || qtdPessoas >=2)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Nao pode entrar");
            }

            int idade2 = 68;
            bool ehIdoso = idade2 >= 65;
            Console.WriteLine(ehIdoso);

            Console.ReadLine();
        }
    }
}
