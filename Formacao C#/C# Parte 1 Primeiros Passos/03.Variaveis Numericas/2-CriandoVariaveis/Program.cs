using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2. Criando variáveis");

            int idade;
            idade = 32;


            Console.WriteLine(idade);

            idade = 10;
            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.Write(idade);
            
            Console.WriteLine("Finalizou");
            Console.ReadLine();
        }
    }
}
