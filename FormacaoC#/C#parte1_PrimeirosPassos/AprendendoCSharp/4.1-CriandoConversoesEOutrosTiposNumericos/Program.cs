using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_CriandoConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1700.50;
            int valor = (int)salario;

            Console.WriteLine(valor);

            double valor1 = 10;
            double valor2 = 20;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            float pontoFlutuante = (float)3.14;
            Console.WriteLine(pontoFlutuante);

            Console.WriteLine("Fim da execução. Pressione 'Enter' para encerrar. ");
            Console.ReadLine();
        }
    }
}
