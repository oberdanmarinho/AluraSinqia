using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Condicionais3");

            int idaddeJoao = 16;
            bool acompanhado = acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Hoáo está acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idaddeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");

            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
            Console.WriteLine(mensagemAdicional);


            Console.ReadLine();
        }
    }
}
