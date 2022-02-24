using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prejeto 4");

            double salario;
            salario = 1200.50;

            int salarioEInteiro;
            salarioEInteiro = (int)salario;

            Console.WriteLine(salarioEInteiro);
            
            
            Console.WriteLine("Finalizou");
            Console.ReadLine();
        }
    }
}
