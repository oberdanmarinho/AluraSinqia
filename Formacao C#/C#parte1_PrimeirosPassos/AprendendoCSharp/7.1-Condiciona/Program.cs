using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 20;
            int pessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Maior que 18");
            }
            else
            {
                if (pessoas >= 3)
                {
                    Console.WriteLine("3 ou mais pessoas, tudo certo");
                }
                else
                {
                    Console.WriteLine("Menos de 3 pessoas, não pode.");
                }
                Console.WriteLine("Menor que 18");
            }




            Console.ReadLine();
        }
    }
}
