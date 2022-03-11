using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;

            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n; // a variável Fatorial sempre vai mudar o seu valor a cada vez que o For passar por ela, e ela vai assumir o valor da ultima passagem
                Console.WriteLine("O fatorial de " + n + " é " + fatorial);
            }
            Console.ReadLine();
        }
    }
}
