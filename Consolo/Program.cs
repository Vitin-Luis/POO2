using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo
{
    public class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica("Cássio");

            agenda.inserir("Daniel", "99699782");
            agenda.inserir("Victor", "996474457");
            agenda.inserir("Lucas", "99545378");
            Console.WriteLine(agenda.buscaDicionario("Victor"));
            Console.WriteLine($"{agenda.tamanho()}");
            agenda.removerDicionario("Victor");
            Console.WriteLine($"{agenda.tamanho()}");
        }
    }
}

