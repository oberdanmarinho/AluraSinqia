using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario = 1200.50;
            int salarioInteio = (int)salario;

            Console.WriteLine(salarioInteio);

            Console.WriteLine("Fim da execução. Aperte 'Enter' para encerrar.");
            Console.ReadLine();
        }
    }
}
