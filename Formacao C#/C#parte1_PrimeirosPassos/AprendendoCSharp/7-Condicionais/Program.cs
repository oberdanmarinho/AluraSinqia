using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuntando projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 16)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João náo possui mais de 18 anos porém está acompanhado");
                }
                else
                {
                    Console.WriteLine("João possui menos de 18 anos, ele não pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
