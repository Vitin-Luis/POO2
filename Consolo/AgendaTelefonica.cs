using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo
{
    public class AgendaTelefonica
    {
        List<Contato> contatos;

        public AgendaTelefonica(List<Contato> contatos)
        {
            contatos = new List<Contato>();
            this.contatos = contatos;
        }

        public void inserir(string nome, string numero)
        {
            contatos.Add(new Contato(nome, numero));
        }
        public string buscarNumero(string nome)
        {
            Contato contato;
            
        }
        public void remover(string nome)
        {
            contatos.RemoveAt();
        }
        public int tamanho()
        {
            int cont = 0;
            foreach (Contato contato in contatos)
            {
                cont++;
            }
            return cont;
        }
    }
}
