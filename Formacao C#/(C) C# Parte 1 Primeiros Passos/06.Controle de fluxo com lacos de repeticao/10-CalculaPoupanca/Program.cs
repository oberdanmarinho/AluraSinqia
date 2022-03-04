using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Caucula poupança");

            double vlInvest = 1000;
            int cntMes = 1;
            string vl;

            while (cntMes <= 12)
            {
                vlInvest = vlInvest + vlInvest * 0.0036;

                //if (cntMes <= 1)
                //{
                //    Console.WriteLine("Após " + cntMes + " mês, você terá R$" + vlInvest + "!");
                //}
                //else 
                //{
                //    Console.WriteLine("Após " + cntMes + " meses, você terá R$" + vlInvest + "!");
                //}

                vl = cntMes <= 1 ? "Após " + cntMes + " mês, você terá R$" + vlInvest + "!" : "Após " + cntMes + " meses, você terá R$" + vlInvest + "!";

                Console.WriteLine(vl);

                cntMes++;
            }

            Console.ReadLine();
        }
    }
}
