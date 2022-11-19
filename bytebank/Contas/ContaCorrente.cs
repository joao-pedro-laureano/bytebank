using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            set {
                if (value>0)
                {
                    this.numero_agencia = value;
                } 
            }
        }

        public string conta;
        public string titular;
        private double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {

                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
    }
}
