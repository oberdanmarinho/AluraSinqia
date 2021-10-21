using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5");

            char primeiraLetra = 'a';

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string Titulo = "Alura, cursos de tecnologia" + 2021;

            string Cursos = @"-.Net - Java - Javascript";

            Console.WriteLine(Titulo);
            Console.WriteLine(Cursos);

            Console.ReadLine();
        }
    }
}
