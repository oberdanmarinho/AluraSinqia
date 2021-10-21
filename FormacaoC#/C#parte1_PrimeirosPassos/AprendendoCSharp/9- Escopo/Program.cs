using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuntando projeto 7");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "'João está acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }


            if (idadeJoao >= 16 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
