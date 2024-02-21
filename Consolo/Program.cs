using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cont = new ContaCorrente("Victor", 10000);

            cont.depositar(1000000);
            cont.sacar(21);
        }
    }
}

