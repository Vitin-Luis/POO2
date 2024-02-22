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

        private string log { get; set; }

        public ContaCorrente(string proprietario, double saldo)
        {
            this.proprietario = proprietario;
            this.saldo = saldo;
            this.log = "\nConta criada\n";
        }


        public Boolean sacar(double valor_saque)
        {
            if (saldo >= valor_saque)
            {
                saldo -= valor_saque;
                this.log += "\nSaque de: " + valor_saque.ToString();
                return true;
            }
            else
            {
                this.log = "\nFalha no saque, sem dinheiro kk\n";
                return false;
            }
        }

        public Boolean depositar(double valor_deposito)
        {
            saldo += valor_deposito;
            this.log += "\nDeposito de: " + valor_deposito.ToString();
            return true;
        }
    }
}
