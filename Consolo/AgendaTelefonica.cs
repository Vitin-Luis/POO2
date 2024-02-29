using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo
{
    public class AgendaTelefonica
    {
        public string proprietario { get; set; }
        public List<Contato> contatos { get; set; }

        public Dictionary<string, Contato> dicionario { get; set; }



        public AgendaTelefonica(string proprietario)
        {
            //contatos = new List<Contato>();
            dicionario = new Dictionary<string, Contato>();
            this.proprietario = proprietario;
        }

        public void inserir(string nome, string numero)
        {
            dicionario.Add(nome, new Contato(nome, numero));
        }
        /*public Contato buscar(string nome)
        {
            foreach (Contato c in contatos)
            {
                if (c.nome.Contains(nome))
                {
                    return c;
                }
            }
            return null;
            
        }
        */

        public Contato buscaDicionario(string nome)
        {
            return dicionario[nome];
        }
        /*public void remover(string nome)
        {
            Contato c = buscar(nome);
            if (contatos.Remove(c))
            {
                Console.WriteLine("\nREMOVIDO!!\n");
            }
            else
            {
                Console.WriteLine("\nNÃO EXISTE ESSE CONTATO\n");
            }
        }
        */

        public void removerDicionario(string nome)
        {
            dicionario.Remove(nome);
        }
        public int tamanho()
        {
            
            return dicionario.Count;
        }
    }
}
