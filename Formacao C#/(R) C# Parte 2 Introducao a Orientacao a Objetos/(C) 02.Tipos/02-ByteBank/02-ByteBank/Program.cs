using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente conta = new ContaCorrente();

      conta.titular = "Gabriela";

      Console.WriteLine(conta.titular);
      Console.WriteLine(conta.saldo);


      Console.ReadLine();
    }
  }
}
