using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ProvaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;

            for (int multiplo = 1; multiplo <= 100; multiplo++)
            {
                //if (multiplo % 3 == 0)
                //{
                //    Console.WriteLine("---------> O numero `" + multiplo + "` é múltiplo de 3.");
                //}
                //else e
                //{
                //    Console.WriteLine("O numero " + multiplo + " náo é múltiplo de 3.");
                //}

                numero = multiplo % 3 == 0 ? "------>" + multiplo + " é múltiplo de 3." : multiplo + " não é múltiplo de 3.";

                Console.WriteLine(numero);
            }
            Console.ReadLine();
        }
    }
}
