using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Bancaria
{
    internal class ContaCorrente
    {
        public int Id { get; set; }
        public String name { get; set; }
        public int NumeroAgencia { get; set; }
        public int Numero { get; set; }
        public Double Saldo { get; set; }

        public ContaCorrente(int id, string name, int numeroAgencia, int numero, double saldo)
        {
            Id = id;
            this.name = name;
            NumeroAgencia = numeroAgencia;
            Numero = numero;
            Saldo = saldo;
        }

        public ContaCorrente()
        {

        }

        public void deposito(double value)
        {
            Saldo += value;
        }

        public void saque(double value)
        {
            if (this.Saldo - value >= 0)
            {
                this.Saldo -= value;
            }
        }


        public string toString()
        {
            return "Nome: "+this.name+"\n"+
                   "Numero da agencia: " + this.NumeroAgencia + "\n" +
                   "Numero: " + this.Numero + "\n" +
                   "Saldo: " + this.Saldo;
        }
    }
}
