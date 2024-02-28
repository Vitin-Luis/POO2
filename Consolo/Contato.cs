using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo
{
    public class Contato
    {
        public string nome { get; set; }
        public string numero { get; set; }

        public Contato(string nome, string numero)
        {
            this.nome = nome;
            this.numero = numero;
        }
    }
}
