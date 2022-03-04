using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoucanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            double vlrInvest = 1000;
           
            for (int cntMes = 1; cntMes <= 12; cntMes++)
            {
                vlrInvest *= 1.0036;
                Console.WriteLine("O valor de rendimento é " + vlrInvest + ".");
            }

            Console.ReadLine();
        }
    }
}
