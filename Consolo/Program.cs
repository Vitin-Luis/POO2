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
            AgendaTelefonica agenda = new AgendaTelefonica("Cássio");

            agenda.inserir("Cassio", "996474457");
        }
    }
}

