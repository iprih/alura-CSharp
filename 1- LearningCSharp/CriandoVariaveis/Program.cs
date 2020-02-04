using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2");

            int idade = 29;
            Console.WriteLine("Sua idade é "+ idade + "!");

            //
            double divisao = 15.0 / 2;
            Console.WriteLine(divisao*idade);

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);
            
            // long é uma variavel de 64 bits
            long idades = 13000000;
            Console.WriteLine(idades);

            //short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
