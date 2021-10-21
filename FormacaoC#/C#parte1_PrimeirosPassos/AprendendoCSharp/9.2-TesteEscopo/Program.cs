using System;

namespace TesteEscopo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Teste de escopo");


            int Idade = 20;
            int QuantidadePessoas = 1;
            bool acompanhado;

            if (QuantidadePessoas >= 2)
            {
                acompanhado = true;
                Console.WriteLine("Verdade");
            }
            else
            {
                acompanhado = false;
                Console.WriteLine("Mentira");
            }

            if (Idade > +18)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente vocë não pode entrar");
            }
        }
    }
}
