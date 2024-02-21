using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo
{
    public class ContaCorrente
    {
        private string proprietario { get; set; }
        private double saldo { get; set;  }

        public ContaCorrente(string proprietario, double saldo)
        {
            this.proprietario = proprietario;
            this.saldo = saldo;
        }


        public Boolean sacar(double valor_saque)
        {
            if (saldo >= valor_saque)
            {
                saldo -= valor_saque;
                Console.WriteLine($"\nSaque de { saldo } realizado.\n");
                return true;
            }
            else
            {
                Console.WriteLine("\nSaldo insuficiente!\n");
                return false;
            }
        }

        public Boolean depositar(double valor_deposito)
        {
            saldo += valor_deposito;
            Console.WriteLine($"\nDeposito de { saldo } realizado com sucesso.\n");
            return true;
        }
    }
}
