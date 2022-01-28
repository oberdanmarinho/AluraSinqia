using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteEscopo
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Calculo de aliquita");


			double salario = 3300.0;


			if (salario >= 1900 && salario <= 2800.0)
			{
				Console.WriteLine("Olá, seu IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
			}
			else if (salario >= 2800.01 && salario <= 3751.0)
			{
				Console.WriteLine("Olá, seu IR é de 15% e pode deduzir na declaração o valor de R$ 350");
			}
			else if (salario >= 3751.01 && salario <= 3664.00)
			{
				Console.WriteLine("Olá, seu IR é de 22.5% e pode deduzir na declaração o valor de R$ 636");
			}
			else
			{
				Console.WriteLine("Você náo tem imposto de renda declarado.");
			}

		}
	}
}
