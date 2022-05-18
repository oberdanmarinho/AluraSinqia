using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BiteBank
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente contaDaGabriela = new ContaCorrente(); // objeto
      contaDaGabriela.titular = "Gabriela";                 // proprieade - atributo
      contaDaGabriela.agencia = 863;                        // propriedade - atributo
      contaDaGabriela.numero = 8652658;                     // propriedade - atributo

      ContaCorrente contaDaGabrielaCosta = new ContaCorrente(); // objeto
      contaDaGabriela.titular = "Gabriela";                     // propriedade - atributo
      contaDaGabriela.agencia = 863;                            // propriedade - atributo
      contaDaGabriela.numero = 8652658;                         // propriedade - atributo


      Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

      Console.ReadLine();
    }
  }
}
