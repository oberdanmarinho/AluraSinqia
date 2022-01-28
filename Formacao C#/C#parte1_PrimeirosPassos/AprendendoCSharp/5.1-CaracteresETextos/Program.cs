using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 6 - exercicio");

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "Ola mundo, estou no meio do curso";
            Console.WriteLine(palavra);

            palavra = palavra + " em " + 2021;
            Console.WriteLine(palavra);

            Console.ReadLine();
        }
    }
}
