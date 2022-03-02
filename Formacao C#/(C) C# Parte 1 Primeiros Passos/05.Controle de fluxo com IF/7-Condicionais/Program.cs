using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idaddeJoao = 16;
            int idadeJose = 18;

            if (idaddeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }

            Console.ReadLine();
        }
    }
}
